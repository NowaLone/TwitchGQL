using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// CheerInfo is the channel-specific bits/cheer settings and current state.
    /// </summary>
    public class CheerInfo
    {
        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}