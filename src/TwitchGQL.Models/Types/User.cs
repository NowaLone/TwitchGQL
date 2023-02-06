using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Interfaces;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Twitch user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Badges that are displayed in chat during this user's broacasts or videos.
        /// </summary>
        [JsonPropertyName("broadcastBadges")]
        public IEnumerable<Badge> BroadcastBadges { get; set; }

        /// <summary>
        /// The channel which belongs to the user. This is still deprecated for previous uses.
        /// This should only be used for the multi-view experience.
        /// </summary>
        [JsonPropertyName("channel")]
        public Channel Channel { get; set; }

        /// <summary>
        /// Hex color of the user's name in chat, e.g. "#ccaa44".
        /// </summary>
        [JsonPropertyName("chatColor")]
        public string ChatColor { get; set; }

        /// <summary>
        /// cheer is the channel-specific cheer settings and current state. Returns <see langword="null"/> if cheering isn't enabled for this channel.
        /// </summary>
        [JsonPropertyName("cheer")]
        public CheerInfo Cheer { get; set; }

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
        /// panels is a list of <see cref="IPanel"/> objects with information related to this channel.
        /// </summary>
        [JsonPropertyName("panels")]
        public IEnumerable<IPanel> Panels { get; set; }

        /// <summary>
        /// The hex string for the user's primary creator color. Example: "FFFFFF".
        /// </summary>
        [JsonPropertyName("primaryColorHex")]
        public string PrimaryColorHex { get; set; }

        /// <summary>
        /// A URL to the user's profile image. Valid widths are 28, 50, 70, 96, 150, 300, and 600. The image height will be the same as the given width.
        /// </summary>
        [JsonPropertyName("profileImageURL")]
        public Uri ProfileImageURL { get; set; }

        /// <summary>
        /// The roles this user fulfills on Twitch.
        /// </summary>
        [JsonPropertyName("roles")]
        public UserRoles Roles { get; set; }

        /// <summary>
        /// The authenticated user's relationship with this user.
        /// </summary>
        [JsonPropertyName("self")]
        public UserSelfConnection Self { get; set; }

        /// <summary>
        /// The settings this user has on Twitch.
        /// </summary>
        public UserSettings Settings { get; set; }

        /// <summary>
        /// Tags are used as a discovery and search mechanism for channels. The tag data is from Graffiti directly. Graffiti is not designed to handle huge traffic. Please use <see cref="Stream.Tags"/> instead if know the stream is live and you can accept a 5 min delay in the data. For example, you should use <see cref="Stream.Tags"/> for the channel page and the browse page, but use <see cref="User.Tags"/> for the dashboard.
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<Tag> Tags { get; set; }
    }
}