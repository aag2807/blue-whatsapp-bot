using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.State.StateNodes;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

[TestFixture]
public class DateSelectionStateTests : BaseStateTest
{
    private DateSelectionState _dateSelectionState = null!;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        _dateSelectionState = new DateSelectionState();
    }

    [Test]
    [TestCase("15 de Agosto")]
    [TestCase("15/08/2025")]
    [TestCase("15-08-2025")]
    [TestCase("2025-08-15")]
    public async Task Process_WithValidDate_ShouldSetPickUpDateAndTransitionToZoneSelection(string dateInput)
    {
        // Arrange
        var context = CreateTestConversationState();
        var routes = new List<CoreRoute> { CreateTestRoute() };
        
        MockRouteRepository.Setup(rr => rr.GetAllRoutesAsync())
            .ReturnsAsync(routes);

        // Act
        var result = await _dateSelectionState.Process(context, dateInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.PickUpDate, Is.Not.Null.And.Not.Empty);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ZoneSelection));
        MockMessageCreator.Verify(mc => mc.CreateSelectHotelZoneLocationMessage(
            context.UserNumber, routes, 1), Times.Once);
    }

    [Test]
    [TestCase("invalid date")]
    [TestCase("")]
    [TestCase("abc")]
    [TestCase("32/13/2025")]
    public async Task Process_WithInvalidDate_ShouldAskForDateAgain(string dateInput)
    {
        // Arrange
        var context = CreateTestConversationState();
        
        // Act
        var result = await _dateSelectionState.Process(context, dateInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.DateSelection)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateDatePromptMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    public void StateId_ShouldBeDateSelection()
    {
        // Assert
        Assert.That(_dateSelectionState.StateId, Is.EqualTo(ConversationStep.DateSelection));
    }
}
