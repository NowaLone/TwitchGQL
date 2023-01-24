using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Represents a part of the message body with meta info.
    /// </summary>
    public class VideoCommentMessageFragment
    {
        /// <summary>
        /// Embedded emote info.
        /// </summary>
        [JsonPropertyName("emote")]
        public EmbeddedEmote Emote { get; set; }
        /// <summary>
        /// User which was mentioned.
        /// </summary>
        [JsonPropertyName("mention")]
        public User Mention { get; set; }
        /// <summary>
        /// Raw text of the comment.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}