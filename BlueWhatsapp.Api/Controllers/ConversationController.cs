using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using BlueWhatsapp.Api.models.VM;
using Microsoft.AspNetCore.Identity;
using BlueWhatsapp.Core.Services;
using BlueWhatsapp.Core.Models.Messages;
using Triplex.Validations;
namespace BlueWhatsapp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConversationController : ControllerBase
{
    private readonly IConversationService _conversationService;
    private readonly IMessageService _messageService;
    private readonly IWhatsappCloudService _whatsappCloudService;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="conversationService"></param>
    /// <param name="messageService"></param>
    /// <param name="whatsappCloudService"></param>
    public ConversationController(IConversationService conversationService, IMessageService messageService, IWhatsappCloudService whatsappCloudService)
    {
        _conversationService = conversationService;
        _messageService = messageService;
        _whatsappCloudService = whatsappCloudService;
    }

    [HttpGet("get-messages-by-phone-number/{phoneNumber}")]
    public async Task<IActionResult> GetMessagesByPhoneNumber(string phoneNumber)
    {
        IEnumerable<Core.Models.Messages.CoreMessage> messages = await _messageService.GetAllByPhoneNumber(phoneNumber).ConfigureAwait(true);
        
        return Ok(messages);
    }

    /// <summary>
    /// Send a message to a phone number
    /// </summary>
    /// <param name="message">A valid instance of <see cref="CoreMessageToSend"/></param>
    /// <returns>An Accepted response</returns>
    [HttpPost("send-message-from-backoffice")]
    public async Task<IActionResult> SendMessageFromBackoffice(Core.Models.Messages.CoreMessageToSend message)
    {
        Arguments.NotNull(message, nameof(message));

        await _whatsappCloudService.SendMessage(message).ConfigureAwait(true);

        return Accepted();
    }
}
