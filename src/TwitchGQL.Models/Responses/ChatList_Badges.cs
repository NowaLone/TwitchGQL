using System.Collections.Generic;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    public class ChatList_Badges
    {
        [JsonPropertyName("badges")]
        public IEnumerable<Badge> Badges { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}