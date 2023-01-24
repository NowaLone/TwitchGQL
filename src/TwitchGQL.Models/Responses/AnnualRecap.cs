using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    public class AnnualRecap
    {
        [JsonPropertyName("currentUser")]
        public User CurrentUser { get; set; }

        [JsonPropertyName("annualRecap")]
        public Types.AnnualRecap annualRecap { get; set; }
    }
}