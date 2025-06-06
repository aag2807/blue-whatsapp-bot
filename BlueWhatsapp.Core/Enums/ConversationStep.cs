namespace BlueWhatsapp.Core.Enums;

public enum ConversationStep
{
    None = 0,

    // Initial states
    Welcome = 1,
    LanguageSelection = 2,

    // Date selection
    DateSelection = 3,

    // Location/hotel selection
    ZoneSelection = 4, //
    ZoneUnknown = 5,
    HotelSelection = 6,
    HotelUnknown = 7,
    HotelConfirmation = 8,
    ZoneSelectionResponse,
    
    // hotel name search selection
    MoreThanOneMatchingHotel,
    IsThisMatchingHotel,
    NoMatchingHotel,

    // Schedule and service type
    ScheduleSelection = 9,
    WillTextLater = 10,
    VipServiceOffer = 11,
    VipServiceConfirmation = 12,
    VipGroupSizeSelection = 13,

    // User information collection
    AskForFullName = 14,
    AskForRoomNumber = 15,
    AskForAdults = 16,
    AskForChildren = 17,
    AskForPhone = 18,
    AskForEmail = 19,

    // Conversation ending states
    ReservationComplete = 20,
    PendingDecision = 21,

    // Admin override state 
    ManualHandling = 99,
}