using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A video bookmark.
    /// </summary>
    public class VideoBookmarkEdge
    {
        /// <summary>
        /// Uniquely identifies this clip's position in a connection.
        /// </summary>
        [JsonPropertyName("cursor")]
        public string Cursor { get; set; }

        /// <summary>
        /// The bookmark.
        /// </summary>
        [JsonPropertyName("node")]
        public VideoBookmark Node { get; set; }
    }
}