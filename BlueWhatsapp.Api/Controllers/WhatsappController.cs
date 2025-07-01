using BlueWhatsapp.Api.Hubs;
using BlueWhatsapp.Api.models.DTO;
using BlueWhatsapp.Api.models.DTO.Messages;
using BlueWhatsapp.Api.Utils;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Services;
using BlueWhatsapp.Core.Services.ChatService;
using BlueWhatsapp.Core.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Quartz.Util;

namespace BlueWhatsapp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WhatsappController : ControllerBase
{
    private readonly IAppLogger _logger;
    private readonly IHubContext<MessagesHub> _hubContext;
    private readonly IChatResponseService _chatResponseService;

    /// <summary>
    /// Controller responsible for handling API endpoints related to WhatsApp integrations.
    /// </summary>
    /// <remarks>
    /// This controller provides functionalities such as validating tokens, handling incoming messages,
    /// and checking the health status of the service.
    /// </remarks>
    public WhatsappController(IAppLogger logger, IHubContext<MessagesHub> hubContext, IChatResponseService chatResponseService)
    {
        _logger = logger;
        _hubContext = hubContext;
        _chatResponseService = chatResponseService;
    }

    /// <summary>
    /// Validates the token for the WhatsApp Cloud API. 
    /// </summary>
    /// <returns>The challenge response.</returns>
    [HttpGet]
    public async Task<IActionResult> ValidateToken([FromQuery(Name = "hub.mode")] string mode, [FromQuery(Name = "hub.verify_token")] string token, [FromQuery(Name = "hub.challenge")] string challenge)
    {
        try
        {
            _logger.LogInfo("verify-token");

            const string accessToken =
                "EAAJZBUAn6wJcBADZCDnZCT0VEIqfScKb37HVn8ZAfPwl5LXZBm3r4ZBeE0ZCeVgf9DgZCY6YrXqLb1TxE9ZAZBfNPMjUuIiOHy18wxmTcOEtqWZAj6DTZAm1JvtEt9gYgJHOCySPrGYrJDYXmZBUPISDV6ezOPdI8MVE8fKwHq0ZBxzyjhVtq5eLQXQRljWIXPNHwYPqkJF";

            _logger.LogInfo($"token: {token}");
            _logger.LogInfo($"challenge: {challenge}");

            if (token.IsNullOrWhiteSpace() || token.IsNullOrWhiteSpace() || token is not accessToken)
            {
                _logger.LogError("Invalid token");
                return BadRequest();
            }

            return Ok(challenge);
        }
        catch (Exception ex)
        {
            _logger.LogError($"token: {ex.Message}");
            throw new Exception("issue happened");
        }
    }

    [HttpPost]
    [LogAction]
    public async Task<IActionResult> ReceiveMessage([FromBody] WhatsAppCloudModel body)
    {
        if (!body.IsValidEntity())
        {
            return Ok("EVENT_RECEIVED");
        }

        _logger.LogInfo("receive-message");
        _logger.LogInfo(body);
        
        try
        {
            Message? message = body.GetMessage();
            if (message == null)
            {
                _logger.LogInfo("No message received");
                return Ok("EVENT_RECEIVED");
            }

            string userNumber = message.From!;
            string fromName = body.GetContactProfileName() ?? string.Empty;
            string userText = message.GetUserText();
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            await _chatResponseService.Execute(userNumber, fromName, userText).ConfigureAwait(true);
            await _hubContext.Clients.All.SendAsync("ReceiveWhatsAppMessage", userNumber, timestamp).ConfigureAwait(true);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex);
        }

        return Ok("EVENT_RECEIVED");
    }

    [HttpGet("health")]
    [LogAction]
    public async Task<IActionResult> Health()
    {
        return Ok(new { healthy = true });
    }
    
    private bool HasContent(WhatsAppCloudModel body)
    {
        if (body.Entry == null || body.Entry.Count == 0)
        {
            return false;
        }
        
        foreach (var entry in body.Entry)
        {
            if (entry.Changes == null || entry.Changes.Count == 0)
                continue;
            
            foreach (var change in entry.Changes)
            {
                var value = change.Value;
                if (value == null)
                    continue;
                
                // Check if there are any actual messages or contacts
                if ((value.Messages != null && value.Messages.Count > 0) ||
                    (value.Contacts != null && value.Contacts.Count > 0))
                {
                    return true;
                }
            }
        }
    
        return false;
    }
}