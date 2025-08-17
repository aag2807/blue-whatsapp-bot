using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;

namespace BlueWhatsapp.Core.Utils;

public interface IMessageCreator
{
    /// <summary>
    /// Creates a welcome message (always in Spanish since language not selected yet)
    /// </summary>
    /// <param name="number">The destination phone number</param>
    /// <returns>A welcome message</returns>
    CoreMessageToSend CreateWelcomeMessage(string number);

    /// <summary>
    /// Creates a date prompt message in the specified language
    /// </summary>
    /// <param name="number">The destination phone number</param>
    /// <param name="languageId">Language ID (1=Spanish, 2=English, etc.)</param>
    /// <returns>A date prompt message</returns>
    CoreMessageToSend CreateDatePromptMessage(string number, int languageId = 1);

    /// <summary>
    /// Creates a language prompt message (multilingual by design)
    /// </summary>
    /// <param name="number">The destination phone number</param>
    /// <returns>A multilingual language selection message</returns>
    CoreInteractiveMessage CreateLanguagePromptMessage(string number);

    /// <summary>
    /// Creates a hotel zone selection message in the specified language
    /// </summary>
    /// <param name="number">The destination phone number</param>
    /// <param name="routes">Available routes/zones</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>A zone selection message</returns>
    CoreInteractiveMessage CreateSelectHotelZoneLocationMessage(string number, IEnumerable<CoreRoute> routes, int languageId = 1);

    /// <summary>
    /// Creates a hotel selection message in the specified language
    /// </summary>
    /// <param name="number">The destination phone number</param>
    /// <param name="hotels">Available hotels</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>A hotel selection message</returns>
    CoreInteractiveMessage CreateHotelSelectionMessage(string number, IEnumerable<CoreHotel> hotels, int languageId = 1);

    /// <summary>
    /// Creates a time frame selection message in the specified language
    /// </summary>
    /// <param name="number">The destination phone number</param>
    /// <param name="hotel">Selected hotel</param>
    /// <param name="schedules">Available schedules</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>A time frame selection message</returns>
    CoreInteractiveMessage CreateTimeFrameSelectionMessage(string number, CoreHotel hotel, IEnumerable<CoreSchedule> schedules, int languageId = 1);

    /// <summary>
    /// Creates a reservation details request message in the specified language
    /// </summary>
    /// <param name="userNumber">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>A reservation details request message</returns>
    CoreMessageToSend CreateAskForReservationDetailsMessage(string userNumber, int languageId = 1);

    /// <summary>
    /// Creates an unknown hotel message in the specified language
    /// </summary>
    /// <param name="number">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>An unknown hotel message</returns>
    CoreMessageToSend CreateUnknownHotelMessage(string number, int languageId = 1);

    /// <summary>
    /// Creates a no matching hotel message in the specified language
    /// </summary>
    /// <param name="number">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>A no matching hotel message</returns>
    CoreMessageToSend CreateNoMatchingHotelMessage(string number, int languageId = 1);

    /// <summary>
    /// Creates a reservation confirmation message in the specified language
    /// </summary>
    /// <param name="userNumber">The destination phone number</param>
    /// <param name="hotel">Reserved hotel</param>
    /// <param name="schedule">Reserved schedule</param>
    /// <param name="date">Reservation date</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>A reservation confirmation message</returns>
    CoreMessageToSend CreateReservationConfirmationMessage(string userNumber, CoreHotel hotel, CoreSchedule schedule, string date, int languageId = 1);

    /// <summary>
    /// Creates an asking for name message in the specified language
    /// </summary>
    /// <param name="userNumber">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>An asking for name message</returns>
    CoreMessageToSend CreateAskingForNameMessage(string userNumber, int languageId = 1);

    /// <summary>
    /// Creates an ask for room number message in the specified language
    /// </summary>
    /// <param name="userNumber">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>An ask for room number message</returns>
    CoreMessageToSend CreateAskForRoomNumberMessage(string userNumber, int languageId = 1);

    /// <summary>
    /// Creates an ask for adults count message in the specified language
    /// </summary>
    /// <param name="userNumber">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>An ask for adults count message</returns>
    CoreInteractiveMessage CreateAskForAdultsCountMessage(string userNumber, int languageId = 1);

    /// <summary>
    /// Creates an ask for children count message in the specified language
    /// </summary>
    /// <param name="userNumber">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>An ask for children count message</returns>
    CoreInteractiveMessage CreateAskForChildrenCountMessage(string userNumber, int languageId = 1);

    /// <summary>
    /// Creates an ask for phone number message in the specified language
    /// </summary>
    /// <param name="userNumber">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>An ask for phone number message</returns>
    CoreMessageToSend CreateAskForPhoneMessage(string userNumber, int languageId = 1);

    /// <summary>
    /// Creates an asking for email message in the specified language
    /// </summary>
    /// <param name="userNumber">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>An asking for email message</returns>
    CoreMessageToSend CreateAskingEmailMessage(string userNumber, int languageId = 1);

    /// <summary>
    /// Creates a trip full message in the specified language
    /// </summary>
    /// <param name="userNumber">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>A trip full message</returns>
    CoreMessageToSend CreateTripFullMessage(string userNumber, int languageId = 1);

    /// <summary>
    /// Creates a "will text later" message in the specified language
    /// </summary>
    /// <param name="userNumber">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>A "will text later" message</returns>
    CoreMessageToSend CreateWillTextLaterMessage(string userNumber, int languageId = 1);
    
    /// <summary>
    /// Creates a VIP service offer message in the specified language
    /// </summary>
    /// <param name="number">The destination phone number</param>
    /// <param name="hotel">The hotel for VIP service</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>A VIP service offer message</returns>
    CoreInteractiveMessage CreateVipServiceOfferMessage(string number, CoreHotel hotel, int languageId = 1);

    /// <summary>
    /// Creates a group size selection message for Bayahibe in the specified language
    /// </summary>
    /// <param name="number">The destination phone number</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>A group size selection message</returns>
    CoreInteractiveMessage CreateGroupSizeSelectionMessage(string number, int languageId = 1);

    /// <summary>
    /// Creates a multiple hotel match message in the specified language
    /// </summary>
    /// <param name="number">The destination phone number</param>
    /// <param name="hotels">Matched hotels</param>
    /// <param name="languageId">Language ID</param>
    /// <returns>A multiple hotel match message</returns>
    CoreInteractiveMessage CreateMultipleHotelMatchMessage(string number, IEnumerable<CoreHotel> hotels, int languageId = 1);
}