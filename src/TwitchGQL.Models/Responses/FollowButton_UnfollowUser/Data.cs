using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.FollowButton_UnfollowUser
{
    public class Data
    {
        [JsonPropertyName("unfollowUser")]
        public UnfollowUserPayload UnfollowUser { get; set; }
    }
}