using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Paginated list of comments.
    /// </summary>
    public class VideoCommentConnection
    {
        [JsonPropertyName("edges")]
        public IEnumerable<VideoCommentEdge> Edges { get; set; }

        [JsonPropertyName("pageInfo")]
        public PageInfo PageInfo { get; set; }
    }
}