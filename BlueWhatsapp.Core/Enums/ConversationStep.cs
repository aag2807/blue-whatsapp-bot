namespace BlueWhatsapp.Core.Enums;

public enum ConversationStep
{
    /// <summary>
    /// Represents the initial state of a conversation where no step has been initiated or defined.
    /// </summary>
    None = 0,
    // Initial states
    Welcome,
    LanguageSelection,
    ClientTypeSelection, // not used right now
    
    // Date selection
    DateSelection,
    
    // Location/hotel selection
    ZoneSelection,
    ZoneUnknown,
    HotelSelection,
    HotelUnknown,
    HotelConfirmation,
    
    // Schedule selection
    ScheduleSelection,
    WillTextLater,
    
    //ask for user information,
    AskForReservationDetails,
    
    // Completion states
    ReservationComplete,
    PendingDecision,
    
    // Admin override state 
    ManualHandling,
}