using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// One parsed part of a message, which may be an emote, mention, or plaintext.
    /// </summary>
    public class ModLogsMessageFragment
    {
        /// <summary>
        /// Contains an emote or a mentioned user depending on the text of the fragment.
        /// </summary>
        [JsonPropertyName("content")]
        public Emote Content { get; set; }

        /// <summary>
        /// Plaintext representation of the fragment.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}