using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Information for one suggested video segment.
    /// </summary>
    public class VideoSuggestedSegment
    {
        /// <summary>
        /// Ending time of the suggested segment in milliseconds.
        /// </summary>
        [JsonPropertyName("endMS")]
        public int EndMS { get; set; }

        /// <summary>
        /// Starting time of the suggested segment in milliseconds.
        /// </summary>
        [JsonPropertyName("startMS")]
        public int StartMS { get; set; }
    }
}