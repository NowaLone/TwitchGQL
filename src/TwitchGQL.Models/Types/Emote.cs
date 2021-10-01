using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    ///
    /// </summary>
    public class Emote
    {
        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("emoteID")]
        public string EmoteID { get; set; }

        /// <summary>
        /// Identifies which set this emote belongs to.
        /// </summary>
        [JsonPropertyName("setID")]
        public string SetID { get; set; }

        /// <summary>
        /// The text token of the emote. For example, "KappaHD".
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}