using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.ViewerCardModLogsMessagesBySender
{
    public class ModLogs
    {
        [JsonPropertyName("messagesBySender")]
        public ModLogsMessageConnection MessagesBySender { get; set; }
    }
}