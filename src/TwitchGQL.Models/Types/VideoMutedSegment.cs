using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Information about one contiguous muted portion of video.
    /// </summary>
    public class VideoMutedSegment
    {
        /// <summary>
        /// Duration in seconds of the mute. Standard length is 360 (6 mins).
        /// </summary>
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Offset is how many seconds into the video the mute begins. 0 indicates the beginning of the video is muted.
        /// </summary>
        [JsonPropertyName("offset")]
        public int Offset { get; set; }
    }
}