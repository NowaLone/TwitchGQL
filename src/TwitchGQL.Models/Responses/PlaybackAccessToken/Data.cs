using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.PlaybackAccessToken
{
    public class Data
    {
        [JsonPropertyName("streamPlaybackAccessToken")]
        public PlaybackAccessToken StreamPlaybackAccessToken { get; set; }
    }
}