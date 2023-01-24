using System;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Groups site-wide user settings together.
    /// </summary>
    public class UserSettings
    {
        /// <summary>
        /// Whether the user is whitelisted to host Prime Video watch parties. This
        /// takes precedence over user.watchPartiesRestrictions.
        /// </summary>
        [JsonPropertyName("canHostWatchParties")]
        public bool CanHostWatchParties { get; set; }

        /// <summary>
        /// The user's channel feed on/off switch.
        /// The channel feed is displayed if set to true and is
        /// hidden if set to false.
        /// </summary>
        [JsonPropertyName("channelFeedEnabled")]
        public bool ChannelFeedEnabled { get; set; }

        /// <summary>
        /// The cheer settings for a user, configured in their partner dashboard.
        /// </summary>
        //[JsonPropertyName("cheer")]
        //public CheerPartnerSettings Cheer { get; set; }

        /// <summary>
        /// Whether or not the user has a second authentication method configured.
        /// </summary>
        [JsonPropertyName("hasTwoFactorEnabled")]
        public bool? HasTwoFactorEnabled { get; set; }

        /// <summary>
        /// Whether or not the broadcaster is eligible for payout through Amazon retail revenue share.
        /// </summary>
        [Obsolete("Game sales discontinued")]
        [JsonPropertyName("isAmazonRetailRevShareEnabled")]
        public bool? IsAmazonRetailRevShareEnabled { get; set; }

        /// <summary>
        /// Whether or not the broadcaster is eligible for payout through twitch game commerce revenue share.
        /// </summary>
        [Obsolete("Game sales discontinued")]
        [JsonPropertyName("isCommerceRevShareEnabled")]
        public bool? IsCommerceRevShareEnabled { get; set; }

        /// <summary>
        /// Whether or not the user has requested that their registration date be hidden in the viewer card.
        /// </summary>
        [JsonPropertyName("isCreateDateHidden")]
        public bool? IsCreateDateHidden { get; set; }

        /// <summary>
        /// Whether or not the user has elected to be hidden from search results.
        /// </summary>
        [JsonPropertyName("isDirectoryHidden")]
        public bool? IsDirectoryHidden { get; set; }

        /// <summary>
        /// Whether or not the email was successfully reverted.
        /// </summary>
        [JsonPropertyName("isEmailRevertSuccess")]
        public bool? IsEmailRevertSuccess { get; set; }

        /// <summary>
        /// Whether the user's channel has rituals enabled.
        /// </summary>
        [JsonPropertyName("isRitualsEnabled")]
        public bool IsRitualsEnabled { get; set; }

        /// <summary>
        /// Whether the user's channel is whitelisted into the rituals experiment.
        /// </summary>
        [Obsolete("Rituals is whitelisted only for launch.")]
        [JsonPropertyName("isRitualsWhitelisted")]
        public bool IsRitualsWhitelisted { get; set; }

        /// <summary>
        /// The user's activity sharing setting.
        /// Activity is the part of a user's status that shows what they're currently playing, watching, or streaming.
        /// Requires the `user_presence_friends_read` scope.
        /// </summary>
        [JsonPropertyName("isSharingActivity")]
        public bool IsSharingActivity { get; set; }

        /// <summary>
        /// Partner settings related to leaderboards.
        /// </summary>
        [JsonPropertyName("leaderboard")]
        public LeaderboardSettings Leaderboard { get; set; }

        /// <summary>
        ///  The user's preferred language tag for displaying text content.
        /// </summary>
        [JsonPropertyName("preferredLanguageTag")]
        public LanguageTag PreferredLanguageTag { get; set; }

        /// <summary>
        ///The user's shared availability while online.
        /// A value of ONLINE (typically called "invisibility") additionally means that the user's activity will not be shared
        /// regardless of the isSharingActivity setting.
        /// Requires the `user_presence_friends_read` scope.
        /// </summary>
        [JsonPropertyName("visibility")]
        public Visibility Visibility { get; set; }
    }
}