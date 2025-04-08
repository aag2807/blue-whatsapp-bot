using BlueWhatsapp.Api.Hubs;
using BlueWhatsapp.Api.models.DTO;
using BlueWhatsapp.Api.models.DTO.Messages;
using BlueWhatsapp.Api.Utils;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Quartz.Util;

namespace BlueWhatsapp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WhatsappController : ControllerBase
{
    private readonly IAppLogger _logger;
    private readonly IWhatsappCloudService _whatsappCloudService;
    private readonly IHubContext<MessagesHub> _hubContext;
    private readonly IMessageService _messageService;
    private readonly IConversationStateService _conversationStateService;
    private readonly IConversationService _conversationService;

    /// <summary>
    /// Controller responsible for handling API endpoints related to WhatsApp integrations.
    /// </summary>
    /// <remarks>
    /// This controller provides functionalities such as validating tokens, handling incoming messages,
    /// and checking the health status of the service.
    /// </remarks>
    public WhatsappController(
        IAppLogger logger, 
        IWhatsappCloudService whatsappCloudService, 
        IHubContext<MessagesHub> hubContext, 
        IMessageService messageService,
        IConversationStateService conversationStateService,
        IConversationService conversationService
        )
    {
        _logger = logger;
        _whatsappCloudService = whatsappCloudService;
        _hubContext = hubContext;
        _messageService = messageService;
        _conversationStateService = conversationStateService;
        _conversationService = conversationService;
    }

    /// <summary>
    /// Validates the token for the WhatsApp Cloud API. 
    /// </summary>
    /// <returns>The challenge response.</returns>
    [HttpGet]
    [LogAction]
    public async Task<IActionResult> ValidateToken()
    {
        _logger.LogInfo("verify-token");

        const string accessToken =
            "EAAJZBUAn6wJcBADZCDnZCT0VEIqfScKb37HVn8ZAfPwl5LXZBm3r4ZBeE0ZCeVgf9DgZCY6YrXqLb1TxE9ZAZBfNPMjUuIiOHy18wxmTcOEtqWZAj6DTZAm1JvtEt9gYgJHOCySPrGYrJDYXmZBUPISDV6ezOPdI8MVE8fKwHq0ZBxzyjhVtq5eLQXQRljWIXPNHwYPqkJF";
        string token = Request.Query["hub.verify_token"].ToString();
        string challenge = Request.Query["hub.challenge"].ToString();

        _logger.LogInfo($"token: {token}");
        _logger.LogInfo($"challenge: {challenge}");

        if (token.IsNullOrWhiteSpace() || token.IsNullOrWhiteSpace() || token is not accessToken)
        {
            _logger.LogError("Invalid token");
            return BadRequest();
        }

        return Ok(challenge);
    }

    [HttpPost]
    [LogAction]
    public async Task<IActionResult> ReceiveMessage([FromBody] object body)
    {
        _logger.LogInfo("receive-message");
        _logger.LogInfo(body);
        
        return Ok("EVENT_RECEIVED");
        // try
        // {
        //     Message? message = body.GetMessage();
        //     if (message == null)
        //     {
        //         return Ok("EVENT_RECEIVED");
        //     }

        //     string userNumber = message.From!;
        //     string userText = GetUserText(message);
        //     string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            
        //     CoreConversationState? state = await _conversationStateService.GetConversationStateByNumber(userNumber).ConfigureAwait(true);
        //     if (state == null)
        //     {
        //         state = await _conversationStateService.CreateNewConversationState(userNumber).ConfigureAwait(true);
        //     }
        
        //     if (state.IsAdminOverridden)
        //     {
        //         await _messageService.SaveAsync(userText, userNumber).ConfigureAwait(true);
        //         await _hubContext.Clients.All.SendAsync("ReceiveWhatsAppMessage", userNumber, timestamp).ConfigureAwait(true);
        //         return Ok("EVENT_RECEIVED");
        //     }

        //     string response = await _conversationService.ProcessMessageAsync(userText, userNumber).ConfigureAwait(true);
        //     if (response != null)
        //     {
        //         await _whatsappCloudService.SendMessage(new CoreMessageToSend(response, userNumber)).ConfigureAwait(true);
        //         await _messageService.SaveAsync(response, userNumber).ConfigureAwait(true);
        //     }
        
        //     await _messageService.SaveAsync(userText, userNumber).ConfigureAwait(true);
        //     await _hubContext.Clients.All.SendAsync("ReceiveWhatsAppMessage", userNumber, timestamp).ConfigureAwait(true);
        // }
        // catch (Exception ex)
        // {
        //     _logger.LogError(ex);
        //     return Ok("EVENT_RECEIVED");
        // }
        
        // return Ok("EVENT_RECEIVED");
    }
    
    private string GetUserText(Message message)
    {
        string TypeMessage = message.Type;

        if(TypeMessage.ToUpper() == "TEXT")
        {
            return message.Text.Body;
        }
        else if (TypeMessage.ToUpper() == "INTERACTIVE")
        {
            string interactiveType = message.Interactive.Type;

            if(interactiveType.ToUpper() == "LIST_REPLY")
            {
                return message.Interactive.List_Reply.Title;
            }
            else if (interactiveType.ToUpper() == "BUTTON_REPLY")
            {
                return message.Interactive.Button_Reply.Title;
            }
            else
            {
                return string.Empty;
            }
        }
        else
        {
            return string.Empty;
        }
    }
    
    [HttpGet("health")]
    [LogAction]
    public async Task<IActionResult> Health()
    {
        return Ok(new { healthy = true });
    }
}