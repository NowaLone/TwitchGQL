namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// Enum for follow errors.
    /// </summary>
    public enum FollowUserErrorCode
    {
        /// <summary>
        /// Used when fromUser is being blocked by targetUser.
        /// </summary>
        FORBIDDEN,

        /// <summary>
        /// Used when user has reached their follow cap.
        /// </summary>
        TOO_MANY_FOLLOWS,
    }
}