namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// List of possible video download statuses.
    /// </summary>
    public enum VideoDownloadStatus
    {
        /// <summary>
        /// The video download is created.
        /// </summary>
        CREATED,

        /// <summary>
        /// The video download is submitted.
        /// </summary>
        SUBMITTED,

        /// <summary>
        /// The video download is downloading.
        /// </summary>
        DOWNLOADING,

        /// <summary>
        /// The video download is transmuxing.
        /// </summary>
        TRANSMUXING,

        /// <summary>
        /// The video download failed to create.
        /// </summary>
        FAILED,

        /// <summary>
        /// The video download is completed.
        /// </summary>
        COMPLETE,

        /// <summary>
        /// The video download status is unknown.
        /// </summary>
        UNKNOWN
    }
}