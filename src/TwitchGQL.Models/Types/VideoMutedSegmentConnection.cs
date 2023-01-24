using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A list of all sections of the video that are muted.
    /// If pagination is required at any point in the future, put edges and pageInfo
    /// in this type.
    /// </summary>
    public class VideoMutedSegmentConnection
    {
        /// <summary>
        /// No pagination functionality. All data returned in initial call.
        /// </summary>
        [JsonPropertyName("nodes")]
        public IEnumerable<VideoMutedSegment> Nodes { get; set; }
    }
}