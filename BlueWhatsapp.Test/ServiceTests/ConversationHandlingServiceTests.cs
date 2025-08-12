using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
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
    [TestCase(ConversationStep.Welcome)]
    [TestCase(ConversationStep.LanguageSelection)]
    [TestCase(ConversationStep.DateSelection)]
    [TestCase(ConversationStep.ZoneSelection)]
    [TestCase(ConversationStep.HotelSelection)]
    public async Task HandleState_WithDifferentSteps_ShouldProcessCorrectly(ConversationStep step)
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = step;

        // Act
        var result = await ((IConversationHandlingService)_conversationHandlingService).HandleState(context, "1");

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
