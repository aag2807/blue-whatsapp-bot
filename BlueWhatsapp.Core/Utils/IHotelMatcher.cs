using BlueWhatsapp.Core.Models;

namespace BlueWhatsapp.Core.Utils;

/// <summary>
/// 
/// </summary>
public interface IHotelMatcher
{
    /// <summary>
    /// Finds hotels that match the given name above a certain similarity threshold.
    /// </summary>
    /// <param name="hotelName">The name to search for</param>
    /// <param name="threshold">Minimum similarity score (0-1)</param>
    /// <returns>Hotels with similarity scores in descending order</returns>
    public List<HotelMatch> FindMatches(string hotelName, double threshold = 0.7);

    /// <summary>
    /// Presents the matches as a numbered list to show to the user.
    /// </summary>
    public string FormatMatchesForDisplay(List<HotelMatch> matches, int maxToShow = 5);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hotels"></param>
    public void SetHotelData(ICollection<CoreHotel> hotels);
}