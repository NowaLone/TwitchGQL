using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    public class ReactionSelfConnection
    {
        /// <summary>
        /// Did the authenticated user react.
        /// </summary>
        [JsonPropertyName("hasReacted")]
        public bool HasReacted { get; set; }
    }
}