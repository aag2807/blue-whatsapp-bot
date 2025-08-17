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
    public async Task AskForFullNameState_Process_WithValidName_ShouldSetNameAndTransitionToAskForRoomNumber()
    {
        // Arrange
        var context = CreateTestConversationState();
        var userMessage = "John Doe";

        // Act
        var result = await _askForFullNameState.Process(context, userMessage);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.FullName, Is.EqualTo("John Doe"));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForRoomNumber));
        MockMessageCreator.Verify(mc => mc.CreateAskForRoomNumberMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("")]
    [TestCase(" ")]
    [TestCase("A")]
    public async Task AskForFullNameState_Process_WithInvalidName_ShouldAskForNameAgain(string invalidName)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForFullNameState.Process(context, invalidName);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForFullName)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateAskingForNameMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion

    #region AskForRoomNumberState Tests

    [Test]
    [TestCase("101")]
    [TestCase("A1B")]
    [TestCase("Presidential Suite")]
    public async Task AskForRoomNumberState_Process_WithValidRoomNumber_ShouldSetRoomNumberAndTransitionToAskForAdults(string validRoomNumber)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForRoomNumberState.Process(context, validRoomNumber);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.RoomNumber, Is.EqualTo(validRoomNumber.Trim()));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForAdults));
        MockMessageCreator.Verify(mc => mc.CreateAskForAdultsCountMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("")]
    [TestCase(" ")]
    public async Task AskForRoomNumberState_Process_WithInvalidRoomNumber_ShouldAskForRoomNumberAgain(string invalidRoomNumber)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForRoomNumberState.Process(context, invalidRoomNumber);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForRoomNumber)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateAskForRoomNumberMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion

    #region AskForAdultsState Tests

    [Test]
    [TestCase("1", 1)]
    [TestCase("2", 2)]
    [TestCase("10", 10)]
    [TestCase("50", 50)]
    public async Task AskForAdultsState_Process_WithValidAdultsCount_ShouldSetAdultsAndTransitionToAskForChildren(string adultsInput, int expectedAdults)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForAdultsState.Process(context, adultsInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.Adults, Is.EqualTo(expectedAdults));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForChildren));
        MockMessageCreator.Verify(mc => mc.CreateAskForChildrenCountMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("0")]
    [TestCase("-1")]
    [TestCase("51")]
    [TestCase("invalid")]
    [TestCase("")]
    public async Task AskForAdultsState_Process_WithInvalidAdultsCount_ShouldAskForAdultsAgain(string invalidAdultsInput)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForAdultsState.Process(context, invalidAdultsInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForAdults)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateAskForAdultsCountMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion

    #region AskForChildrenState Tests

    [Test]
    [TestCase("0", 0)]
    [TestCase("1", 1)]
    [TestCase("5", 5)]
    [TestCase("20", 20)]
    public async Task AskForChildrenState_Process_WithValidChildrenCount_ShouldSetChildrenAndTransitionToAskForPhone(string childrenInput, int expectedChildren)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForChildrenState.Process(context, childrenInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.Children, Is.EqualTo(expectedChildren));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForPhone));
        MockMessageCreator.Verify(mc => mc.CreateAskForPhoneMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("-1")]
    [TestCase("21")]
    [TestCase("invalid")]
    [TestCase("")]
    public async Task AskForChildrenState_Process_WithInvalidChildrenCount_ShouldAskForChildrenAgain(string invalidChildrenInput)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForChildrenState.Process(context, invalidChildrenInput);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForChildren)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateAskForChildrenCountMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion

    #region AskForPhoneState Tests

    [Test]
    [TestCase("1234567890")]
    [TestCase("+1-234-567-8900")]
    [TestCase("(809) 555-1234")]
    [TestCase("809.555.1234")]
    [TestCase("8095551234")]
    public async Task AskForPhoneState_Process_WithValidPhoneNumber_ShouldSetPhoneAndTransitionToAskForEmail(string validPhone)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForPhoneState.Process(context, validPhone);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.ExtraInformation, Is.EqualTo(validPhone.Trim()));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForEmail));
        MockMessageCreator.Verify(mc => mc.CreateAskingEmailMessage(context.UserNumber, 1), Times.Once);
    }

    [Test]
    [TestCase("123")]
    [TestCase("12345678901234567890")]
    [TestCase("abc")]
    [TestCase("")]
    [TestCase("123-abc-456")]
    public async Task AskForPhoneState_Process_WithInvalidPhoneNumber_ShouldAskForPhoneAgain(string invalidPhone)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForPhoneState.Process(context, invalidPhone);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForPhone)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateAskForPhoneMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion

    #region AskForEmailState Tests

    [Test]
    [TestCase("user@example.com")]
    [TestCase("test.email@domain.org")]
    [TestCase("john.doe@company.co.uk")]
    public async Task AskForEmailState_Process_WithValidEmail_ShouldSetEmailAndTransitionToReservationComplete(string validEmail)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForEmailState.Process(context, validEmail);

        // Assert
        Assert.That(result, Is.Null); // Should return null to trigger transition to ReservationComplete
        Assert.That(context.Email, Is.EqualTo(validEmail.Trim()));
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.ReservationComplete));
    }

    [Test]
    [TestCase("invalid-email")]
    [TestCase("@example.com")]
    [TestCase("user@")]
    [TestCase("")]
    [TestCase("user.example.com")]
    public async Task AskForEmailState_Process_WithInvalidEmail_ShouldAskForEmailAgain(string invalidEmail)
    {
        // Arrange
        var context = CreateTestConversationState();

        // Act
        var result = await _askForEmailState.Process(context, invalidEmail);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(context.CurrentStep, Is.EqualTo(ConversationStep.AskForEmail)); // Should stay in same state
        MockMessageCreator.Verify(mc => mc.CreateAskingEmailMessage(context.UserNumber, 1), Times.Once);
    }

    #endregion
}
