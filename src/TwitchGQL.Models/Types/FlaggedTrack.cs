using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Information about the flagged track of copyrighted music.
    /// </summary>
    public class FlaggedTrack
    {
        /// <summary>
        /// Title of the album of the flagged track.
        /// </summary>
        [JsonPropertyName("albumTitle")]
        public string AlbumTitle { get; set; }

        /// <summary>
        /// The appeal for track's usage.
        /// </summary>
        [JsonPropertyName("appeal")]
        public FlaggedTrackAppeal Appeal { get; set; }

        /// <summary>
        /// ID of the flagged track.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Duration in seconds of the mute. Standard length is 360 (6 mins).
        /// This can be null if the flagged track was succesfully appealed.
        /// </summary>
        [JsonPropertyName("muteDurationSeconds")]
        public int MuteDurationSeconds { get; set; }

        /// <summary>
        /// Offset is how many seconds into the video the mute begins. 0 indicates the beginning of the video is muted.
        /// This can be null if the flagged track was succesfully appealed.
        /// </summary>
        [JsonPropertyName("muteOffsetSeconds")]
        public int MuteOffsetSeconds { get; set; }

        /// <summary>
        /// Performer of the flagged track.
        /// </summary>
        [JsonPropertyName("performer")]
        public string Performer { get; set; }

        /// <summary>
        /// Title of the flagged track.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}