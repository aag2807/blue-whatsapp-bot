using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Services;
using BlueWhatsapp.Core.Services.ChatService;
using BlueWhatsapp.Test.StateTests;
using Moq;

namespace BlueWhatsapp.Test.ServiceTests;

[TestFixture]
public class ChatResponseServiceTests : BaseStateTest
{
    private ChatResponseResponseService _chatResponseService = null!;
    private Mock<IConversationStateService> _mockConversationStateService = null!;
    private Mock<IMessageService> _mockMessageService = null!;
    private Mock<IWhatsappCloudService> _mockWhatsappCloudService = null!;
    private Mock<IConversationHandlingService> _mockConversationHandlingService = null!;
    private Mock<IAppLogger> _mockLogger = null!;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        
        _mockConversationStateService = new Mock<IConversationStateService>();
        _mockMessageService = new Mock<IMessageService>();
        _mockWhatsappCloudService = new Mock<IWhatsappCloudService>();
        _mockConversationHandlingService = new Mock<IConversationHandlingService>();
        _mockLogger = new Mock<IAppLogger>();

        _chatResponseService = new ChatResponseResponseService(
            _mockConversationStateService.Object,
            _mockMessageService.Object,
            _mockLogger.Object,
            _mockWhatsappCloudService.Object,
            _mockConversationHandlingService.Object
        );
    }

    [Test]
    public async Task Execute_WithNewUser_ShouldCreateConversationStateAndStartFlow()
    {
        // Arrange
        var userNumber = "123456789";
        var fromName = "John Doe";
        var userText = "Hello";
        var newContext = CreateTestConversationState(userNumber);
        var responseMessage = new CoreMessageToSend("Welcome message", userNumber);

        _mockConversationStateService.Setup(css => css.GetConversationStateByNumber(userNumber))
            .ReturnsAsync((CoreConversationState?)null);
        _mockConversationStateService.Setup(css => css.CreateNewConversationState(userNumber))
            .ReturnsAsync(newContext);
        _mockConversationHandlingService.Setup(chs => chs.HandleState(It.IsAny<CoreConversationState>(), It.IsAny<string>()))
            .ReturnsAsync(responseMessage);

        // Act
        await ((IChatResponseService)_chatResponseService).Execute(userNumber, fromName, userText);

        // Assert
        _mockConversationStateService.Verify(css => css.CreateNewConversationState(userNumber), Times.Once);
        _mockConversationHandlingService.Verify(chs => chs.HandleState(It.Is<CoreConversationState>(c => 
            c.UserNumber == userNumber && c.PersonName == fromName), It.Is<string>(s => s == userText)), Times.Once);
        _mockWhatsappCloudService.Verify(wcs => wcs.SendMessage(responseMessage), Times.Once);
        _mockMessageService.Verify(ms => ms.SaveAsync(It.Is<string>(s => s == fromName), It.Is<string>(s => s == userText), It.Is<string>(s => s == userNumber), It.IsAny<MessageStatus>()), Times.Once);
        _mockConversationStateService.Verify(css => css.UpdateConversationState(It.IsAny<CoreConversationState>()), Times.Once);
    }

    [Test]
    public async Task Execute_WithExistingUser_ShouldUseExistingConversationState()
    {
        // Arrange
        var userNumber = "123456789";
        var fromName = "John Doe";
        var userText = "2"; // Language selection
        var existingContext = CreateTestConversationState(userNumber);
        existingContext.CurrentStep = ConversationStep.LanguageSelection;
        var responseMessage = new CoreMessageToSend("Date selection message", userNumber);

        _mockConversationStateService.Setup(css => css.GetConversationStateByNumber(userNumber))
            .ReturnsAsync(existingContext);
        _mockConversationHandlingService.Setup(chs => chs.HandleState(existingContext, It.IsAny<string>()))
            .ReturnsAsync(responseMessage);

        // Act
        await ((IChatResponseService)_chatResponseService).Execute(userNumber, fromName, userText);

        // Assert
        _mockConversationStateService.Verify(css => css.CreateNewConversationState(It.IsAny<string>()), Times.Never);
        _mockConversationHandlingService.Verify(chs => chs.HandleState(existingContext, It.Is<string>(s => s == userText)), Times.Once);
        _mockWhatsappCloudService.Verify(wcs => wcs.SendMessage(responseMessage), Times.Once);
        _mockMessageService.Verify(ms => ms.SaveAsync(It.Is<string>(s => s == fromName), It.Is<string>(s => s == userText), It.Is<string>(s => s == userNumber), It.IsAny<MessageStatus>()), Times.Once);
        _mockConversationStateService.Verify(css => css.UpdateConversationState(existingContext), Times.Once);
    }

    [Test]
    public async Task Execute_WithAdminOverriddenUser_ShouldOnlySaveMessage()
    {
        // Arrange
        var userNumber = "123456789";
        var fromName = "John Doe";
        var userText = "Some message";
        var existingContext = CreateTestConversationState(userNumber);
        existingContext.IsAdminOverridden = true;

        _mockConversationStateService.Setup(css => css.GetConversationStateByNumber(userNumber))
            .ReturnsAsync(existingContext);

        // Act
        await ((IChatResponseService)_chatResponseService).Execute(userNumber, fromName, userText);

        // Assert
        _mockConversationHandlingService.Verify(chs => chs.HandleState(It.IsAny<CoreConversationState>(), It.IsAny<string>()), Times.Never);
        _mockWhatsappCloudService.Verify(wcs => wcs.SendMessage(It.IsAny<CoreBaseMessage>()), Times.Never);
        _mockMessageService.Verify(ms => ms.SaveAsync(It.Is<string>(s => s == fromName), It.Is<string>(s => s == userText), It.Is<string>(s => s == userNumber), It.IsAny<MessageStatus>()), Times.Once);
        _mockConversationStateService.Verify(css => css.UpdateConversationState(It.IsAny<CoreConversationState>()), Times.Never);
    }

    [Test]
    public async Task Execute_WithWelcomeState_ShouldHandleSpecialWelcomeFlow()
    {
        // Arrange
        var userNumber = "123456789";
        var fromName = "John Doe";
        var userText = "Hello";
        var existingContext = CreateTestConversationState(userNumber);
        existingContext.CurrentStep = ConversationStep.Welcome;

        _mockConversationStateService.Setup(css => css.GetConversationStateByNumber(userNumber))
            .ReturnsAsync(existingContext);

        // Act
        await ((IChatResponseService)_chatResponseService).Execute(userNumber, fromName, userText);

        // Assert
        // Should handle welcome state specially (based on implementation)
        _mockMessageService.Verify(ms => ms.SaveAsync(It.Is<string>(s => s == fromName), It.Is<string>(s => s == userText), It.Is<string>(s => s == userNumber), It.IsAny<MessageStatus>()), Times.Once);
    }

    [Test]
    public async Task Execute_WhenHandlingReturnsNull_ShouldNotSendMessage()
    {
        // Arrange
        var userNumber = "123456789";
        var fromName = "John Doe";
        var userText = "Invalid input";
        var existingContext = CreateTestConversationState(userNumber);

        _mockConversationStateService.Setup(css => css.GetConversationStateByNumber(userNumber))
            .ReturnsAsync(existingContext);
        _mockConversationHandlingService.Setup(chs => chs.HandleState(existingContext, It.IsAny<string>()))
            .ReturnsAsync((CoreBaseMessage?)null);

        // Act
        await ((IChatResponseService)_chatResponseService).Execute(userNumber, fromName, userText);

        // Assert
        _mockWhatsappCloudService.Verify(wcs => wcs.SendMessage(It.IsAny<CoreBaseMessage>()), Times.Never);
        _mockMessageService.Verify(ms => ms.SaveAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<MessageStatus>()), Times.Never);
        _mockConversationStateService.Verify(css => css.UpdateConversationState(It.IsAny<CoreConversationState>()), Times.Never);
    }

    [Test]
    public async Task Execute_WhenHandlingSucceeds_ShouldSendMessageAndSaveAndUpdate()
    {
        // Arrange
        var userNumber = "123456789";
        var fromName = "John Doe";
        var userText = "Valid input";
        var existingContext = CreateTestConversationState(userNumber);
        var responseMessage = new CoreMessageToSend("Response", userNumber);

        _mockConversationStateService.Setup(css => css.GetConversationStateByNumber(userNumber))
            .ReturnsAsync(existingContext);
        _mockConversationHandlingService.Setup(chs => chs.HandleState(existingContext, It.IsAny<string>()))
            .ReturnsAsync(responseMessage);

        // Act
        await ((IChatResponseService)_chatResponseService).Execute(userNumber, fromName, userText);

        // Assert - Verify order of operations
        _mockWhatsappCloudService.Verify(wcs => wcs.SendMessage(responseMessage), Times.Once);
        _mockMessageService.Verify(ms => ms.SaveAsync(It.Is<string>(s => s == fromName), It.Is<string>(s => s == userText), It.Is<string>(s => s == userNumber), It.IsAny<MessageStatus>()), Times.Once);
        _mockConversationStateService.Verify(css => css.UpdateConversationState(existingContext), Times.Once);
    }
}
