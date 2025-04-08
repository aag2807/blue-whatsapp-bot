using BlueWhatsapp.Core.Enums;

namespace BlueWhatsapp.Core.Models.Messages;

/// <summary>
/// Represents the core message entity containing details about a message such as the sender, content, status,
/// and timestamp of creation. This class extends from the <see cref="BaseEntity"/> class, inheriting
/// base entity functionalities.
/// </summary>
public sealed class CoreMessage : BaseEntity
{
    /// <summary>
    /// Represents the number of the message.
    /// </summary>
    /// <remarks>
    /// The <see cref="Number"/> property identifies the number of the message.
    /// It is a required field and must be a non-empty string.
    /// </remarks>
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// Represents the sender of the message.
    /// </summary>
    /// <remarks>
    /// The <see cref="From"/> property identifies the originator of the message.
    /// It is a required field and must be a non-empty string.
    /// </remarks>
    public string From { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the content of the message body.
    /// </summary>
    public string Body { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the status of the message.
    /// </summary>
    public MessageStatus Status { get; set; } = MessageStatus.None;

    /// <summary>
    /// Gets or sets the date and time when the message was created.
    /// </summary>
    public DateTime CreatedTime { get; set; } = DateTime.Now;

    /// <summary>
    /// Creates a new instance of the <see cref="CoreMessage"/> class by setting its properties
    /// based on the provided raw message and originating number.
    /// </summary>
    /// <param name="message">The raw message content to be assigned to the Body property.</param>
    /// <param name="number">The originating number to be associated with the from property.</param>
    /// <returns>A new <see cref="CoreMessage"/> instance with the specified properties set.</returns>
    public CoreMessage FromRaw(string message, string number)
    {
        CoreMessage coreMessage = new();
        coreMessage.From = From;
        coreMessage.Body = message;

        return coreMessage;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="CoreMessage"/> class by mapping the properties
    /// from the provided data object of type <typeparamref name="T"/>.
    /// </summary>
    /// <param name="data">The data object containing the properties to be mapped to the new <see cref="CoreMessage"/> instance.</param>
    /// <typeparam name="T">The type of the data object from which the <see cref="CoreMessage"/> properties are derived. It must be a reference type.</typeparam>
    /// <returns>A new <see cref="CoreMessage"/> instance populated with the properties from the provided data object.</returns>
    public static CoreMessage Create<T>(T data) where T : class
    {
        return BaseEntity.Create<CoreMessage, T>(data);
    }
}