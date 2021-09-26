using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.FollowButton_FollowUser
{
    public class Data
    {
        [JsonPropertyName("followUser")]
        public FollowUserPayload FollowUser { get; set; }
    }
}