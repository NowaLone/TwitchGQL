using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Communicates a user's status in chat.
    /// </summary>
    public class Badge
    {
        /// <summary>
        /// The badge's unique identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The identifier of the set which this badge belongs (e.g. "subscriber").
        /// </summary>
        [JsonPropertyName("setID")]
        public string SetID { get; set; }

        /// <summary>
        /// The badge's version (e.g. "1mo").
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}