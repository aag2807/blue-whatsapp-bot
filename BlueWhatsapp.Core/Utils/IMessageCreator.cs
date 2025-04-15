using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;

namespace BlueWhatsapp.Core.Utils;

public interface IMessageCreator
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public CoreMessageToSend CreateWelcomeMessage(string number);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public CoreMessageToSend CreateDatePromptMessage(string number);
    
    /// <summary>
    /// Creates a language prompt message for the specified phone number.
    /// </summary>
    /// <param name="number">The destination</param>
    /// <returns>A valid <see cref="CoreInteractiveMessage"/></returns>
    public CoreInteractiveMessage CreateLanguagePromptMessage(string number);

    /// <summary>
    /// Creates a language prompt message for the specified phone number.
    /// </summary>
    /// <param name="number">The destination</param>
    /// <returns>A valid <see cref="CoreInteractiveMessage"/></returns>
    public CoreInteractiveMessage CreateSelectHotelZoneLocationMessage(string number);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <param name="hotels"></param>
    /// <returns></returns>
    public CoreInteractiveMessage CreateHotelSelectionMessage(string number, IEnumerable<CoreHotel> hotels);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <param name="hotel"></param>
    /// <param name="schedules"></param>
    /// <returns></returns>
    public CoreInteractiveMessage CreateTimeFrameSelectionMessage(string number, CoreHotel hotel, IEnumerable<CoreSchedule> schedules);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="userNumber"></param>
    /// <returns></returns>
    public CoreMessageToSend CreateAskForReservationDetailsMessage(string userNumber);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="userNumber"></param>
    /// <param name="hotel"></param>
    /// <param name="schedule"></param>
    /// <param name="date"></param>
    /// <returns></returns>
    public CoreMessageToSend CreateReservationConfirmationMessage(string userNumber, CoreHotel hotel, CoreSchedule schedule, string date);
}