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
    ClientTypeSelection,
    
    // Date selection
    DateSelection,
    
    // Location/hotel selection
    ZoneSelection,
    HotelSelection,
    
    // Service type states
    FreeRouteInfo,
    VipServiceOffer,
    VipServiceConfirmation,
    GroupSizeSelection,
    
    // Schedule selection
    TimeSelection,
    
    // Personal information collection
    CollectFullName,
    CollectRoomNumber,
    CollectAdultsCount,
    CollectChildrenCount,
    CollectPhoneNumber,
    CollectEmail,
    
    // Referrer-specific states
    ReferrerCodeInput,
    NewReferrerRegistration,
    ReferrerPhotoUpload,
    ReferrerCompanyInfo,
    ReferrerPersonalInfo,
    ReferrerPaymentTypeSelection,
    ReferrerBankInfo,
    
    // Completion states
    ReservationComplete,
    PendingDecision,
    
    // Admin override state 
    ManualHandling,
}