using System;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A message sent from a user to a room.
    /// </summary>
    public class ModLogsMessage
    {
        /// <summary>
        /// The text and emoticon content of a message.
        /// </summary>
        [JsonPropertyName("content")]
        public ModLogsMessageContent Content { get; set; }

        /// <summary>
        /// UUID of the message.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

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