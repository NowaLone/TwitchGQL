using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    public class ViewerCardModLogsMessagesBySender
    {
        [JsonPropertyName("channel")]
        public User Channel { get; set; }
    }
}