using System.Collections.Generic;
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
        /// Lists the chat badges that should be displayed by the user's display name in
        /// features on a particular user's channel (i.e. chat, feeds).
        /// </summary>
        /// <remarks>
        /// Includes the following badges:
        /// <list type="bullet">
        ///     <item>
        ///         <description>global authority (staff/admin/global mod)</description>
        ///     </item>
        ///     <item>
        ///         <description>channel authority (broadcaster/mod)</description>
        ///     </item>
        ///     <item>
        ///         <description>subscriber</description>
        ///     </item>
        ///     <item>
        ///         <description>channel selected (bits) or global selected (prime, turbo, ...)</description>
        ///     </item>
        /// </list>
        /// </remarks>
        [JsonPropertyName("displayBadges")]
        public IEnumerable<Badge> DisplayBadges { get; set; }

        /// <summary>
        /// A follower relationship between the authenticated user and another user. <see langword="null"/> if the relationship does not exist.
        /// </summary>
        [JsonPropertyName("follower")]
        public FollowerEdge Follower { get; set; }

        /// <summary>
        /// The badge the authenticated user selected for use on another user's streams and videos.
        /// </summary>
        [JsonPropertyName("selectedBadge")]
        public Badge SelectedBadge { get; set; }
    }
}