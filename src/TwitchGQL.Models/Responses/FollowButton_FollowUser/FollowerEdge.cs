using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.FollowButton_FollowUser
{
    public class FollowerEdge
    {
        [JsonPropertyName("disableNotifications")]
        public bool DisableNotifications { get; set; }
    }
}