using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.ViewerCardModLogsMessagesBySender
{
    public class ModLogsMessageFragment
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("content")]
        public Emote Content { get; set; }
    }
}