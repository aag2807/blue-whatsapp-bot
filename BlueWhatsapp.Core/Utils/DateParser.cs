using System.Globalization;
using System.Text;
using BlueWhatsapp.Core.Models;

namespace BlueWhatsapp.Core.Utils;

public class DateParser
{
    private readonly List<CultureInfo> _supportedCultures;
    private readonly List<string> _customDateFormats;

    public DateParser()
    {
        // Initialize with the specific languages required
        _supportedCultures = new List<CultureInfo>
            {
                CultureInfo.InvariantCulture,
                new CultureInfo("es-ES"),  // Spanish (Spain)
                new CultureInfo("es-MX"),  // Spanish (Mexico)
                new CultureInfo("en-US"),  // English (US)
                new CultureInfo("en-GB"),  // English (UK)
                new CultureInfo("fr-FR"),  // French
                new CultureInfo("ru-RU"),  // Russian
                new CultureInfo("pt-BR"),  // Portuguese (Brazil)
                new CultureInfo("pt-PT"),  // Portuguese (Portugal)
                new CultureInfo("zh-CN"),  // Chinese (Simplified - Mandarin)
                // You can add more variants of these languages if needed
            };

        // Custom date formats for all required languages
        _customDateFormats = new List<string>
            {
                // Spanish formats
                "d 'de' MMMM",        // "25 de agosto"
                "d 'de' MMMM 'de' yyyy",   // "25 de agosto de 2023"
                
                // English formats
                "d MMM",              // "25 Aug"
                "MMM d",              // "Aug 25"
                "MMMM d",             // "August 25"
                "MMMM d, yyyy",       // "August 25, 2023"
                "d MMMM yyyy",        // "25 August 2023"
                
                // French formats
                "d MMMM",             // "25 août"
                "d MMMM yyyy",        // "25 août 2023"
                "le d MMMM",          // "le 25 août"
                "le d MMMM yyyy",     // "le 25 août 2023"
                
                // Russian formats
                "d MMMM",             // "25 августа"
                "d MMMM yyyy 'г.'",   // "25 августа 2023 г."
                
                // Portuguese formats
                "d 'de' MMMM",        // "25 de agosto"
                "d 'de' MMMM 'de' yyyy", // "25 de agosto de 2023"
                
                // Chinese formats (note: Chinese typically uses numeric formats)
                "yyyy'年'M'月'd'日'", // "2023年8月25日"
                
                // Common numeric formats
                "d/M/yyyy",           // "25/8/2023"
                "M/d/yyyy",           // "8/25/2023"
                "yyyy-MM-dd",         // "2023-08-25" (ISO format)
                "yyyy/MM/dd",         // "2023/08/25"
                "dd.MM.yyyy",         // "25.08.2023" (common in Russia)
                "dd-MM-yyyy",         // "25-08-2023"
                "yyyyMMdd",           // "20230825"
                
                // Short formats without year (will infer current year)
                "d MMM",              // "25 Aug"
                "MMM d",              // "Aug 25"
                "d/M",                // "25/8"
                "M/d",                // "8/25"
                "d.M",                // "25.8"
            };
    }

    /// <summary>
    /// Attempts to parse a date string and returns a DateTime object if successful
    /// </summary>
    /// <param name="dateString">The date string to parse</param>
    /// <returns>A DateTime object if parsing succeeds, or null if parsing fails</returns>
    public DateTime? TryParseDateTime(string dateString)
    {
        if (string.IsNullOrWhiteSpace(dateString))
        {
            throw new ArgumentNullException(nameof(dateString));
        }

        // Clean up the input
        string cleanDateString = dateString.Trim();

        // Try to infer the current year if not provided
        bool inferYear = !cleanDateString.Any(char.IsDigit) ||
                         !cleanDateString.Any(c => char.IsDigit(c) && int.Parse(c.ToString()) > 3);

        DateTime result;

        foreach (var culture in _supportedCultures)
        {
            if (DateTime.TryParse(cleanDateString, culture, DateTimeStyles.None, out result))
            {
                if (inferYear)
                {
                    result = new DateTime(DateTime.Now.Year, result.Month, result.Day);
                }

                return result;
            }

            foreach (var format in _customDateFormats)
            {
                if (DateTime.TryParseExact(cleanDateString, format, culture,
                        DateTimeStyles.None, out result))
                {
                    if (inferYear && result.Year == 1)
                        result = new DateTime(DateTime.Now.Year, result.Month, result.Day);

                    return result;
                }
            }
        }

        // Try advanced parsing
        string advancedResult = TryAdvancedParsing(cleanDateString, "yyyy-MM-dd");
        if (advancedResult != null)
        {
            if (DateTime.TryParseExact(advancedResult, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out result))
            {
                return result;
            }
        }

        // If parsing failed, return null
        return null;
    }
    
