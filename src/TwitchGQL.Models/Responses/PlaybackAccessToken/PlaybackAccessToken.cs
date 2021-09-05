using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.PlaybackAccessToken
{
    public class PlaybackAccessToken
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("signature")]
        public string Signature { get; set; }
    }
}