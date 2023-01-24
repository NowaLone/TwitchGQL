namespace TwitchGQL.Models.Enums
{
    public enum VideoStatus
    {
        /// <summary>
        /// The video is being recorded from a live broadcast.
        /// </summary>
        RECORDING,

        /// <summary>
        /// The video needs to be processed.
        /// </summary>
        UNPROCESSED,

        /// <summary>
        /// The upload job is ready to begin.
        /// </summary>
        CREATED,

        /// <summary>
        /// The video is being uploaded.
        /// </summary>
        UPLOADING,

        /// <summary>
        /// The video is being transcoded.
        /// </summary>
        PENDING_TRANSCODE,

        /// <summary>
        /// The video is currently transcoding.
        /// </summary>
        TRANSCODING,

        /// <summary>
        /// Something went wrong.
        /// </summary>
        FAILED,

        /// <summary>
        /// The video is ready to watch.
        /// </summary>
        RECORDED
    }
}