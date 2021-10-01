using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Paginated list of messages from a single sender in a channel.
    /// </summary>
    public class ModLogsMessageConnection
    {
        /// <summary>
        /// The elements of the list.
        /// </summary>
        [JsonPropertyName("edges")]
        public IEnumerable<ModLogsMessageEdge> Edges { get; set; }

        /// <summary>
        /// The partial count of messages (up to 1000). <see langword="null"/> if <b>includeMessageCount</b> was not set when the query was requested.
        /// </summary>
        [JsonPropertyName("messageCount")]
        public int? MessageCount { get; set; }

        /// <summary>
        /// Information about this page.
        /// </summary>
        [JsonPropertyName("pageInfo")]
        public PageInfo PageInfo { get; set; }
    }
}