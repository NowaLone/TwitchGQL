using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// The content of a user's message to a room.
    /// </summary>
    public class ModLogsMessageContent
    {
        /// <summary>
        /// Parsed list of fragments in the message, include emotes, mentions, and plaintext.
        /// </summary>
        [JsonPropertyName("fragments")]
        public IEnumerable<ModLogsMessageFragment> Fragments { get; set; }

        /// <summary>
        /// String representation of the user message.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}