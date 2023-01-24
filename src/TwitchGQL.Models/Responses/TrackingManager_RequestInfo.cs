using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses
{
    public class TrackingManager_RequestInfo
    {
        [JsonPropertyName("requestInfo")]
        public RequestInfo RequestInfo { get; set; }
    }
}