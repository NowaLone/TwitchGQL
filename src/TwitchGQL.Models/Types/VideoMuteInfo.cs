using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Details about automatic mutes applied to this video.
    /// </summary>
    public class VideoMuteInfo
    {
        /// <summary>
        /// List of segments muted.
        /// </summary>
        [JsonPropertyName("mutedSegmentConnection")]
        public VideoMutedSegmentConnection MutedSegmentConnection { get; set; }

        /// <summary>
        /// List of tracks that are flagged for copyrighted music.
        /// </summary>
        [JsonPropertyName("tracks")]
        public IEnumerable<FlaggedTrack> Tracks { get; set; }
    }
}