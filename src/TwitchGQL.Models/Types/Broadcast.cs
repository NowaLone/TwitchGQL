using System;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A historical representation of a live stream.
    /// </summary>
    public class Broadcast
    {
        /// <summary>
        /// The game which was last streamed during the broadcast.
        /// </summary>
        [JsonPropertyName("game")]
        public Game Game { get; set; }

        /// <summary>
        /// The broadcast's unique identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// When the broadcast started.
        /// </summary>
        [JsonPropertyName("startedAt")]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// The title of the broadcast.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}