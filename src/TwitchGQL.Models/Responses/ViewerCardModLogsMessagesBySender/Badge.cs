using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.ViewerCardModLogsMessagesBySender
{
    public class Badge
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("setID")]
        public string SetID { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}