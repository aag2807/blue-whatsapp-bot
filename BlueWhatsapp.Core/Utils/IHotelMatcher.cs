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
    public List<dynamic> FindMatches(string hotelName, double threshold = 0.7);
}