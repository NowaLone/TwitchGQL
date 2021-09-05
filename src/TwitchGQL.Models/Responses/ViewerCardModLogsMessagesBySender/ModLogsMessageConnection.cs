using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.ViewerCardModLogsMessagesBySender
{
    public class ModLogsMessageConnection
    {
        [JsonPropertyName("edges")]
        public IEnumerable<ModLogsMessageEdge> Edges { get; set; }

        [JsonPropertyName("pageInfo")]
        public PageInfo PageInfo { get; set; }
    }
}