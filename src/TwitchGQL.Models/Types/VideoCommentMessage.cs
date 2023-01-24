using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Represents the message of a comment.
    /// </summary>
    public class VideoCommentMessage
    {
        /// <summary>
        /// Parts of the message body with meta info.
        /// </summary>
        [JsonPropertyName("fragments")]
        public IEnumerable<VideoCommentMessageFragment> Fragments { get; set; }
        /// <summary>
        /// List of badges the comment author had selected for use at the time of the comment.
        /// </summary>
        [JsonPropertyName("userBadges")]
        public IEnumerable<Badge> UserBadges { get; set; }
        /// <summary>
        /// Text color preferences of comment's author.
        /// </summary>
        [JsonPropertyName("userColor")]
        public string UserColor { get; set; }
    }
}
