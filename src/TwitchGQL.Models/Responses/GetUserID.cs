using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    public class GetUserID
    {
        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}