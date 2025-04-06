using System.ComponentModel.DataAnnotations.Schema;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

[Table("Messages")]
public sealed class Message: BaseEntity
{
    /// <summary>
    /// Represents the sender of the message.
    /// </summary>
    /// <remarks>
    /// The <see cref="From"/> property identifies the originator of the message.
    /// It is a required field and must be a non-empty string.
    /// </remarks>
    public string From { get; set; } = string.Empty;

    /// <summary>
    /// Represents the content of the message body.
    /// </summary>
    /// <remarks>
    /// The <see cref="Body"/> property contains the textual content of a message.
    /// It is a required field and must be a non-empty string.
    /// </remarks>
    public string Body { get; set; } = string.Empty;

    /// <summary>
    /// Represents the status of the message in its lifecycle.
    /// </summary>
    /// <remarks>
    /// The <see cref="Status"/> property indicates the current state of a message.
    /// It is of type <see cref="MessageStatus"/> and can hold values such as
    /// None, Pending, or Completed, which represent different stages of message processing.
    /// </remarks>
    public MessageStatus Status { get; set; } = MessageStatus.None;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public CoreMessage ToCore()
    {
        return CoreMessage.Create<Message>(this);
    }

    public static Message FromCore(CoreMessage message)
    {
        return new Message
        {
            From = message.From,
            Body = message.Body,
            Status = message.Status
        };
    }
}