using System.Collections.Generic;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Details about creating an automated highlight from this video.
    /// </summary>
    public class VideoSuggestedHighlight
    {
        /// <summary>
        /// Boolean for whether this set of suggested segments were addressed and dismissed.
        /// </summary>
        [JsonPropertyName("isDismissed")]
        public bool IsDismissed { get; set; }

        /// <summary>
        /// List of suggested video segments.
        /// </summary>
        [JsonPropertyName("segments")]
        public IEnumerable<VideoSuggestedSegment> Segments { get; set; }

        /// <summary>
        /// Status of the segments.
        /// </summary>
        [JsonPropertyName("status")]
        public SegmentsStatusType Status { get; set; }
    }
}