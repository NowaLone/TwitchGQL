using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.ViewerCardModLogsMessagesBySender
{
    public class PageInfo
    {
        [JsonPropertyName("hasNextPage")]
        public bool HasNextPage { get; set; }
    }
}