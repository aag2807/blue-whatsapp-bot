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
using BlueWhatsapp.Core.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Options;
using Quartz.Util;

namespace BlueWhatsapp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WhatsappController : ControllerBase
{
    private readonly IAppLogger _logger;
    private readonly IHubContext<MessagesHub> _hubContext;
    private readonly IChatResponseService _chatResponseService;
    private readonly WhatsAppCloudOptions _whatsAppOptions;

    /// <summary>
    /// Controller responsible for handling API endpoints related to WhatsApp integrations.
    /// </summary>
    /// <remarks>
    /// This controller provides functionalities such as validating tokens, handling incoming messages,
    /// and checking the health status of the service.
    /// </remarks>
    public WhatsappController(
        IAppLogger logger, 
        IHubContext<MessagesHub> hubContext, 
        IChatResponseService chatResponseService,
        IOptions<WhatsAppCloudOptions> whatsAppOptions)
    {
        _logger = logger;
        _hubContext = hubContext;
        _chatResponseService = chatResponseService;
        _whatsAppOptions = whatsAppOptions.Value;
    }

    /// <summary>
    /// Validates the token for the WhatsApp Cloud API. 
    /// </summary>
    /// <returns>The challenge response.</returns>
    [HttpGet]
    public IActionResult ValidateToken([FromQuery(Name = "hub.mode")] string mode, [FromQuery(Name = "hub.verify_token")] string token, [FromQuery(Name = "hub.challenge")] string challenge)
    {
        try
        {
            _logger.LogInfo("verify-token");
            _logger.LogInfo($"Received mode: {mode}");
            _logger.LogInfo($"Received token: {token}");
            _logger.LogInfo($"Received challenge: {challenge}");

            // Validate that we have a configured verify token
            if (string.IsNullOrWhiteSpace(_whatsAppOptions.VerifyToken))
            {
                _logger.LogError("VerifyToken is not configured in appsettings. Please set WhatsAppCloud__VerifyToken");
                return StatusCode(500, new { error = "VerifyToken not configured" });
            }

            // Validate the token matches
            if (string.IsNullOrWhiteSpace(token) || token != _whatsAppOptions.VerifyToken)
            {
                _logger.LogError($"Invalid token received. Expected: {_whatsAppOptions.VerifyToken}, Received: {token}");
                return Unauthorized(new { error = "Invalid verify token" });
            }

            // Validate mode
            if (mode != "subscribe")
            {
                _logger.LogError($"Invalid mode: {mode}");
                return BadRequest(new { error = "Invalid mode" });
            }

            _logger.LogInfo($"Webhook verification successful, returning challenge: {challenge}");
            return Ok(challenge);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error during token validation: {ex.Message}");
            _logger.LogError(ex);
            return StatusCode(500, new { error = "Internal server error during webhook verification" });
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
    public IActionResult Health()
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