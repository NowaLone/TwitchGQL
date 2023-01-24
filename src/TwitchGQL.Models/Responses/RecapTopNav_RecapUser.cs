using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    public class RecapTopNav_RecapUser
    {
        [JsonPropertyName("currentUser")]
        public User CurrentUser { get; set; }
    }
}