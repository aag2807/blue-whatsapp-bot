using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.State.StateNodes;
using Moq;

namespace BlueWhatsapp.Test.StateTests;

[TestFixture]
public class UserInformationStatesTests : BaseStateTest
{
    private AskForFullNameState _askForFullNameState = null!;
    private AskForRoomNumberState _askForRoomNumberState = null!;
    private AskForAdultsState _askForAdultsState = null!;
    private AskForChildrenState _askForChildrenState = null!;
    private AskForPhoneState _askForPhoneState = null!;
    private AskForEmailState _askForEmailState = null!;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        _askForFullNameState = new AskForFullNameState();
        _askForRoomNumberState = new AskForRoomNumberState();
        _askForAdultsState = new AskForAdultsState();
        _askForChildrenState = new AskForChildrenState();
        _askForPhoneState = new AskForPhoneState();
        _askForEmailState = new AskForEmailState();
    }

    #region AskForFullNameState Tests

    [Test]
    public async Task AskForFullNameState_Process_ShouldTransitionToAskForRoomNumber()
    {
        // Arrange
        var context = CreateTestConversationState();
        var userMessage = "";

        // Act
        var result = await _askForFullNameState.Process(context, userMessage);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForRoomNumber));
        MockMessageCreator.Verify(mc => mc.CreateAskingForNameMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion

    #region AskForRoomNumberState Tests

    [Test]
    [TestCase("John Doe")]
    [TestCase("María García")]
    [TestCase("Jean Pierre")]
    public async Task AskForRoomNumberState_Process_WithValidName_ShouldSetFullNameAndTransitionToAskForAdults(string validName)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForRoomNumberState.Process(context, validName);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.FullName, Is.EqualTo(validName.Trim()));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForAdults));
        MockMessageCreator.Verify(mc => mc.CreateAskForRoomNumberMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("")]
    [TestCase(" ")]
    [TestCase("A")]
    public async Task AskForRoomNumberState_Process_WithInvalidName_ShouldAskForNameAgain(string invalidName)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForRoomNumberState.Process(context, invalidName);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForRoomNumber)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateAskingForNameMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion

    #region AskForAdultsState Tests

    [Test]
    [TestCase("101")]
    [TestCase("A1B")]
    [TestCase("Presidential Suite")]
    public async Task AskForAdultsState_Process_WithValidRoomNumber_ShouldSetRoomNumberAndTransitionToAskForChildren(string validRoomNumber)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForAdultsState.Process(context, validRoomNumber);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.RoomNumber, Is.EqualTo(validRoomNumber.Trim()));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForChildren));
        MockMessageCreator.Verify(mc => mc.CreateAskForAdultsCountMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("")]
    [TestCase(" ")]
    public async Task AskForAdultsState_Process_WithInvalidRoomNumber_ShouldAskForRoomNumberAgain(string invalidRoomNumber)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForAdultsState.Process(context, invalidRoomNumber);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForAdults)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateAskForRoomNumberMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion

    #region AskForChildrenState Tests

    [Test]
    [TestCase("1", 1)]
    [TestCase("2", 2)]
    [TestCase("10", 10)]
    [TestCase("50", 50)]
    public async Task AskForChildrenState_Process_WithValidAdultsCount_ShouldSetAdultsAndTransitionToAskForPhone(string adultsInput, int expectedAdults)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForChildrenState.Process(context, adultsInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.Adults, Is.EqualTo(expectedAdults));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForPhone));
        MockMessageCreator.Verify(mc => mc.CreateAskForChildrenCountMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("0")]
    [TestCase("-1")]
    [TestCase("51")]
    [TestCase("invalid")]
    [TestCase("")]
    public async Task AskForChildrenState_Process_WithInvalidAdultsCount_ShouldAskForAdultsAgain(string invalidAdultsInput)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForChildrenState.Process(context, invalidAdultsInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForChildren)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateAskForAdultsCountMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion

    #region AskForPhoneState Tests

    [Test]
    [TestCase("0", 0)]
    [TestCase("1", 1)]
    [TestCase("5", 5)]
    [TestCase("20", 20)]
    public async Task AskForPhoneState_Process_WithValidChildrenCount_ShouldSetChildrenAndTransitionToAskForEmail(string childrenInput, int expectedChildren)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForPhoneState.Process(context, childrenInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.Children, Is.EqualTo(expectedChildren));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForEmail));
        MockMessageCreator.Verify(mc => mc.CreateAskingEmailMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("-1")]
    [TestCase("21")]
    [TestCase("invalid")]
    [TestCase("")]
    public async Task AskForPhoneState_Process_WithInvalidChildrenCount_ShouldAskForChildrenAgain(string invalidChildrenInput)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForPhoneState.Process(context, invalidChildrenInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForPhone)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateAskForChildrenCountMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion

    #region AskForEmailState Tests

    [Test]
    [TestCase("1234567890")]
    [TestCase("+1-234-567-8900")]
    [TestCase("(809) 555-1234")]
    [TestCase("809.555.1234")]
    [TestCase("8095551234")]
    public async Task AskForEmailState_Process_WithValidPhoneNumber_ShouldSetPhoneAndTransitionToReservationComplete(string validPhone)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForEmailState.Process(context, validPhone);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.ExtraInformation, Is.EqualTo(validPhone.Trim()));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ReservationComplete));
        MockMessageCreator.Verify(mc => mc.CreateAskingEmailMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("123")]
    [TestCase("12345678901234567890")]
    [TestCase("abc")]
    [TestCase("")]
    [TestCase("123-abc-456")]
    public async Task AskForEmailState_Process_WithInvalidPhoneNumber_ShouldAskForPhoneAgain(string invalidPhone)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForEmailState.Process(context, invalidPhone);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForEmail)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateAskingEmailMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion
}
