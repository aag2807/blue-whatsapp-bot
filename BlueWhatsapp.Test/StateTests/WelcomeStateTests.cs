using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.State.StateNodes;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

[TestFixture]
public class WelcomeStateTests : BaseStateTest
{
    private WelcomeState _welcomeState = null!;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        _welcomeState = new WelcomeState();
    }

    [Test]
    public async Task Process_ShouldReturnWelcomeMessage_AndTransitionToLanguageSelection()
    {
        // Arrange
        var context = CreateTestConversationState();
        var userMessage = "";

        // Act
        var result = await _welcomeState.Process(context, userMessage);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.LanguageSelection));
        MockMessageCreator.Verify(mc => mc.CreateWelcomeMessage(context.UserNumber), Times.Once);
    }

    [Test]
    public void StateId_ShouldBeWelcome()
    {
        // Assert
        Assert.That(_welcomeState.StateId, Is.EqualTo(ConversationStep.Welcome));
    }
}
