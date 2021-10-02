using System;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Data about the relationship between one User and a User they are following.
    /// </summary>
    public class Follow
    {
        /// <summary>
        /// Whether to disable notifications for this relationship.
        /// </summary>
        [JsonPropertyName("disableNotifications")]
        public bool? DisableNotifications { get; set; }

        /// <summary>
        /// Represents when this relationship was established.
        /// </summary>
        [JsonPropertyName("followedAt")]
        public DateTime? FollowedAt { get; set; }

        /// <summary>
        /// The user who is followed.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}