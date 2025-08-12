using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.State.StateNodes;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

[TestFixture]
public class ZoneSelectionStateTests : BaseStateTest
{
    private ZoneSelectionState _zoneSelectionState = null!;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        _zoneSelectionState = new ZoneSelectionState();
    }

    [Test]
    [TestCase("1")]
    [TestCase("2")]
    [TestCase("5")]
    public async Task Process_WithValidZoneId_ShouldSetZoneIdAndTransitionToHotelSelection(string zoneId)
    {
        // Arrange
        var context = CreateTestConversationState();
        var hotels = new List<CoreHotel> { CreateTestHotel() };
        
        MockHotelRepository.Setup(hr => hr.GetHotelsByRouteIdAsync(int.Parse(zoneId)))
            .ReturnsAsync(hotels);

        // Act
        var result = await _zoneSelectionState.Process(context, zoneId);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.ZoneId, Is.EqualTo(zoneId));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.HotelSelection));
        MockMessageCreator.Verify(mc => mc.CreateHotelSelectionMessage(
            context.UserNumber, hotels, 1), Times.Once);
    }

    [Test]
    public async Task Process_WithIDontKnowOption_ShouldTransitionToZoneUnknown()
    {
        // Arrange
        var context = CreateTestConversationState();
        var userMessage = "99"; // I don't know option

        // Act
        var result = await _zoneSelectionState.Process(context, userMessage);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ZoneUnknown));
        MockMessageCreator.Verify(mc => mc.CreateUnknownHotelMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("0")]
    [TestCase("-1")]
    [TestCase("invalid")]
    [TestCase("")]
    public async Task Process_WithInvalidZoneId_ShouldAskForZoneSelectionAgain(string invalidZoneId)
    {
        // Arrange
        var context = CreateTestConversationState();
        var routes = new List<CoreRoute> { CreateTestRoute() };
        
        MockRouteRepository.Setup(rr => rr.GetAllRoutesAsync())
            .ReturnsAsync(routes);

        // Act
        var result = await _zoneSelectionState.Process(context, invalidZoneId);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ZoneSelection)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateSelectHotelZoneLocationMessage(
            context.UserNumber, routes, 1), Times.Once);
    }

    [Test]
    public void StateId_ShouldBeZoneSelection()
    {
        // Assert
        Assert.That(_zoneSelectionState.StateId, Is.EqualTo(ConversationStep.ZoneSelection));
    }
}
