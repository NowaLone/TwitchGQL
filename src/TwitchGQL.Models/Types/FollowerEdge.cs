using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// An element in a paginated list of followers. Contains metadata about the follower relationship between two users.
    /// </summary>
    public class FollowerEdge
    {
        /// <summary>
        /// Whether to disable notifications for this relationship.
        /// </summary>
        [JsonPropertyName("disableNotifications")]
        public bool DisableNotifications { get; set; }
    }
}