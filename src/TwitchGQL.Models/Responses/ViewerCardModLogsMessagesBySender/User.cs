using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.ViewerCardModLogsMessagesBySender
{
    public class User
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("chatColor")]
        public string ChatColor { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("displayBadges")]
        public IEnumerable<Badge> DisplayBadges { get; set; }

        [JsonPropertyName("modLogs")]
        public ModLogs ModLogs { get; set; }
    }
}