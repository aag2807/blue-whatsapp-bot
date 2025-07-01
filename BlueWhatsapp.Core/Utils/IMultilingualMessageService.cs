namespace BlueWhatsapp.Core.Utils;

/// <summary>
/// Interface for multilingual message service.
/// This allows for dependency injection if needed, while the static implementation provides direct access.
/// </summary>
public interface IMultilingualMessageService
{
    /// <summary>
    /// Gets the welcome message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID (1=Spanish, 2=English, 3=French, 4=Russian, 5=Portuguese, 6=Mandarin)</param>
    /// <returns>Welcome message text</returns>
    string GetWelcomeMessage(int languageId);

    /// <summary>
    /// Gets the date prompt message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Date prompt message text</returns>
    string GetDatePromptMessage(int languageId);

    /// <summary>
    /// Gets the zone selection message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Zone selection message text</returns>
    string GetZoneSelectionMessage(int languageId);

    /// <summary>
    /// Gets the hotel selection message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Hotel selection message text</returns>
    string GetHotelSelectionMessage(int languageId);

    /// <summary>
    /// Gets the free hotel trip message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="hotelName">Name of the hotel</param>
    /// <returns>Free hotel trip message text</returns>
    string GetFreeHotelTripMessage(int languageId, string hotelName);

    /// <summary>
    /// Gets the VIP hotel trip message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="hotelName">Name of the hotel</param>
    /// <returns>VIP hotel trip message text</returns>
    string GetVipHotelTripMessage(int languageId, string hotelName);

    /// <summary>
    /// Gets the reservation details request message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Reservation details request message text</returns>
    string GetReservationDetailsMessage(int languageId);

    /// <summary>
    /// Gets the unknown hotel message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Unknown hotel message text</returns>
    string GetUnknownHotelMessage(int languageId);

    /// <summary>
    /// Gets the no matching hotel message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>No matching hotel message text</returns>
    string GetNoMatchingHotelMessage(int languageId);

    /// <summary>
    /// Gets the ask for name message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Ask for name message text</returns>
    string GetAskForNameMessage(int languageId);

    /// <summary>
    /// Gets the ask for room number message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Ask for room number message text</returns>
    string GetAskForRoomNumberMessage(int languageId);

    /// <summary>
    /// Gets the ask for adults count message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Ask for adults count message text</returns>
    string GetAskForAdultsCountMessage(int languageId);

    /// <summary>
    /// Gets the ask for children count message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Ask for children count message text</returns>
    string GetAskForChildrenCountMessage(int languageId);

    /// <summary>
    /// Gets the ask for email message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Ask for email message text</returns>
    string GetAskForEmailMessage(int languageId);

    /// <summary>
    /// Gets the reservation confirmation message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="date">Reservation date</param>
    /// <param name="time">Reservation time</param>
    /// <returns>Reservation confirmation message text</returns>
    string GetReservationConfirmationMessage(int languageId, string date, string time);

    /// <summary>
    /// Gets the trip full message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Trip full message text</returns>
    string GetTripFullMessage(int languageId);

    /// <summary>
    /// Gets the "I don't know" option text in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>"I don't know" text</returns>
    string GetIDontKnowText(int languageId);

    /// <summary>
    /// Gets the "Not in the list" option text in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>"Not in the list" text</returns>
    string GetNotInListText(int languageId);

    /// <summary>
    /// Gets the "I'll write later" option text in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>"I'll write later" text</returns>
    string GetWriteLaterText(int languageId);

    /// <summary>
    /// Gets the interactive button labels in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Button labels object</returns>
    InteractiveButtonLabels GetButtonLabels(int languageId);
} 