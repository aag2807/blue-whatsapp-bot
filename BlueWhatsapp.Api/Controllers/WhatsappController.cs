using BlueWhatsapp.Api.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Triplex.Validations;

namespace BlueWhatsapp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WhatsappController : ControllerBase
{
    [HttpGet("")]
    [LogAction]
    public async Task<IActionResult> Get()
    {
        return Ok();
    }
}