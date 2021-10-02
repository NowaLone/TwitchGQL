using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Subjective data on another User (user/channel) for the current user.
    /// </summary>
    public class UserSelfConnection
    {
        /// <summary>
        /// Ban status of the authenticated user with respect to this user's channel.
        /// </summary>
        [JsonPropertyName("banStatus")]
        public ChatRoomBanStatus BanStatus { get; set; }

        /// <summary>
        /// Whether or not the authenticated user can follow this user.
        /// </summary>
        [JsonPropertyName("canFollow")]
        public bool CanFollow { get; set; }

        /// <summary>
        /// A follower relationship between the authenticated user and another user. <see langword="null"/> if the relationship does not exist.
        /// </summary>
        [JsonPropertyName("follower")]
        public FollowerEdge Follower { get; set; }
    }
}