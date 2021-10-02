using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    public class FollowButton_UnfollowUser
    {
        [JsonPropertyName("unfollowUser")]
        public UnfollowUserPayload UnfollowUser { get; set; }
    }
}