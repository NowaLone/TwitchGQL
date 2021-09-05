using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.ViewerCardModLogsMessagesBySender
{
    public class ModLogsMessageContent
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("fragments")]
        public IEnumerable<ModLogsMessageFragment> Fragments { get; set; }
    }
}