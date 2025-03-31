using BlueWhatsapp.Api.Utils;
using BlueWhatsapp.Core.Logger;
using Microsoft.AspNetCore.Mvc;
using Quartz.Util;

namespace BlueWhatsapp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WhatsappController : ControllerBase
{
    private readonly IAppLogger _logger;

    public WhatsappController(IAppLogger logger)
    {
        _logger = logger;
    }

    [HttpGet("health")]
    public async Task<IActionResult> Health()
    {
        return Ok(new { healthy = true });
    }

    [HttpGet("verify-token")]
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
}