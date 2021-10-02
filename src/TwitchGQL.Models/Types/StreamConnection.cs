using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Paginated list of Streams.
    /// </summary>
    public class StreamConnection
    {
        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("edges")]
        public IEnumerable<StreamEdge> Edges { get; set; }

        /// <summary>
        /// Used for tracking.
        /// </summary>
        [JsonPropertyName("generationID")]
        public string GenerationID { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("pageInfo")]
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// Used for tracking.
        /// </summary>
        [JsonPropertyName("responseID")]
        public string ResponseID { get; set; }
    }
}