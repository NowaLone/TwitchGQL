using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A video moment.
    /// </summary>
    public class VideoMomentEdge
    {
        /// <summary>
        /// Uniquely identifies this moment's position in the connection.
        /// </summary>
        [JsonPropertyName("cursor")]
        public string Cursor { get; set; }

        /// <summary>
        /// The moment.
        /// </summary>
        [JsonPropertyName("node")]
        public VideoMoment Node { get; set; }
    }
}