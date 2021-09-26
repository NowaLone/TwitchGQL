using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.FollowButton_UnfollowUser
{
    public class UnfollowUserPayload
    {
        [JsonPropertyName("follow")]
        public Follow Follow { get; set; }
    }
}