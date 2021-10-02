using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    ///
    /// </summary>
    public class FollowUserPayload
    {
        /// <summary>
        /// Used for user blocked errors.
        /// </summary>
        [JsonPropertyName("error")]
        public FollowUserError Error { get; set; }

        /// <summary>
        /// The new follow relationship.
        /// </summary>
        [JsonPropertyName("follow")]
        public Follow Follow { get; set; }
    }
}