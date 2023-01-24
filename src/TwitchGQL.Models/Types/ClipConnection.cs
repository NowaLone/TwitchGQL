using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A list of clips related to the subject.
    /// </summary>
    public class ClipConnection
    {
        /// <summary>
        /// The clips.
        /// </summary>
        [JsonPropertyName("edges")]
        public IEnumerable<ClipEdge> Edges { get; set; }

        /// <summary>
        /// Information about pagination in this connection.
        /// </summary>
        [JsonPropertyName("pageInfo")]
        public PageInfo PageInfo { get; set; }
    }
}