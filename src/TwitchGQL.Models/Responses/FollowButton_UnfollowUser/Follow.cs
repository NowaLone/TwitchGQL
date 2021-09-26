using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.FollowButton_UnfollowUser
{
    public class Follow
    {
        [JsonPropertyName("disableNotifications")]
        public bool DisableNotifications { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}