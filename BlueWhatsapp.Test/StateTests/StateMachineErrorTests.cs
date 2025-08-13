using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.State;
using BlueWhatsapp.Core.State.StateNodes;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

[TestFixture]
public class StateMachineErrorTests : BaseStateTest
{
    private Mock<IAppLogger> _mockLogger;
    private ConversationStateMachine _stateMachine;

    [SetUp]
    public void Setup()
    {
        _mockLogger = new Mock<IAppLogger>();
        
        // Create state machine with test states
        var states = new IConversationState[]
        {
            new WelcomeState(),
            new LanguageSelectionState(),
            new DateSelectionState(),
            new ZoneSelectionState()
        };
        
        _stateMachine = new ConversationStateMachine(_mockLogger.Object, states);
    }

    #region Unknown State Handling

    [Test]
    public async Task StateMachine_WithUnknownState_ShouldLogErrorAndDefaultToWelcome()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = (ConversationStep)999; // Unknown state

        // Act
        var result = await _stateMachine.ProcessMessage(context, "test message");

        // Assert
        _mockLogger.Verify(l => l.LogError(It.Is<string>(s => s.Contains("No handler found for state: 999"))), Times.Once);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.LanguageSelection)); // Welcome state transitions to LanguageSelection
        Assert.That(result, Is.Not.Null);
    }

    [Test]
    public async Task StateMachine_WithNullContext_ShouldHandleGracefully()
    {
        // Arrange
        CoreConversationState? nullContext = null;

        // Act
        var result = await _stateMachine.ProcessMessage(nullContext!, "test message");

        // Assert
        Assert.That(result, Is.Null); // Should handle gracefully and return null
        _mockLogger.Verify(l => l.LogError(It.Is<string>(s => s.Contains("Error processing message"))), Times.Once);
    }

    [Test]
    public async Task StateMachine_WithNullMessage_ShouldPassToState()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.Welcome;

        // Act
        var result = await _stateMachine.ProcessMessage(context, null!);

        // Assert
        Assert.That(result, Is.Not.Null); // WelcomeState should handle null message
        _mockLogger.Verify(l => l.LogInfo(It.Is<string>(s => s.Contains("Processing message in state: Welcome"))), Times.Once);
    }

    #endregion

    #region State Processing Exceptions

    [Test]
    public async Task StateMachine_WhenStateThrowsException_ShouldLogErrorAndReturnNull()
    {
        // Arrange
        var mockState = new Mock<IConversationState>();
        mockState.Setup(s => s.StateId).Returns(ConversationStep.Welcome);
        mockState.Setup(s => s.Process(It.IsAny<CoreConversationState>(), It.IsAny<string>()))
            .ThrowsAsync(new InvalidOperationException("State processing failed"));

        var stateMachine = new ConversationStateMachine(_mockLogger.Object, mockState.Object);
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.Welcome;

        // Act
        var result = await stateMachine.ProcessMessage(context, "test");

        // Assert
        Assert.That(result, Is.Null);
        _mockLogger.Verify(l => l.LogError(It.Is<string>(s => s.Contains("Error processing message"))), Times.Once);
        _mockLogger.Verify(l => l.LogError(It.IsAny<Exception>()), Times.Once);
    }

    [Test]
    public async Task StateMachine_WhenStateReturnsNull_ShouldReturnNull()
    {
        // Arrange
        var mockState = new Mock<IConversationState>();
        mockState.Setup(s => s.StateId).Returns(ConversationStep.Welcome);
        mockState.Setup(s => s.Process(It.IsAny<CoreConversationState>(), It.IsAny<string>()))
            .ReturnsAsync((CoreBaseMessage?)null);

        var stateMachine = new ConversationStateMachine(_mockLogger.Object, mockState.Object);
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.Welcome;

        // Act
        var result = await stateMachine.ProcessMessage(context, "test");

        // Assert
        Assert.That(result, Is.Null);
        _mockLogger.Verify(l => l.LogInfo(It.Is<string>(s => s.Contains("Processing message in state: Welcome"))), Times.Once);
    }

    #endregion

    #region Logging Verification

    [Test]
    public async Task StateMachine_SuccessfulProcessing_ShouldLogInfoMessages()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.LanguageSelection;

        // Act
        var result = await _stateMachine.ProcessMessage(context, "1");

        // Assert
        _mockLogger.Verify(l => l.LogInfo(It.Is<string>(s => s.Contains("Processing message in state: LanguageSelection"))), Times.Once);
        _mockLogger.Verify(l => l.LogInfo(It.Is<string>(s => s.Contains("Transitioned to state:"))), Times.Once);
    }

    [Test]
    public async Task StateMachine_WithStateTransition_ShouldLogTransition()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.LanguageSelection;

        // Act
        var result = await _stateMachine.ProcessMessage(context, "1");

        // Assert
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.DateSelection));
        _mockLogger.Verify(l => l.LogInfo(It.Is<string>(s => s.Contains("Transitioned to state: DateSelection"))), Times.Once);
    }

    #endregion

    #region Edge Case State Combinations

    [Test]
    public async Task StateMachine_WithEmptyStateArray_ShouldHandleUnknownStates()
    {
        // Arrange
        var emptyStateMachine = new ConversationStateMachine(_mockLogger.Object);
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.Welcome;

        // Act
        var result = await emptyStateMachine.ProcessMessage(context, "test");

        // Assert
        _mockLogger.Verify(l => l.LogError(It.Is<string>(s => s.Contains("No handler found for state"))), Times.Once);
    }

    [Test]
    public async Task StateMachine_WithDuplicateStates_ShouldUseLastRegistered()
    {
        // Arrange
        var mockState1 = new Mock<IConversationState>();
        mockState1.Setup(s => s.StateId).Returns(ConversationStep.Welcome);
        mockState1.Setup(s => s.Process(It.IsAny<CoreConversationState>(), It.IsAny<string>()))
            .ReturnsAsync(new CoreMessageToSend("First", "123"));

        var mockState2 = new Mock<IConversationState>();
        mockState2.Setup(s => s.StateId).Returns(ConversationStep.Welcome);
        mockState2.Setup(s => s.Process(It.IsAny<CoreConversationState>(), It.IsAny<string>()))
            .ReturnsAsync(new CoreMessageToSend("Second", "123"));

        var stateMachine = new ConversationStateMachine(_mockLogger.Object, mockState1.Object, mockState2.Object);
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.Welcome;

        // Act
        var result = await stateMachine.ProcessMessage(context, "test");

        // Assert
        Assert.That(result, Is.Not.Null);
        var messageToSend = result as CoreMessageToSend;
        Assert.That(messageToSend?.text?.body, Is.EqualTo("Second")); // Should use the last registered state
    }

    #endregion

    #region Performance and Memory Tests

    [Test]
    public async Task StateMachine_ProcessingManyMessages_ShouldHandleEfficiently()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.Welcome;

        // Act - Process many messages
        var tasks = new List<Task>();
        for (int i = 0; i < 100; i++)
        {
            tasks.Add(_stateMachine.ProcessMessage(context, $"message {i}"));
        }

        await Task.WhenAll(tasks);

        // Assert - Should complete without issues
        Assert.That(tasks.All(t => t.IsCompletedSuccessfully), Is.True);
    }

    [Test]
    public async Task StateMachine_WithLargeMessage_ShouldHandleGracefully()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.Welcome;
        var largeMessage = new string('A', 10000); // 10KB message

        // Act
        var result = await _stateMachine.ProcessMessage(context, largeMessage);

        // Assert
        Assert.That(result, Is.Not.Null);
        _mockLogger.Verify(l => l.LogInfo(It.IsAny<string>()), Times.AtLeast(2));
    }

    #endregion

    #region State Recovery Tests

    [Test]
    public async Task StateMachine_AfterException_ShouldContinueWorking()
    {
        // Arrange
        var context = CreateTestConversationState();
        context.CurrentStep = ConversationStep.Welcome;

        // First, cause an exception by using unknown state
        context.CurrentStep = (ConversationStep)999;
        await _stateMachine.ProcessMessage(context, "test");

        // Reset to valid state
        context.CurrentStep = ConversationStep.Welcome;

        // Act - Should work normally after exception
        var result = await _stateMachine.ProcessMessage(context, "test");

        // Assert
        Assert.That(result, Is.Not.Null);
        _mockLogger.Verify(l => l.LogError(It.IsAny<string>()), Times.Once); // Only from the first call
    }

    #endregion
}
