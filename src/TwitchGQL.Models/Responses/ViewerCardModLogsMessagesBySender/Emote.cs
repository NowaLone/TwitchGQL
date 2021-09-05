using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.ViewerCardModLogsMessagesBySender
{
    public class Emote
    {
        [JsonPropertyName("emoteID")]
        public string EmoteID { get; set; }

        [JsonPropertyName("setID")]
        public string SetID { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}