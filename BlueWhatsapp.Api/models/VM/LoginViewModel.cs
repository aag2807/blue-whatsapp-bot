using System.ComponentModel.DataAnnotations;

namespace BlueWhatsapp.Api.models.VM;

public class LoginViewModel
{
    /// <summary>
    /// 
    /// </summary>
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
}