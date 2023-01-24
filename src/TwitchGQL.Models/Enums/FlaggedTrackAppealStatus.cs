namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// The status of the track appeal.
    /// </summary>
    public enum FlaggedTrackAppealStatus
    {
        /// <summary>
        /// The track appeal has not yet been resolved.
        /// </summary>
        PENDING,

        /// <summary>
        /// The track appeal has a resolved at time.
        /// </summary>
        RESOLVED
    }
}