using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.ViewerCardModLogsMessagesBySender
{
    public class ModLogsMessageEdge
    {
        [JsonPropertyName("node")]
        public ModLogsMessage Node { get; set; }

        [JsonPropertyName("cursor")]
        public string Cursor { get; set; }
    }
}