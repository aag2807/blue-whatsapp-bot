using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Services;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

/// <summary>
/// Base class for state tests with common mocks and test data
/// </summary>
public abstract class BaseStateTest
{
    protected Mock<IMessageCreator> MockMessageCreator { get; private set; } = null!;
    protected Mock<IHotelRepository> MockHotelRepository { get; private set; } = null!;
    protected Mock<IRouteRepository> MockRouteRepository { get; private set; } = null!;
    protected Mock<IScheduleRepository> MockScheduleRepository { get; private set; } = null!;
    protected Mock<IReservationRepository> MockReservationRepository { get; private set; } = null!;
    protected Mock<IServiceProvider> MockServiceProvider { get; private set; } = null!;
    protected TestServiceProvider TestServiceProvider { get; private set; } = null!;
    protected Mock<IServiceScopeFactory> MockServiceScopeFactory { get; private set; } = null!;
    protected Mock<IServiceScope> MockServiceScope { get; private set; } = null!;

    [SetUp]
    public virtual void SetUp()
    {
        MockMessageCreator = new Mock<IMessageCreator>();
        MockHotelRepository = new Mock<IHotelRepository>();
        MockRouteRepository = new Mock<IRouteRepository>();
        MockScheduleRepository = new Mock<IScheduleRepository>();
        MockReservationRepository = new Mock<IReservationRepository>();
        MockServiceProvider = new Mock<IServiceProvider>();
        MockServiceScopeFactory = new Mock<IServiceScopeFactory>();
        MockServiceScope = new Mock<IServiceScope>();

        TestServiceProvider = new TestServiceProvider(
            MockHotelRepository.Object,
            MockRouteRepository.Object,
            MockScheduleRepository.Object,
            MockReservationRepository.Object,
            MockMessageCreator.Object);

        SetupMockServiceProvider();
        SetupMockServiceScopeFactory();
        SetupDefaultMockBehaviors();
        InitializeServiceLocator();
    }

    private void SetupMockServiceProvider()
    {
        MockServiceProvider.Setup(sp => sp.GetService(typeof(IHotelRepository)))
            .Returns(MockHotelRepository.Object);
        MockServiceProvider.Setup(sp => sp.GetService(typeof(IRouteRepository)))
            .Returns(MockRouteRepository.Object);
        MockServiceProvider.Setup(sp => sp.GetService(typeof(IScheduleRepository)))
            .Returns(MockScheduleRepository.Object);
        MockServiceProvider.Setup(sp => sp.GetService(typeof(IReservationRepository)))
            .Returns(MockReservationRepository.Object);
        MockServiceProvider.Setup(sp => sp.GetService(typeof(IMessageCreator)))
            .Returns(MockMessageCreator.Object);


    }

    private void SetupMockServiceScopeFactory()
    {
        MockServiceScope.Setup(s => s.ServiceProvider)
            .Returns(TestServiceProvider);
        MockServiceScopeFactory.Setup(f => f.CreateScope())
            .Returns(MockServiceScope.Object);
    }

    private void InitializeServiceLocator()
    {
        var mockLogger = new Mock<IAppLogger>();
        ServiceLocator.Initialize(MockServiceScopeFactory.Object, mockLogger.Object);
    }

