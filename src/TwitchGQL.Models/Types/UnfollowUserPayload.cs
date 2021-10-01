using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    ///
    /// </summary>
    public class UnfollowUserPayload
    {
        /// <summary>
        /// The deleted follow relationship.
        /// </summary>
        [JsonPropertyName("follow")]
        public Follow Follow { get; set; }
    }
}