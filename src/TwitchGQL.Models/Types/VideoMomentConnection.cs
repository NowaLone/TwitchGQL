using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A paginated list of video moments.
    /// </summary>
    public class VideoMomentConnection
    {
        /// <summary>
        /// The elements of the paginated list.
        /// </summary>
        [JsonPropertyName("edges")]
        public IEnumerable<VideoMomentEdge> Edges { get; set; }

        /// <summary>
        /// Information about this page.
        /// </summary>
        [JsonPropertyName("pageInfo")]
        public PageInfo PageInfo { get; set; }
    }
}