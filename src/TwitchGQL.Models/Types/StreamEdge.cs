using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Contains information about a Streams's relationship to a given page (connection), and the Stream itself.
    /// </summary>
    public class StreamEdge
    {
        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("cursor")]
        public string Cursor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("node")]
        public Stream Node { get; set; }

        /// <summary>
        /// Unique id per stream response item, used by clients to attribute displays/clicks to items.
        /// </summary>
        [JsonPropertyName("trackingID")]
        public string TrackingID { get; set; }
    }
}