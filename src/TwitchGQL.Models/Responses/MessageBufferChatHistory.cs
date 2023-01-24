using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    public class MessageBufferChatHistory
    {
        [JsonPropertyName("channel")]
        public Channel Channel { get; set; }
    }
}