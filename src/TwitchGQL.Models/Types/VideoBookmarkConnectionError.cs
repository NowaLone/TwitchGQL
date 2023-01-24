using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// <see cref="VideoBookmarkConnectionError"/> is the error associated with a getVideoBookmarks.
    /// </summary>
    public class VideoBookmarkConnectionError
    {
        /// <summary>
        /// The associated error code.
        /// </summary>
        [JsonPropertyName("code")]
        public VideoBookmarkConnectionErrorCode Code { get; set; }
    }
}