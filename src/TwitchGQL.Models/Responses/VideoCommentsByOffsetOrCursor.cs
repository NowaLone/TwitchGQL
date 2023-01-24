using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    public class VideoCommentsByOffsetOrCursor
    {
        [JsonPropertyName("video")]
        public Video Video { get; set; }
    }
}