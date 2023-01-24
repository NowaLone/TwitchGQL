using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A list of messages.
    /// </summary>
    public class MessageReplyConnection
    {
        /// <summary>
        /// Nodes is the list of replies to a message.
        /// </summary>
        [JsonPropertyName("nodes")]
        public IEnumerable<Message> Nodes { get; set; }

        /// <summary>
        /// The total number of replies to a message.
        /// </summary>
        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }
    }
}