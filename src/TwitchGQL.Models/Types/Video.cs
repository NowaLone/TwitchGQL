using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    ///
    /// </summary>
    public class Video
    {
        /// <summary>
        /// A link to an image which contains an animated preview of the video.
        /// </summary>
        [JsonPropertyName("animatedPreviewURL")]
        public string AnimatedPreviewURL { get; set; }

        /// <summary>
        /// A list of bookmarks for this video.
        /// </summary>
        [JsonPropertyName("bookmarks")]
        public VideoBookmarkConnection Bookmarks { get; set; }

        /// <summary>
        /// The type of broadcast the video originated from.
        /// </summary>
        [JsonPropertyName("broadcastType")]
        public BroadcastType? BroadcastType { get; set; }

        /// <summary>
        /// A paginated list of clips for this video.
        /// When criteria is not specified, the default values are used.
        /// </summary>
        [JsonPropertyName("clips")]
        public ClipConnection Clips { get; set; }

        /// <summary>
        /// A paginated list of comments against this video.
        /// </summary>
        [JsonPropertyName("comments")]
        public VideoCommentConnection Comments { get; set; }

        /// <summary>
        /// A list of tags describing the video.
        /// </summary>
        [JsonPropertyName("contentTags")]
        public IEnumerable<Tag> ContentTags { get; set; }

        /// <summary>
        /// The time the video metadata record was created.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The user who created this video.
        /// This will be either the broadcaster or one of their editors.
        /// </summary>
        [JsonPropertyName("creator")]
        public User Creator { get; set; }

        /// <summary>
        /// NOTE: named `deleteAt` in Vinyl.
        /// </summary>
        [JsonPropertyName("deletedAt")]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        ///  A description of the video, formatted in markdown.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Download information of the video. NOTE: Request this field only when a user is requesting a download
        /// since it will go through a process to generate a download URL on the backend.
        /// </summary>
        [JsonPropertyName("download")]
        public VideoDownload Download { get; set; }

        /// <summary>
        /// The length of the video.
        /// </summary>
        [Obsolete("Use length instead, as it's easier to parse.")]
        [JsonPropertyName("duration")]
        public Duration Duration { get; set; }

        /// <summary>
        /// The game the video is depicting.
        /// </summary>
        [JsonPropertyName("game")]
        public Game Game { get; set; }

        /// <summary>
        /// The video's identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Whether the video has been soft deleted.
        /// </summary>
        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Which language the video is in.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// The length of the video, as an int, in seconds.
        /// </summary>
        [JsonPropertyName("lengthSeconds")]
        public int? LengthSeconds { get; set; }

        /// <summary>
        /// A list of moments for this video.
        /// </summary>
        [JsonPropertyName("moments")]
        public VideoMomentConnection Moments { get; set; }

        /// <summary>
        /// Publicly available muted segment info, detailing which parts of the video
        /// have had audio removed.
        /// </summary>
        [JsonPropertyName("muteInfo")]
        public VideoMuteInfo MuteInfo { get; set; }

        /// <summary>
        /// For highlights, the number of seconds offset from the beginning of the past broadcast the highlight starts.
        /// For past broadcasts and uploads, this means nothing.
        /// </summary>
        [JsonPropertyName("offsetSeconds")]
        public int? OffsetSeconds { get; set; }

        /// <summary>
        /// The owner of the video.
        /// </summary>
        [JsonPropertyName("owner")]
        public User Owner { get; set; }

        /// <summary>
        /// The playback access token that determines whether the user can watch the video.
        /// Fetched for both authed and unauthed users.
        /// </summary>
        [JsonPropertyName("playbackAccessToken")]
        public PlaybackAccessToken PlaybackAccessToken { get; set; }

        /// <summary>
        /// The URL to the thumbnail which should be displayed for the video.
        /// If either `height` or `width` are not given, a templated value (i.e.
        /// `{height}`, `{width}`) will be present in the URL instead.
        /// </summary>
        [JsonPropertyName("previewThumbnailURL")]
        public string PreviewThumbnailURL { get; set; }

        /// <summary>
        /// The time when the archive/highlight/upload was first ever available to public,
        /// even if it is not currently public.
        /// </summary>
        [JsonPropertyName("publishedAt")]
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The reactions associated with this video.
        /// </summary>
        [JsonPropertyName("reactions")]
        public IEnumerable<Reaction> Reactions { get; set; }

        /// <summary>
        /// The time the video was recorded.
        /// </summary>
        [JsonPropertyName("recordedAt")]
        public DateTime? RecordedAt { get; set; }

        /// <summary>
        /// The reason a video is restricted if the given video is a restricted video.
        /// For a video that is not restricted, this field can be null.
        /// </summary>
        [JsonPropertyName("resourceRestriction")]
        public ResourceRestriction ResourceRestriction { get; set; }

        /// <summary>
        /// The reason a video is restricted if the given video is a restricted video.
        /// For a video that is not restricted, this field can be null.
        /// </summary>
        [Obsolete("Restriction will be moved over to resourceRestriction instead")]
        [JsonPropertyName("restriction")]
        public VideoRestriction Restriction { get; set; }

        /// <summary>
        /// Either PRIVATE or PUBLIC.
        /// </summary>
        [JsonPropertyName("scope")]
        public VideoPrivacyScope? Scope { get; set; }

        /// <summary>
        /// A link to a sprite sheet image made up of preview thumbnails when seeking the video timeline.
        /// </summary>
        [JsonPropertyName("seekPreviewsURL")]
        public string SeekPreviewsURL { get; set; }

        /// <summary>
        /// The authenticated user's relationship with this video.
        /// </summary>
        [JsonPropertyName("self")]
        public VideoSelfEdge Self { get; set; }

        /// <summary>
        /// When broadcastType is:
        /// - ARCHIVE: status goes from RECORDING to RECORDED.
        /// - HIGHLIGHT: status goes from UNPROCESSED to RECORDED.
        /// - UPLOAD: status goes from CREATED to UPLOADING, to PENDING_TRANSCODE, to RECORDED, or FAILED if anything goes wrong.
        /// - PREMIERE_UPLOAD: status goes from CREATED to UPLOADING, to
        /// PENDING_TRANSCODE, to RECORDED, or FAILED if anything goes wrong for this
        /// legacy broadcast type.
        /// - PAST_PREMIERE: status goes from RECORDING to RECORDED for this legacy broadcast type.
        /// </summary>
        [JsonPropertyName("status")]
        public VideoStatus? Status { get; set; }

        /// <summary>
        /// The suggested details for creating an automated highlight from this video.
        /// </summary>
        [JsonPropertyName("suggestedHighlight")]
        public VideoSuggestedHighlight SuggestedHighlight { get; set; }

        /// <summary>
        /// An array of tags describing the video. This field will be deprecated soon. Please use `Video.contentTag` instead.
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// A list of thumbnail URLs for the video, ordered by descending priority.
        /// Owners can insert custom thumbnails into this list.
        /// If either `height` or `width` are not given, a templated value (i.e.
        /// `{height}`, `{width}`) will be present in the URL instead.
        /// </summary>
        [JsonPropertyName("thumbnailURLs")]
        public IEnumerable<string> ThumbnailURLs { get; set; }

        /// <summary>
        /// The title of the video.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// A paginated list of clips featuring this vod that is, by default, ordered by view count descending.
        /// When criteria is not specified, the default values are used.
        /// </summary>
        [JsonPropertyName("topClips")]
        public ClipConnection TopClips { get; set; }

        /// <summary>
        /// The most recent time the video data was updated.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The numer of views this video has. Can be delayed by up to 15 minutes.
        /// </summary>
        [JsonPropertyName("viewCount")]
        public int? ViewCount { get; set; }

        /// <summary>
        /// For a scheduled video, the time when the video will be made available to the
        /// public (the time when the scope will be automatically set to "public").
        /// For a video that is public or not scheduled, is null.
        /// </summary>
        [JsonPropertyName("viewableAt")]
        public DateTime? ViewableAt { get; set; }
    }
}