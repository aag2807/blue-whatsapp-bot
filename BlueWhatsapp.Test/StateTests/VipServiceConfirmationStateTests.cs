using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.State.StateNodes;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

[TestFixture]
public class VipServiceConfirmationStateTests : BaseStateTest
{
    private VipServiceConfirmationState _vipServiceConfirmationState = null!;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        _vipServiceConfirmationState = new VipServiceConfirmationState();

        // Setup additional mock for group size selection
        MockMessageCreator.Setup(mc => mc.CreateGroupSizeSelectionMessage(It.IsAny<string>(), It.IsAny<int>()))
            .Returns(new CoreInteractiveMessage("123456789"));
    }

    [Test]
    [TestCase("1")]
    [TestCase("si")]
    [TestCase("yes")]
    [TestCase("oui")]
    [TestCase("да")]
    [TestCase("sim")]
    [TestCase("是")]
    public async Task Process_WithAcceptedVipService_AndNonBayahibeHotel_ShouldTransitionToScheduleSelection(string acceptInput)
    {
        // Arrange
        var context = CreateTestConversationState();
        context.HotelId = "1";
        var hotel = CreateTestHotel(1, "Standard VIP Hotel", 20, 4); // Bávaro route
        var schedules = new List<CoreSchedule> { CreateTestSchedule() };
        
        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1))
            .ReturnsAsync(hotel);
        MockScheduleRepository.Setup(sr => sr.GetSchedulesByHotelId(1))
            .ReturnsAsync(schedules);

        // Act
        var result = await _vipServiceConfirmationState.Process(context, acceptInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ScheduleSelection));
        MockMessageCreator.Verify(mc => mc.CreateTimeFrameSelectionMessage(
            context.UserNumber, hotel, schedules, 1), Times.Once);
    }

    [Test]
    [TestCase("1")]
    [TestCase("si")]
    [TestCase("yes")]
    public async Task Process_WithAcceptedVipService_AndBayahibeHotel_ShouldTransitionToGroupSizeSelection(string acceptInput)
    {
        // Arrange
        var context = CreateTestConversationState();
        context.HotelId = "1";
        var bayahibeRoute = new CoreRoute(8, "Bayahibe Route", "Bayahibe route description");
        var hotel = CreateTestHotel(1, "Bayahibe Hotel", 15, 8);
        hotel.RouteNavigation = bayahibeRoute;
        
        MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1))
            .ReturnsAsync(hotel);

        // Act
        var result = await _vipServiceConfirmationState.Process(context, acceptInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.GroupSizeSelection));
        MockMessageCreator.Verify(mc => mc.CreateGroupSizeSelectionMessage(
            context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("2")]
    [TestCase("no")]
    [TestCase("later")]
    [TestCase("analizar")]
    [TestCase("maybe")]
    public async Task Process_WithDeclinedVipService_ShouldTransitionToWillTextLater(string declineInput)
    {
        // Arrange
        var context = CreateTestConversationState();
        context.HotelId = "1";

        // Act
        var result = await _vipServiceConfirmationState.Process(context, declineInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.WillTextLater));
        Assert.That(context.IsComplete, Is.True);
        MockMessageCreator.Verify(mc => mc.CreateWillTextLaterMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    public void StateId_ShouldBeVipServiceConfirmation()
    {
        // Assert
        Assert.That(_vipServiceConfirmationState.StateId, Is.EqualTo(ConversationStep.VipServiceConfirmation));
    }
}
