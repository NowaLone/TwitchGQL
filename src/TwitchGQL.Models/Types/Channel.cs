using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A User's place on Twitch.
    /// </summary>
    public class Channel
    {
        /// <summary>
        /// The channel's unique identfier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}