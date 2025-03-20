namespace BlueWhatsapp.Core.Utils;

/// <summary>
/// 
/// </summary>
public class HotelMatcher : IHotelMatcher
{

    public HotelMatcher()
    {
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hotelName"></param>
    /// <param name="threshold"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    List<dynamic> IHotelMatcher.FindMatches(string hotelName, double threshold = 0.7)
    {
        throw new NotImplementedException();
    }
}