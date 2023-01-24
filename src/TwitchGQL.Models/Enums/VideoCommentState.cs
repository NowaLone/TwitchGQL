namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// Represents the state of a video comment.
    /// </summary>
    public enum VideoCommentState
    {
        /// <summary>
        /// The comment is published.
        /// </summary>
        PUBLISHED,

        /// <summary>
        /// The comment was manually unpublished by a mod or the channel owner.
        /// </summary>
        UNPUBLISHED,

        /// <summary>
        /// The comment was automatically flagged for review (AutoMod).
        /// </summary>
        PENDING_REVIEW,

        /// <summary>
        /// The comment is possibly spam and has to be reviewed by a moderator.
        /// </summary>
        PENDING_REVIEW_SPAM,

        /// <summary>
        /// The comment has been soft-deleted.
        /// </summary>
        DELETED
    }
}