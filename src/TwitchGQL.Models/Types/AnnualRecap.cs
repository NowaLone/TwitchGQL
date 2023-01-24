using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    public class AnnualRecap
    {
        [JsonPropertyName("creator")]
        public CreatorAnnualRecap Creator { get; set; }

        [JsonPropertyName("viewer")]
        public ViewerAnnualRecap Viewer { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }
    }
}