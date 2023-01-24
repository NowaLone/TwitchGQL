using System;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;
using TwitchGQL.Models.Unions;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A video moment represents either a point in time, or a duration of time,
    /// during which structured metadata is present.
    /// </summary>
    public class VideoMoment
    {
        /// <summary>
        /// channel the VOD belongs to.
        /// </summary>
        [JsonPropertyName("channel")]
        public User Channel { get; set; }

        /// <summary>
        /// Time at which the moment was created.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The displayable context of this moment (translated, where applicable). For
        /// instance, the stream marker comment, game name for game change, or “Pack opening”
        /// for Hearthstone VCA. Can be null.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A union of the fields that are specific to individual moments, such as Game Mode
        /// inside Hearthstone VCA data.
        /// </summary>
        [JsonPropertyName("details")]
        public IVideoMomentDetails Details { get; set; }

        /// <summary>
        /// The duration, in ms, that this moment is applicable, or zero if no duration.
        /// </summary>
        [JsonPropertyName("durationMilliseconds")]
        public int DurationMilliseconds { get; set; }

        /// <summary>
        /// ID of the moment.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Moments that cover a time range can also contain moments for that time range.
        /// </summary>
        [JsonPropertyName("moments")]
        public VideoMomentConnection Moments { get; set; }

        /// <summary>
        /// The time, in ms, after the start of the video when this moment occurs.
        /// </summary>
        [JsonPropertyName("positionMilliseconds")]
        public int PositionMilliseconds { get; set; }

        /// <summary>
        /// The additional displayable context of this moment (translated, where applicable).
        /// Can be null.
        /// </summary>
        [JsonPropertyName("subDescription")]
        public string SubDescription { get; set; }

        /// <summary>
        /// The url to the thumbnail for this moment.
        /// Can be null.
        /// </summary>
        [JsonPropertyName("thumbnailURL")]
        public string ThumbnailURL { get; set; }

        /// <summary>
        /// The underlying moment type.
        /// </summary>
        [JsonPropertyName("type")]
        public VideoMomentType Type { get; set; }

        /// <summary>
        /// The id of the video this moment is contained in.
        /// </summary>
        [JsonPropertyName("video")]
        public Video Video { get; set; }
    }
}