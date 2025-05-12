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
    [LogAction]
    public async Task<IActionResult> ValidateToken()
    {
        _logger.LogInfo("verify-token");

        const string accessToken =
            "EAAN28uo8ybUBOwGonoTm1mnHMX7IQid4YDii9THUHfdJGNaadhIg7wo06veATYOcjZCL0Y9eZC5hZB5laDjPRcl15EHAM7JwKug7o0OX3ZCkyzcxD0HD8aR2yrFvkg45EbgmpZANmbRTrUscZB1YIZAzZCD50PEBRO7C5cqnE4ELmajP4MYSiBQB0HYVk5TrhAFkVQZDZD";
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
    public async Task<IActionResult> ReceiveMessage([FromBody] WhatsAppCloudModel body)
    {
        _logger.LogInfo("receive-message");
        _logger.LogInfo(body);

        try
        {
            Message? message = body.GetMessage();
            if (message == null)
            {
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
            return Ok("EVENT_RECEIVED");
        }
        
        return Ok("EVENT_RECEIVED");
    }
    
    [HttpGet("health")]
    [LogAction]
    public async Task<IActionResult> Health()
    {
        return Ok(new { healthy = true });
    }
}