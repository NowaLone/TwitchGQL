using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Video download information.
    /// </summary>
    public class VideoDownload
    {
        /// <summary>
        /// Status of the download process.
        /// </summary>
        [JsonPropertyName("status")]
        public VideoDownloadStatus Status { get; set; }

        /// <summary>
        /// Generated URL from which to download the video.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}