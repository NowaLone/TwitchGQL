using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.FollowButton_FollowUser
{
    public class FollowUserPayload
    {
        [JsonPropertyName("follow")]
        public Follow Follow { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }
    }
}