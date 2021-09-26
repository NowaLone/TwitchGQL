using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.FollowButton_UnfollowUser
{
    public class FollowerEdge
    {
        [JsonPropertyName("disableNotifications")]
        public bool DisableNotifications { get; set; }
    }
}