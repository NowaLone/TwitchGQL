using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A User's place on Twitch.
    /// </summary>
    public class Channel
    {
        /// <summary>
        /// The channel's unique identfier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Fetches most recent chat messages sent for the given channel.
        /// </summary>
        [JsonPropertyName("recentChatMessages")]
        public IEnumerable<Message> RecentChatMessages { get; set; }
    }
}