using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// <see cref="ClipRawMedia"/> describes metadata about the clip's raw media used in clip editing.
    /// </summary>
    public class ClipRawMedia
    {
        /// <summary>
        /// Default Offset is the seconds into the raw clip media the default clip begins at.
        /// </summary>
        [JsonPropertyName("defaultClipInitialOffset")]
        public float DefaultClipInitialOffset { get; set; }

        /// <summary>
        /// Total duration of the raw media.
        /// </summary>
        [JsonPropertyName("duration")]
        public float Duration { get; set; }

        /// <summary>
        /// Total number of frames displayed in the spritesheet film strip.
        /// </summary>
        [JsonPropertyName("filmStripFrames")]
        public int FilmStripFrames { get; set; }

        /// <summary>
        /// Seconds covered by each frame in the spritesheet film strip.
        /// </summary>
        [JsonPropertyName("filmStripSecondsPerFrame")]
        public int FilmStripSecondsPerFrame { get; set; }

        /// <summary>
        /// Height of the frames displayed.
        /// </summary>
        [JsonPropertyName("frameHeight")]
        public int FrameHeight { get; set; }

        /// <summary>
        /// Width of the frames displayed.
        /// </summary>
        [JsonPropertyName("frameWidth")]
        public int FrameWidth { get; set; }

        /// <summary>
        /// Spritesheet displayed to user for clip editing.
        /// </summary>
        [JsonPropertyName("spritesheetURL")]
        public string SpritesheetURL { get; set; }

        /// <summary>
        /// Status of the clip's raw media.
        /// </summary>
        [JsonPropertyName("status")]
        public ClipCreationState Status { get; set; }

        /// <summary>
        /// URL link to the video mp4 containing to upwards of 90 seconds of the raw video from which the clip can be created from.
        /// </summary>
        [JsonPropertyName("videoURL")]
        public string VideoURL { get; set; }
    }
}