using BlueWhatsapp.Core.Models;

namespace BlueWhatsapp.Core.Services;

public interface IPricingService
{
    /// <summary>
    /// Calculates the total VIP price for a hotel based on the number of people
    /// </summary>
    /// <param name="hotel">The hotel for pricing calculation</param>
    /// <param name="adults">Number of adults</param>
    /// <param name="children">Number of children</param>
    /// <returns>Total price in USD</returns>
    decimal CalculateVipPrice(CoreHotel hotel, int adults, int children);

    /// <summary>
    /// Checks if the group meets the minimum requirement for the hotel
    /// </summary>
    /// <param name="hotel">The hotel to check</param>
    /// <param name="totalPeople">Total number of people (adults + children)</param>
    /// <returns>True if meets minimum requirement</returns>
    bool MeetsMinimumRequirement(CoreHotel hotel, int totalPeople);

    /// <summary>
    /// Gets the pricing description message for a hotel in the specified language
    /// </summary>
    /// <param name="hotel">The hotel</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>Formatted pricing description</returns>
    string GetPricingDescription(CoreHotel hotel, int languageId);

    /// <summary>
    /// Gets the minimum people required for a hotel based on its route
    /// </summary>
    /// <param name="hotel">The hotel</param>
    /// <returns>Minimum number of people required</returns>
    int GetMinimumPeople(CoreHotel hotel);

    /// <summary>
    /// Gets the base price for a hotel's VIP service
    /// </summary>
    /// <param name="hotel">The hotel</param>
    /// <returns>Base price in USD</returns>
    decimal GetBasePrice(CoreHotel hotel);

    /// <summary>
    /// Gets the additional person price for a hotel's VIP service
    /// </summary>
    /// <param name="hotel">The hotel</param>
    /// <returns>Additional person price in USD</returns>
    decimal GetAdditionalPersonPrice(CoreHotel hotel);
}