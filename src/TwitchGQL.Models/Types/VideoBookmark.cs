using System;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A video bookmark.
    /// </summary>
    public class VideoBookmark
    {
        /// <summary>
        /// channel the VOD belongs to.
        /// </summary>
        [JsonPropertyName("channel")]
        public User Channel { get; set; }

        /// <summary>
        /// Time at which the bookmark was created.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Description of the bookmark.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// ID of the bookmark.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Relative offset in the video.
        /// </summary>
        [JsonPropertyName("positionSeconds")]
        public int PositionSeconds { get; set; }

        /// <summary>
        /// user who created the bookmark.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}