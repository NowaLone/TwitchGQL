namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// An enumeration on the different status strings returned by a clip status.
    /// </summary>
    public enum ClipCreationState
    {
        /// <summary>
        /// The creating status indicates that the source quality video is still
        /// undergoing processing and transcoding.
        /// </summary>
        CREATING,

        /// <summary>
        /// Clip has been successfully created in the source video quality.
        /// The field videoQualities will be gradually added to with other quality options.
        /// </summary>
        CREATED,

        /// <summary>
        /// Clip creation failed and will remain in this state.
        /// Possible errors can happen due to problems in downloading and slicing
        /// the source of the original video, clipping offline channels, transcoding, etc.
        /// </summary>
        FAILED
    }
}