    private void SetupDefaultMockBehaviors()
    {
        // Default message creator responses
        MockMessageCreator.Setup(mc => mc.CreateWelcomeMessage(It.IsAny<string>()))
            .Returns(new CoreMessageToSend("Welcome message", "123456789"));

        MockMessageCreator.Setup(mc => mc.CreateLanguagePromptMessage(It.IsAny<string>()))
            .Returns(new CoreInteractiveMessage("123456789"));

        MockMessageCreator.Setup(mc => mc.CreateDatePromptMessage(It.IsAny<string>(), It.IsAny<int>()))
            .Returns(new CoreMessageToSend("Date selection", "123456789"));

        MockMessageCreator.Setup(mc => mc.CreateSelectHotelZoneLocationMessage(It.IsAny<string>(), It.IsAny<IEnumerable<CoreRoute>>(), It.IsAny<int>()))
            .Returns(new CoreInteractiveMessage("123456789"));

        MockMessageCreator.Setup(mc => mc.CreateHotelSelectionMessage(It.IsAny<string>(), It.IsAny<IEnumerable<CoreHotel>>(), It.IsAny<int>()))
            .Returns(new CoreInteractiveMessage("123456789"));

        MockMessageCreator.Setup(mc => mc.CreateTimeFrameSelectionMessage(It.IsAny<string>(), It.IsAny<CoreHotel>(), It.IsAny<IEnumerable<CoreSchedule>>(), It.IsAny<int>()))
            .Returns(new CoreInteractiveMessage("123456789"));

        MockMessageCreator.Setup(mc => mc.CreateUnknownHotelMessage(It.IsAny<string>(), It.IsAny<int>()))
            .Returns(new CoreMessageToSend("Unknown hotel", "123456789"));

        MockMessageCreator.Setup(mc => mc.CreateVipServiceOfferMessage(It.IsAny<string>(), It.IsAny<CoreHotel>(), It.IsAny<int>()))
            .Returns(new CoreInteractiveMessage("123456789"));

        MockMessageCreator.Setup(mc => mc.CreateWillTextLaterMessage(It.IsAny<string>(), It.IsAny<int>()))
            .Returns(new CoreMessageToSend("Will text later", "123456789"));

        MockMessageCreator.Setup(mc => mc.CreateAskingForNameMessage(It.IsAny<string>(), It.IsAny<int>()))
            .Returns(new CoreMessageToSend("Ask for name", "123456789"));

        MockMessageCreator.Setup(mc => mc.CreateAskForRoomNumberMessage(It.IsAny<string>(), It.IsAny<int>()))
            .Returns(new CoreMessageToSend("Ask for room", "123456789"));

        MockMessageCreator.Setup(mc => mc.CreateAskForAdultsCountMessage(It.IsAny<string>(), It.IsAny<int>()))
            .Returns(new CoreInteractiveMessage("123456789"));

        MockMessageCreator.Setup(mc => mc.CreateAskForChildrenCountMessage(It.IsAny<string>(), It.IsAny<int>()))
            .Returns(new CoreInteractiveMessage("123456789"));

        MockMessageCreator.Setup(mc => mc.CreateAskingEmailMessage(It.IsAny<string>(), It.IsAny<int>()))
            .Returns(new CoreMessageToSend("Ask for email", "123456789"));

        MockMessageCreator.Setup(mc => mc.CreateReservationConfirmationMessage(It.IsAny<string>(), It.IsAny<CoreHotel>(), It.IsAny<CoreSchedule>(), It.IsAny<string>(), It.IsAny<int>()))
            .Returns(new CoreMessageToSend("Reservation confirmed", "123456789"));

        MockMessageCreator.Setup(mc => mc.CreateMultipleHotelMatchMessage(It.IsAny<string>(), It.IsAny<IEnumerable<CoreHotel>>(), It.IsAny<int>()))
            .Returns(new CoreInteractiveMessage("123456789"));
    }

    protected CoreConversationState CreateTestConversationState(string userNumber = "123456789")
    {
        return new CoreConversationState
        {
            Id = 1,
            UserNumber = userNumber,
            CurrentStep = ConversationStep.Welcome,
            LanguageId = "1",
            PersonName = "Test User",
            CreatedTime = DateTime.UtcNow
        };
    }

    protected CoreHotel CreateTestHotel(int id = 1, string name = "Test Hotel", float price = 0, int routeId = 1)
    {
        return new CoreHotel
        {
            Id = id,
            Name = name,
            Price = price,
            RouteId = routeId,
            Route = "Test Route",
            Currency = "USD",
            TravelType = TravelTypeEnum.T1,
            MeetingPoint = MeetingPoint.Lobby
        };
    }

    protected CoreRoute CreateTestRoute(int id = 1, string name = "Test Route")
    {
        return new CoreRoute(id, name, "Test route description");
    }

    protected CoreSchedule CreateTestSchedule(int id = 1, string time = "09:00")
    {
        return new CoreSchedule(id, time, "Test Schedule", 1);
    }
}

/// <summary>
/// Test implementation of IServiceProvider that supports GetRequiredService
/// </summary>
public class TestServiceProvider : IServiceProvider
{
    private readonly Dictionary<Type, object> _services = new();

    public TestServiceProvider(
        IHotelRepository hotelRepository,
        IRouteRepository routeRepository,
        IScheduleRepository scheduleRepository,
        IReservationRepository reservationRepository,
        IMessageCreator messageCreator)
    {
        _services[typeof(IHotelRepository)] = hotelRepository;
        _services[typeof(IRouteRepository)] = routeRepository;
        _services[typeof(IScheduleRepository)] = scheduleRepository;
        _services[typeof(IReservationRepository)] = reservationRepository;
        _services[typeof(IMessageCreator)] = messageCreator;
    }

    public object? GetService(Type serviceType)
    {
        return _services.TryGetValue(serviceType, out var service) ? service : null;
    }
}
