using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Services;
using BlueWhatsapp.Test.StateTests;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace BlueWhatsapp.Test.ServiceTests;

[TestFixture]
public class ConversationHandlingServiceTests : BaseStateTest
{
    private ConversationHandlingService _conversationHandlingService = null!;
    private Mock<IAppLogger> _mockLogger = null!;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        _mockLogger = new Mock<IAppLogger>();
        _conversationHandlingService = new ConversationHandlingService(MockServiceProvider.Object, _mockLogger.Object);
    }

    [Test]
    public async Task HandleState_WithNoneStep_ShouldResetToWelcome()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.None;

        // Act
        var result = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "");

        // Assert
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.LanguageSelection)); // Welcome transitions to LanguageSelection
        Assert.That(result, Is.Not.Null);
    }

    [Test]
    public async Task HandleState_WithValidStep_ShouldProcessCorrectly()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.Welcome;

        // Act
        var result = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.LanguageSelection));
    }

    [Test]
    public async Task HandleState_WithStateTransition_ShouldContinueProcessing()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.AskForFullName;
        
        // Act
        var result = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "");

        // Assert
        // AskForFullName should transition to AskForRoomNumber and return a message
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForRoomNumber));
    }

    [Test]
    public async Task HandleState_WithInvalidStep_ShouldHandleGracefully()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = (ConversationStep)999; // Invalid step

        // Act
        var result = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "test");

        // Assert
        // Should default to Welcome state
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.LanguageSelection));
        _mockLogger.Verify(l => l.LogError(It.IsAny<string>()), Times.AtLeastOnce);
    }

    [Test]
    [TestCase(ConversationStep.Welcome, "")]
    [TestCase(ConversationStep.LanguageSelection, "1")]
    [TestCase(ConversationStep.DateSelection, "2025-01-15")]
    [TestCase(ConversationStep.ZoneSelection, "1")]
    [TestCase(ConversationStep.HotelSelection, "1")]
    public async Task HandleState_WithDifferentSteps_ShouldProcessCorrectly(ConversationStep step, string validInput)
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = step;
        if (step == ConversationStep.ZoneSelection || step == ConversationStep.HotelSelection)
        {
            context.ZoneId = "1"; // Set required ZoneId for hotel selection
        }
        if (step == ConversationStep.HotelSelection)
        {
            // Set up hotel repository to return a hotel for transition
            var testHotel = CreateTestHotel(1, "Test Hotel", 0);
            MockHotelRepository.Setup(hr => hr.GetHotelByIdAsync(1))
                .ReturnsAsync(testHotel);
            MockScheduleRepository.Setup(sr => sr.GetSchedulesByHotelId(1))
                .ReturnsAsync(new List<CoreSchedule> { CreateTestSchedule() });
        }

        // Act
        var result = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, validInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        // Each state should transition to the next appropriate state
        Assert.That(context.CurrentStep, Is.Not.EqualTo(step)); // Should have transitioned
    }

    [Test]
    public async Task HandleState_WithEmptyUserMessage_ShouldStillProcess()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.Welcome;

        // Act
        var result = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "");

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.LanguageSelection));
    }

    [Test]
    public async Task HandleState_ShouldLogProcessingSteps()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.Welcome;

        // Act
        await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "test");

        // Assert
        _mockLogger.Verify(l => l.LogInfo(It.Is<string>(s => s.Contains("HandleState"))), Times.Once);
    }
}
