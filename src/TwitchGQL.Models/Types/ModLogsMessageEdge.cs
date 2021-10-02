using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Element in a list of messages.
    /// </summary>
    public class ModLogsMessageEdge
    {
        /// <summary>
        /// Opaque cursor describing this edge's position in the paginated list.
        /// </summary>
        [JsonPropertyName("cursor")]
        public string Cursor { get; set; }

        /// <summary>
        /// The message or targeted moderation action.
        /// </summary>
        [JsonPropertyName("node")]
        public ModLogsMessage Node { get; set; }
    }
}