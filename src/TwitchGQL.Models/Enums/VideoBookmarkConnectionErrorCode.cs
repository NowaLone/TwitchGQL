namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// <see cref="VideoBookmarkConnectionErrorCode"/> are the possible errors that this query returns.
    /// </summary>
    public enum VideoBookmarkConnectionErrorCode
    {
        /// <summary>
        /// An unexpected internal server error occurred.
        /// </summary>
        INTERNAL_SERVER_ERROR,

        /// <summary>
        /// The user is unauthorized to fetch bookmarks for the channel.
        /// </summary>
        USER_UNAUTHORIZED
    }
}