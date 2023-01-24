using System;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// User's viewing history against a video. All fields are null if no viewing history is available.
    /// </summary>
    public class VideoViewingHistory
    {
        /// <summary>
        /// Position in seconds since the start of the video.
        /// </summary>
        [JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// When the viewing history was last updated.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
    }
}