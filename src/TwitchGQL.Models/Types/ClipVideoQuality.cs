using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// <see cref="ClipVideoQuality"/> describes metadata about an available playback source for a clip.
    /// </summary>
    public class ClipVideoQuality
    {
        /// <summary>
        /// Frame rate is the number of frames per second of this video.
        /// This value is a 64-bit float, with a default value of 30.0,
        /// and is used for supporting different playback speeds.
        /// Frame rate will be empty for raw media video qualities.
        /// </summary>
        [JsonPropertyName("frameRate")]
        public float FrameRate { get; set; }

        /// <summary>
        /// Clips can have multiple playback qualities via transcoding.
        /// Some examples of qualities include "1080", "720", "480", "360", and "source".
        /// </summary>
        [JsonPropertyName("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// The source video URL for the clip in this specific playback quality.
        /// </summary>
        [JsonPropertyName("sourceURL")]
        public string SourceURL { get; set; }
    }
}