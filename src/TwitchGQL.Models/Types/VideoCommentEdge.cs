using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Video comment edge with cursor and the comment node.
    /// </summary>
    public class VideoCommentEdge
    {
        [JsonPropertyName("cursor")]
        public string Cursor { get; set; }

        [JsonPropertyName("node")]
        public VideoComment Node { get; set; }
    }
}