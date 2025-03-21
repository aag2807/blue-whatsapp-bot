using System.Text;
using BlueWhatsapp.Core.Models;

namespace BlueWhatsapp.Core.Utils;

/// <summary>
/// 
/// </summary>
public class HotelMatcher : IHotelMatcher
{
    private readonly List<CoreHotel> _hotels = new();

    public HotelMatcher()
    {
    }

    /// <inheritdoc />
    List<HotelMatch> IHotelMatcher.FindMatches(string hotelName, double threshold = 0.6)
    {
        if (string.IsNullOrWhiteSpace(hotelName))
            return new List<HotelMatch>();

        var matches = new List<HotelMatch>();
        string normalizedInput = NormalizeText(hotelName);

        foreach (var hotel in _hotels)
        {
            string normalizedHotelName = NormalizeText(hotel.Name);

            // Check for exact brand matching (e.g., "hyatt" in "hyatt zilara")
            bool isExactBrandMatch = false;
            string[] inputWords = normalizedInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] hotelWords = normalizedHotelName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in inputWords)
            {
                if (hotelWords.Any(hw => hw.Equals(word, StringComparison.OrdinalIgnoreCase)))
                {
                    isExactBrandMatch = true;
                    break;
                }
            }

            // Calculate standard similarity
            double similarity = CalculateSimilarity(normalizedInput, normalizedHotelName);

            // Boost score for exact brand matches
            if (isExactBrandMatch)
            {
                similarity = Math.Max(similarity, 0.7);
            }

            if (similarity >= threshold)
            {
                matches.Add(new HotelMatch
                {
                    Hotel = hotel,
                    Score = (float)similarity
                });
            }
        }

        return matches
            .OrderByDescending(m => m.Score)
            .ToList();
    }

    /// <inheritdoc />
    string IHotelMatcher.FormatMatchesForDisplay(List<HotelMatch> matches, int maxToShow = 5)
    {
        if (matches == null || !matches.Any())
        {
            return "No matching hotels found.";
        }

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("I found these possible matches:");

        int count = 0;
        foreach (var match in matches.Take(maxToShow))
        {
            count++;
            sb.AppendLine($"{count}. {match.Hotel.Name} ({match.Hotel.Name}) - {match.Score:P0} match");
        }

        if (matches.Count > maxToShow)
        {
            sb.AppendLine($"...and {matches.Count - maxToShow} more matches.");
        }

        sb.AppendLine("\nPlease reply with the number of the correct hotel, or type the name again more precisely.");

        return sb.ToString();
    }

    /// <inheritdoc />
    void IHotelMatcher.SetHotelData(ICollection<CoreHotel> hotels)
    {
        _hotels.Clear();
        if (hotels.Any())
        {
            _hotels.AddRange(hotels);
        }
    }

    /// <summary>
    /// Calculates the similarity between two strings using Levenshtein distance.
    /// </summary>
    /// <returns>A score between 0 and 1, where 1 means exact match</returns>
    private double CalculateSimilarity(string s1, string s2)
    {
        int distance = LevenshteinDistance(s1, s2);
        int maxLength = Math.Max(s1.Length, s2.Length);

        if (maxLength == 0)
        {
            return 1.0;
        }

        // Convert to similarity (0-1)
        return 1.0 - ((double)distance / maxLength);
    }

    /// <summary>
    /// Calculates the Levenshtein (edit) distance between two strings.
    /// </summary>
    private int LevenshteinDistance(string s, string t)
    {
        // Levenshtein Distance implementation
        int n = s.Length;
        int m = t.Length;

        // Special cases
        if (n == 0)
        {
            return m;
        }
        if (m == 0) return n;

        // Create distance matrix
        int[,] d = new int[n + 1, m + 1];

        // Initialize first column and first row
        for (int i = 0; i <= n; i++) d[i, 0] = i;
        for (int j = 0; j <= m; j++) d[0, j] = j;

        // Compute the distance
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                d[i, j] = Math.Min(
                    Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                    d[i - 1, j - 1] + cost
                );
            }
        }

        return d[n, m];
    }

    /// <summary>
    /// Normalizes text to improve matching quality.
    /// </summary>
    private string NormalizeText(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return string.Empty;
        }

        // Convert to lowercase
        string result = text.ToLowerInvariant();

        // Remove common words that don't add value for matching
        string[] wordsToRemove = { "hotel", "resort", "inn", "suites", "the", "and", "&" };
        foreach (var word in wordsToRemove)
        {
            result = result.Replace($" {word} ", " ")
                .Replace($" {word}", "")
                .Replace($"{word} ", "");
        }

        StringBuilder sb = new StringBuilder();
        foreach (char c in result)
        {
            if (!char.IsPunctuation(c))
                sb.Append(c);
        }

        // Remove extra spaces
        result = sb.ToString();
        while (result.Contains("  "))
        {
            result = result.Replace("  ", " ");
        }

        return result.Trim();
    }
}