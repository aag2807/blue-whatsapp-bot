using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.State.StateNodes;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

[TestFixture]
public class LanguageSelectionStateTests : BaseStateTest
{
    private LanguageSelectionState _languageSelectionState = null!;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        _languageSelectionState = new LanguageSelectionState();
    }

    [Test]
    [TestCase("1", "1")]
    [TestCase("2", "2")]
    [TestCase("3", "3")]
    [TestCase("4", "4")]
    [TestCase("5", "5")]
    [TestCase("6", "6")]
    public async Task Process_WithValidLanguageSelection_ShouldSetLanguageIdAndTransitionToDateSelection(string input, string expectedLanguageId)
    {
        // Arrange
        var context = CreateTestConversationState();
        
        // Act
        var result = await _languageSelectionState.Process(context, input);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.LanguageId, Is.EqualTo(expectedLanguageId));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.DateSelection));
        MockMessageCreator.Verify(mc => mc.CreateDatePromptMessage(context.UserNumber, int.Parse(expectedLanguageId)), Times.Once);
    }

    [Test]
    [TestCase("0")]
    [TestCase("7")]
    [TestCase("invalid")]
    [TestCase("")]
    [TestCase("abc")]
    public async Task Process_WithInvalidLanguageSelection_ShouldDefaultToSpanishAndTransitionToDateSelection(string input)
    {
        // Arrange
        var context = CreateTestConversationState();
        
        // Act
        var result = await _languageSelectionState.Process(context, input);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.LanguageId, Is.EqualTo("1")); // Default to Spanish
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.DateSelection));
        MockMessageCreator.Verify(mc => mc.CreateDatePromptMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    public void StateId_ShouldBeLanguageSelection()
    {
        // Assert
        Assert.That(_languageSelectionState.StateId, Is.EqualTo(ConversationStep.LanguageSelection));
    }
}
