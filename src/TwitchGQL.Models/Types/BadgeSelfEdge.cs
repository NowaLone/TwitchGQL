using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Further details about this object, subject to the user's permissions.
    /// </summary>
    public class BadgeSelfEdge
    {
        /// <summary>
        /// Whether the given badge should be visible publicly in the badge owner's chat card badge carousel.
        /// </summary>
        [JsonPropertyName("isVisibleInChatCard")]
        public bool IsVisibleInChatCard { get; set; }
    }
}