using System;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A message from a user.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// The text and emoticon content of a message.
        /// </summary>
        [JsonPropertyName("content")]
        public MessageContent Content { get; set; }

        /// <summary>
        /// Time the message was deleted or purged. Null if the message is not deleted.
        /// </summary>
        [JsonPropertyName("deletedAt")]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// UUID of the message.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The message of the parent if this message is a reply.
        /// </summary>
        [JsonPropertyName("parentMessage")]
        public Message ParentMessage { get; set; }

        /// <summary>
        /// Replies to this message.
        /// </summary>
        [JsonPropertyName("replies")]
        public MessageReplyConnection Replies { get; set; }

        /// <summary>
        /// The user that sent the message.
        /// </summary>
        [JsonPropertyName("sender")]
        public User Sender { get; set; }

        /// <summary>
        /// Time the message was sent.
        /// </summary>
        [JsonPropertyName("sentAt")]
        public DateTime SentAt { get; set; }
    }
}