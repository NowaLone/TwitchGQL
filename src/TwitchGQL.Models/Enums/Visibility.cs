namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// The user's shared availability while online.
    /// A value of ONLINE (typically called invisibility) additionally means that the user's activity will not be shared
    /// regardless of the isSharingActivity setting.
    /// </summary>
    /// <remarks>
    /// Should have been named UserOnlineVisibility.
    /// </remarks>
    public enum Visibility
    {
        ONLINE,
        AWAY,
        BUSY,
        OFFLINE,
    }
}