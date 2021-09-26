using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.FollowButton_UnfollowUser
{
    public class UserSelfConnection
    {
        [JsonPropertyName("canFollow")]
        public bool CanFollow { get; set; }

        [JsonPropertyName("follower")]
        public FollowerEdge Follower { get; set; }
    }
}