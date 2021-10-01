using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Information to communicate to the user about an error state.
    /// </summary>
    public class FollowUserError
    {
        /// <summary>
        /// Error code.
        /// </summary>
        [JsonPropertyName("code")]
        public FollowUserErrorCode Code { get; set; }
    }
}