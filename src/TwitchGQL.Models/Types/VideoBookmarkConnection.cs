using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A paginated list of video bookmarks.
    /// </summary>
    public class VideoBookmarkConnection
    {
        /// <summary>
        /// The elements of the paginated list.
        /// </summary>
        [JsonPropertyName("edges")]
        public IEnumerable<VideoBookmarkEdge> Edges { get; set; }

        /// <summary>
        /// Error of the get video bookmarks request.
        /// </summary>
        [JsonPropertyName("error")]
        public VideoBookmarkConnectionError Error { get; set; }

        /// <summary>
        /// Information about this page.
        /// </summary>
        [JsonPropertyName("pageInfo")]
        public PageInfo PageInfo { get; set; }
    }
}