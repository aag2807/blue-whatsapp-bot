using BlueWhatsapp.Core.State.StateNodes;

namespace BlueWhatsapp.Api.Extensions;

public static class StateMachineExtensions
{
    internal static void ConfigureStateMachineNodes(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<AskForAdultsState>();
        builder.Services.AddTransient<AskForChildrenState>();
        builder.Services.AddTransient<AskForEmailState>();
        builder.Services.AddTransient<AskForFullNameState>();
        builder.Services.AddTransient<AskForPhoneState>();
        builder.Services.AddTransient<AskForRoomNumberState>();
        builder.Services.AddTransient<DateSelectionState>();
        builder.Services.AddTransient<HotelConfirmationState>();
        builder.Services.AddTransient<HotelSelectionState>();
        builder.Services.AddTransient<HotelUnknownState>();
        builder.Services.AddTransient<LanguageSelectionState>();
        builder.Services.AddTransient<ManualHandlingState>();
        builder.Services.AddTransient<PendingDecisionState>();
        builder.Services.AddTransient<ReservationCompleteState>();
        builder.Services.AddTransient<ScheduleSelectionState>();
        builder.Services.AddTransient<VipGroupSizeSelectionState>();
        builder.Services.AddTransient<VipServiceConfirmationState>();
        builder.Services.AddTransient<VipServiceOfferState>();
        builder.Services.AddTransient<WelcomeState>();
        builder.Services.AddTransient<WillTextLaterState>();
        builder.Services.AddTransient<ZoneSelectionState>();
        builder.Services.AddTransient<ZoneUnknownState>();
    }
}