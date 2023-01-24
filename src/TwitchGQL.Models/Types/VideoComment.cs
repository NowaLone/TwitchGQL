using System;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Comment on a video.
    /// </summary>
    public class VideoComment
    {
        /// <summary>
        /// Author of the comment.
        /// </summary>
        [JsonPropertyName("commenter")]
        public User Commenter { get; set; }

        /// <summary>
        /// Position of the video where this comment was added.
        /// </summary>
        [JsonPropertyName("contentOffsetSeconds")]
        public int ContentOffsetSeconds { get; set; }

        /// <summary>
        /// The time the comment was created.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The comments's unique identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The message of the comment.
        /// </summary>
        [JsonPropertyName("message")]
        public VideoCommentMessage Message { get; set; }

        /// <summary>
        /// List of replies on this comment.
        /// </summary>
        [Obsolete("DEPRECATED.")]
        [JsonPropertyName("replies")]
        public VideoCommentConnection Replies { get; set; }

        /// <summary>
        /// Where the comment originated.
        /// </summary>
        [JsonPropertyName("source")]
        public VideoCommentSource? Source { get; set; }

        /// <summary>
        /// Current state of the comment.
        /// </summary>
        [JsonPropertyName("state")]
        public VideoCommentState? State { get; set; }

        /// <summary>
        /// The last time this comment was updated.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The video on which this comment was added.
        /// </summary>
        [JsonPropertyName("video")]
        public Video Video { get; set; }
    }
}