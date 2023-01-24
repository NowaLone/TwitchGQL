using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    public class CoreActionsCurrentUser
    {
        [JsonPropertyName("currentUser")]
        public User CurrentUser { get; set; }
    }
}