using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.ViewerCardModLogsMessagesBySender
{
    public class Data
    {
        [JsonPropertyName("channel")]
        public User Channel { get; set; }
    }
}