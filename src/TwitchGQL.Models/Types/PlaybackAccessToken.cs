using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Access token that determines playback experience for a video.
    /// </summary>
    public class PlaybackAccessToken
    {
        /// <summary>
        /// The signature of the token.
        /// </summary>
        [JsonPropertyName("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// Token that encodes information about the user's access to a video.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}