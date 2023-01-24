namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// Where a video comment originated.
    /// </summary>
    public enum VideoCommentSource
    {
        /// <summary>
        /// The comment originated from the live broadcast.
        /// </summary>
        CHAT,

        /// <summary>
        /// The comment was manually created by a commenter.
        /// </summary>
        COMMENT,

        /// <summary>
        /// The comment source is unknown.
        /// </summary>
        UNKNOWN
    }
}