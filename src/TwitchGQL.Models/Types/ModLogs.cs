using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// An interface to query subsets of the moderation logs information for a given channel.
    /// </summary>
    public class ModLogs
    {
        /// <summary>
        /// The chat history for an specified user on a given channel.
        /// </summary>
        [JsonPropertyName("messagesBySender")]
        public ModLogsMessageConnection MessagesBySender { get; set; }
    }
}