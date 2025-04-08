using BlueWhatsapp.Core.Enums;

namespace BlueWhatsapp.Core.Models;

public class CoreConversationState : BaseEntity
{
        /// <summary>
        /// Gets or sets the user's phone number associated with the conversation.
        /// </summary>
        public string UserNumber { get; set; } = string.Empty; 

        /// <summary>
        /// Gets or sets the current step of the conversation process.
        /// </summary>
        public ConversationStep CurrentStep { get; set; } = ConversationStep.None;

        /// <summary>
        /// Gets or sets a value indicating whether the admin override functionality has been applied to the conversation state.
        /// </summary>
        public bool IsAdminOverridden { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the conversation process has been completed.
        /// </summary>
        public bool IsComplete { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="CoreConversationState"/> initialized with the specified data.
        /// </summary>
        /// <typeparam name="T">The type of the data object from which to initialize the <see cref="CoreConversationState"/> instance.</typeparam>
        /// <param name="data">The data object used to populate the properties of the new <see cref="CoreConversationState"/> instance.</param>
        /// <returns>A new instance of <see cref="CoreConversationState"/> populated with the given data.</returns>
        public static CoreConversationState Create<T>(T data) where T : class
        {
                return BaseEntity.Create<CoreConversationState, T>(data);
        }
}