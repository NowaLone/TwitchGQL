namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// An enumeration of the statuses of suggested segments.
    /// </summary>
    public enum SegmentsStatusType
    {
        /// <summary>
        /// The suggested segments have successfully been created.
        /// </summary>
        COMPLETED,

        /// <summary>
        /// There wasn't enough data to generate suggested segments.
        /// </summary>
        NOT_ENOUGH_DATA,

        /// <summary>
        /// The vod is currently being processed for suggested segments.
        /// </summary>
        IN_PROGRESS,

        /// <summary>
        /// The backend failed to generate suggested segments.
        /// </summary>
        FAILED
    }
}