    /// <summary>
    /// Attempts to parse a date string in various formats and cultures
    /// </summary>
    /// <param name="dateString">The date string to parse</param>
    /// <param name="outputFormat">Optional format for the output date string</param>
    /// <returns>A parsed date in the desired format or null if parsing fails</returns>
    public string TryParseDate(string dateString, string outputFormat = "yyyy-MM-dd")
    {
        if (string.IsNullOrWhiteSpace(dateString))
        {
            throw new ArgumentNullException(nameof(dateString));
        }

        // Clean up the input
        dateString = dateString.Trim();

        // Try to infer the current year if not provided
        bool inferYear = !dateString.Any(char.IsDigit) ||
                         !dateString.Any(c => char.IsDigit(c) && int.Parse(c.ToString()) > 3);

        DateTime result;

        foreach (var culture in _supportedCultures)
        {
            if (DateTime.TryParse(dateString, culture, DateTimeStyles.None, out result))
            {
                if (inferYear)
                {
                    result = new DateTime(DateTime.Now.Year, result.Month, result.Day);
                }

                return result.ToString(outputFormat, CultureInfo.InvariantCulture);
            }

            foreach (var format in _customDateFormats)
            {
                if (DateTime.TryParseExact(dateString, format, culture,
                    DateTimeStyles.None, out result))
                {
                    if (inferYear && result.Year == 1)
                        result = new DateTime(DateTime.Now.Year, result.Month, result.Day);

                    return result.ToString(outputFormat, CultureInfo.InvariantCulture);
                }
            }
        }

        return TryAdvancedParsing(dateString, outputFormat);
    }

    /// <summary>
    /// Attempts more advanced parsing techniques for complex or unusual date formats
    /// </summary>
    private string TryAdvancedParsing(string dateString, string outputFormat)
    {

        string[] months = {
                // Spanish
                "enero", "febrero", "marzo", "abril", "mayo", "junio",
                "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre",
                
                // English
                "january", "february", "march", "april", "may", "june",
                "july", "august", "september", "october", "november", "december",
                
                // French
                "janvier", "février", "mars", "avril", "mai", "juin",
                "juillet", "août", "septembre", "octobre", "novembre", "décembre",
                
                // Russian
                "январь", "февраль", "март", "апрель", "май", "июнь",
                "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь",
                "января", "февраля", "марта", "апреля", "мая", "июня",
                "июля", "августа", "сентября", "октября", "ноября", "декабря",
                
                // Portuguese
                "janeiro", "fevereiro", "março", "abril", "maio", "junho",
                "julho", "agosto", "setembro", "outubro", "novembro", "dezembro",
                
                // Chinese (pinyin romanization)
                "yiyue", "eryue", "sanyue", "siyue", "wuyue", "liuyue",
                "qiyue", "bayue", "jiuyue", "shiyue", "shiyiyue", "shieryue",
                
                // Chinese characters
                "一月", "二月", "三月", "四月", "五月", "六月",
                "七月", "八月", "九月", "十月", "十一月", "十二月"
            };

        string[] prepositions = {
                "de", "del", // Spanish, Portuguese
                "of", "on",  // English
                "du", "le",  // French
                "от", "с",   // Russian
                "年", "月", "日", "号" // Chinese date markers
            };

        foreach (var prep in prepositions)
        {
            dateString = dateString.Replace($" {prep} ", " ");
        }

        var parts = dateString.Split(new[] { ' ', ',', '/', '-', '.' },
            StringSplitOptions.RemoveEmptyEntries)
            .Select(p => p.Trim().ToLower())
            .ToList();

        int? day = null;
        int? month = null;
        int? year = null;

        foreach (var part in parts)
        {
            if (int.TryParse(part, out int number))
            {
                if (number >= 1 && number <= 31 && day == null)
                {
                    day = number;
                }
                else if (number >= 1 && number <= 12 && month == null)
                {
                    month = number;
                }
                else if (number >= 1000 && number <= 9999 && year == null)
                {
                    year = number;
                }
                // Handle 2-digit years
                else if (number >= 0 && number <= 99 && year == null)
                {
                    year = number < 50 ? 2000 + number : 1900 + number;
                }
            }
            else
            {
                for (int i = 0; i < months.Length; i++)
                {
                    if (months[i].StartsWith(part) || part.StartsWith(months[i]))
                    {
                        month = (i % 12) + 1;
                        break;
                    }
                }
            }
        }

        if (day.HasValue && month.HasValue)
        {
            try
            {
                DateTime result = new DateTime(
                    year ?? DateTime.Now.Year,
                    month.Value,
                    day.Value);

                return result.ToString(outputFormat, CultureInfo.InvariantCulture);
            }
            catch (ArgumentOutOfRangeException)
            {
                // Invalid date components
                return null;
            }
        }

        // Could not parse the date
        return null;
    }
}