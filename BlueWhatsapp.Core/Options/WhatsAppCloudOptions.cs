namespace BlueWhatsapp.Core.Options;

/// <summary>
/// Configuration options for WhatsApp Cloud API
/// </summary>
public class WhatsAppCloudOptions
{
    /// <summary>
    /// Configuration section name in appsettings.json
    /// </summary>
    public const string SectionName = "WhatsAppCloud";

    /// <summary>
    /// WhatsApp Cloud API access token
    /// </summary>
    public string AccessToken { get; set; } = string.Empty;

    /// <summary>
    /// WhatsApp Business Phone Number ID
    /// </summary>
    public string PhoneNumberId { get; set; } = string.Empty;

    /// <summary>
    /// WhatsApp Cloud API base endpoint
    /// </summary>
    public string BaseEndpoint { get; set; } = "https://graph.facebook.com/v22.0";

    /// <summary>
    /// API version to use (default: v22.0)
    /// </summary>
    public string ApiVersion { get; set; } = "v22.0";

    /// <summary>
    /// Timeout for HTTP requests in seconds (default: 30)
    /// </summary>
    public int TimeoutSeconds { get; set; } = 30;

    /// <summary>
    /// Whether to enable request/response logging for debugging
    /// </summary>
    public bool EnableLogging { get; set; } = true;
}
