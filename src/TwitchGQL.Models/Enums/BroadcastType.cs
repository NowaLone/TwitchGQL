namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// Describes from which source the video originated.
    /// </summary>
    /// <remarks>
    /// Should have been named <see cref="VideoBroadcastType"/>.
    /// </remarks>
    public enum BroadcastType
    {
        /// <summary>
        /// If the video is of a past broadcast, it's an <see cref="ARCHIVE"/>.
        /// </summary>
        ARCHIVE,

        /// <summary>
        /// When the video is a subsection of a past broadcast, it's a <see cref="HIGHLIGHT"/>.
        /// </summary>
        HIGHLIGHT,

        /// <summary>
        /// (Legacy) When the video is directly uploaded to Twitch via the upload tool, it's an <see cref="UPLOAD"/>.
        /// </summary>
        UPLOAD,

        /// <summary>
        /// When the video is directly uploaded to Twitch via the video manager, it's an <see cref="PREMIERE_UPLOAD"/>.
        /// </summary>
        PREMIERE_UPLOAD,

        /// <summary>
        /// When a video has been premiered on Twitch and is saved, it's a <see cref="PAST_PREMIERE"/>.
        /// </summary>
        PAST_PREMIERE
    }
}