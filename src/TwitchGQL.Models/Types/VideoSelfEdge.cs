using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// The relationship between the authenticated user and a video.
    /// </summary>
    public class VideoSelfEdge
    {
        /// <summary>
        /// Can a user watch a restricted video.
        /// </summary>
        [JsonPropertyName("isRestricted")]
        public bool IsRestricted { get; set; }

        /// <summary>
        /// User's viewing history against a video.
        /// </summary>
        [JsonPropertyName("viewingHistory")]
        public VideoViewingHistory ViewingHistory { get; set; }
    }
}