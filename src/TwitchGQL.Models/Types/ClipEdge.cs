using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    public class ClipEdge
    {
        /// <summary>
        /// Uniquely identifies this clip's position in a connection.
        /// </summary>
        [JsonPropertyName("cursor")]
        public string Cursor { get; set; }

        /// <summary>
        /// The clip.
        /// </summary>
        [JsonPropertyName("node")]
        public Clip Node { get; set; }
    }
}