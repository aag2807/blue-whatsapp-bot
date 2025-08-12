using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Services;
using BlueWhatsapp.Test.StateTests;
using Moq;

namespace BlueWhatsapp.Test.IntegrationTests;

[TestFixture]
public class ConversationFlowIntegrationTests : BaseStateTest
{
    private IConversationHandlingService _conversationHandlingService = null!;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        _conversationHandlingService = new ConversationHandlingService(MockServiceProvider.Object, Mock.Of<Core.Logger.IAppLogger>());
    }

    [Test]
    public async Task CompleteFlow_FreeService_ShouldCompleteSuccessfully()
    {
        // Arrange
        var context = CreateTestConversationState();
        var hotel = CreateTestHotel(1, "Free Hotel", 0, 1);
        var route = CreateTestRoute(1, "Free Route");
        var schedule = CreateTestSchedule(1, "09:00");

        SetupMocksForFreeServiceFlow(hotel, route, schedule);

        // Act & Assert - Step by step flow
        
        // 1. Welcome -> Language Selection
        context.CurrentStep = ConversationStep.Welcome;
        var result1 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.LanguageSelection));

        // 2. Language Selection -> Date Selection
        context.CurrentStep = ConversationStep.LanguageSelection;
        var result2 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "1"); // Spanish
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.DateSelection));
        Assert.That(context.LanguageId, Is.EqualTo("1"));

        // 3. Date Selection -> Zone Selection
        context.CurrentStep = ConversationStep.DateSelection;
        var result3 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "15 de Agosto");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ZoneSelection));
        Assert.That(context.PickUpDate, Is.Not.Empty);

        // 4. Zone Selection -> Hotel Selection
        context.CurrentStep = ConversationStep.ZoneSelection;
        var result4 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "1");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.HotelSelection));
        Assert.That(context.ZoneId, Is.EqualTo("1"));

        // 5. Hotel Selection -> Schedule Selection (Free Service)
        context.CurrentStep = ConversationStep.HotelSelection;
        var result5 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "1");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ScheduleSelection));
        Assert.That(context.HotelId, Is.EqualTo("1"));

        // 6. Schedule Selection -> Ask for Full Name
        context.CurrentStep = ConversationStep.ScheduleSelection;
        var result6 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "1");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForFullName));
        Assert.That(context.ScheduleId, Is.EqualTo("1"));

        // 7. Ask for Full Name -> Ask for Room Number
        context.CurrentStep = ConversationStep.AskForFullName;
        var result7 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForRoomNumber));

        // 8. Ask for Room Number -> Ask for Adults
        context.CurrentStep = ConversationStep.AskForRoomNumber;
        var result8 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "John Doe");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForAdults));
        Assert.That(context.FullName, Is.EqualTo("John Doe"));

        // 9. Ask for Adults -> Ask for Children
        context.CurrentStep = ConversationStep.AskForAdults;
        var result9 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "101");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForChildren));
        Assert.That(context.RoomNumber, Is.EqualTo("101"));

        // 10. Ask for Children -> Ask for Email (skipping phone step)
        context.CurrentStep = ConversationStep.AskForChildren;
        var result10 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "2");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForEmail));
        Assert.That(context.Adults, Is.EqualTo(2));

        // 11. Ask for Email -> Reservation Complete
        context.CurrentStep = ConversationStep.AskForEmail;
        var result11 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "1");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ReservationComplete));
        Assert.That(context.Children, Is.EqualTo(1));

        // 12. Reservation Complete -> Finish
        context.CurrentStep = ConversationStep.ReservationComplete;
        var result12 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "john@example.com");
        Assert.That(context.IsComplete, Is.True);
        Assert.That(context.Email, Is.EqualTo("john@example.com"));
    }

    [Test]
    public async Task CompleteFlow_VipService_ShouldCompleteSuccessfully()
    {
        // Arrange
        var context = CreateTestConversationState();
        var hotel = CreateTestHotel(1, "VIP Hotel", 20, 4); // Bávaro VIP
        var route = CreateTestRoute(4, "Bávaro Route");
        var schedule = CreateTestSchedule(1, "09:00");

        SetupMocksForVipServiceFlow(hotel, route, schedule);

        // Act & Assert - Key steps for VIP flow
        
        // Navigate to VIP Service Offer
        context.CurrentStep = ConversationStep.HotelSelection;
        context.ZoneId = "4";
        var result1 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "1");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.VipServiceOffer));

        // Accept VIP Service
        context.CurrentStep = ConversationStep.VipServiceConfirmation;
        var result2 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "si");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ScheduleSelection));

        // Continue with normal flow...
        context.CurrentStep = ConversationStep.ScheduleSelection;
        var result3 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "1");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForFullName));
    }

    [Test]
    public async Task CompleteFlow_BayahibeVipService_ShouldIncludeGroupSizeSelection()
    {
        // Arrange
        var context = CreateTestConversationState();
        var bayahibeRoute = new CoreRoute(8, "Bayahibe Route", "Bayahibe route description");
        var hotel = CreateTestHotel(1, "Bayahibe Hotel", 15, 8);
        hotel.RouteNavigation = bayahibeRoute;
        var schedule = CreateTestSchedule(1, "09:00");

        SetupMocksForBayahibeFlow(hotel, bayahibeRoute, schedule);

        // Act & Assert - Bayahibe specific flow
        
        // Navigate to VIP Service Confirmation
        context.CurrentStep = ConversationStep.VipServiceConfirmation;
        context.HotelId = "1";
        var result1 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "si");
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.GroupSizeSelection));

        // Select group size
        context.CurrentStep = ConversationStep.VipGroupSizeSelection;
        var result2 = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "1"); // Small bus
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ScheduleSelection));
        Assert.That(context.ExtraInformation, Is.EqualTo("small_bus"));
    }

    private void SetupMocksForFreeServiceFlow(CoreHotel hotel, CoreRoute route, CoreSchedule schedule)
    {
        var hotels = new List<CoreHotel> { hotel };
        var routes = new List<CoreRoute> { route };
        var schedules = new List<CoreSchedule> { schedule };

        MockRouteRepository.Setup(rr => rr.GetAllRoutesAsync()).ReturnsAsync(routes);
        MockHotelRepository.Setup(hr => hr.GetHotelsByRouteIdAsync(1)).ReturnsAsync(hotels);
        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1)).ReturnsAsync(hotel);
        MockScheduleRepository.Setup(sr => sr.GetSchedulesByHotelId(1)).ReturnsAsync(schedules);
        MockScheduleRepository.Setup(sr => sr.GetScheduleByIdAsync(1)).ReturnsAsync(schedule);
    }

    private void SetupMocksForVipServiceFlow(CoreHotel hotel, CoreRoute route, CoreSchedule schedule)
    {
        var hotels = new List<CoreHotel> { hotel };
        var routes = new List<CoreRoute> { route };
        var schedules = new List<CoreSchedule> { schedule };

        MockRouteRepository.Setup(rr => rr.GetAllRoutesAsync()).ReturnsAsync(routes);
        MockHotelRepository.Setup(hr => hr.GetHotelsByRouteIdAsync(4)).ReturnsAsync(hotels);
        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1)).ReturnsAsync(hotel);
        MockScheduleRepository.Setup(sr => sr.GetSchedulesByHotelId(1)).ReturnsAsync(schedules);
        MockScheduleRepository.Setup(sr => sr.GetScheduleByIdAsync(1)).ReturnsAsync(schedule);
    }

    private void SetupMocksForBayahibeFlow(CoreHotel hotel, CoreRoute route, CoreSchedule schedule)
    {
        var hotels = new List<CoreHotel> { hotel };
        var routes = new List<CoreRoute> { route };
        var schedules = new List<CoreSchedule> { schedule };

        MockRouteRepository.Setup(rr => rr.GetAllRoutesAsync()).ReturnsAsync(routes);
        MockHotelRepository.Setup(hr => hr.GetHotelsByRouteIdAsync(8)).ReturnsAsync(hotels);
        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1)).ReturnsAsync(hotel);
        MockScheduleRepository.Setup(sr => sr.GetSchedulesByHotelId(1)).ReturnsAsync(schedules);
        MockScheduleRepository.Setup(sr => sr.GetScheduleByIdAsync(1)).ReturnsAsync(schedule);
    }
}
