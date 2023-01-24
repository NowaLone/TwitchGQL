using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Restrictions for viewing of a video. Resolves if a video is restricted, null otherwise.
    /// </summary>
    public class VideoRestriction
    {
        /// <summary>
        /// The product "short name" a user needs to purchase to view the video.
        /// </summary>
        [JsonPropertyName("productName")]
        public string ProductName { get; set; }

        /// <summary>
        /// The name of the product shown to users.
        /// </summary>
        [JsonPropertyName("productTitle")]
        public string ProductTitle { get; set; }

        /// <summary>
        /// The reason a video is restricted.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The type of restriction the video has.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}