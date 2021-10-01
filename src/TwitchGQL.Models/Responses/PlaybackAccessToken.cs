using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses
{
    public class PlaybackAccessToken
    {
        [JsonPropertyName("streamPlaybackAccessToken")]
        public Types.PlaybackAccessToken StreamPlaybackAccessToken { get; set; }
    }
}