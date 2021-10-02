using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Twitch user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Hex color of the user's name in chat, e.g. "#ccaa44".
        /// </summary>
        [JsonPropertyName("chatColor")]
        public string ChatColor { get; set; }

        /// <summary>
        /// Lists the chat badges that should be displayed by the user's display name in features like chat and whispers. If a channelID is passed in, fetches the display badges that user will have in that channel's context.
        /// </summary>
        /// <remarks>
        /// Includes the following badges:
        /// <list type="bullet">
        /// <item>
        /// <term>global authority</term>
        /// <description>(staff/admin/global mod)</description>
        /// </item>
        /// <item>
        /// <term>channel authority</term>
        /// <description>(broadcaster/mod, if channelID is set)</description>
        /// </item>
        /// <item>
        /// <term>subscriber</term>
        /// <description>(if channelID is set)</description>
        /// </item>
        /// <item>
        /// <term>channel selected (bits) or global selected</term>
        /// <description>(prime, turbo, ...)</description>
        /// </item>
        /// </list>
        /// </remarks>
        [JsonPropertyName("displayBadges")]
        public IEnumerable<Badge> DisplayBadges { get; set; }

        /// <summary>
        /// A user-styled version of their login. For international users, this could be the user's login with localized characters.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The user's unique identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The user's standard alphanumeric Twitch name.
        /// </summary>
        [JsonPropertyName("login")]
        public string Login { get; set; }

        /// <summary>
        /// Returns a resolver to query different subsets of the moderation logs.
        /// </summary>
        [JsonPropertyName("modLogs")]
        public ModLogs ModLogs { get; set; }

        /// <summary>
        /// The authenticated user's relationship with this user.
        /// </summary>
        [JsonPropertyName("self")]
        public UserSelfConnection Self { get; set; }
    }
}