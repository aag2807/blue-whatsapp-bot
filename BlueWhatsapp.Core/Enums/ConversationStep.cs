namespace BlueWhatsapp.Core.Enums;

public enum ConversationStep
{
    /// <summary>
    /// Represents the initial state of a conversation where no step has been initiated or defined.
    /// </summary>
    None = 0,
    // Initial states
    Welcome = 1,
    LanguageSelection = 2,
    ClientTypeSelection = 3, // not used right now

    // Date selection
    DateSelection = 4,

    // Location/hotel selection
    ZoneSelection = 5,
    ZoneUnknown = 6,
    HotelSelection = 7,
    HotelUnknown = 8,
    HotelConfirmation = 9,

    // Schedule selection
    ScheduleSelection = 10,
    WillTextLater = 11,

    //ask for user information,
    AskForFullName = 12,
    AskForRoomNumber = 13,
    AskForAdults = 14,
    AskForChildren = 15,
    AskForEmail = 16,

    // Conversation ending states
    ReservationComplete = 17,
    PendingDecision = 18,

    // Admin override state 
    ManualHandling = 99,
}