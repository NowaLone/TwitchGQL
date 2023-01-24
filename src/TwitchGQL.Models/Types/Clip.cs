using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A recorded, replayable part of a live broadcast.
    /// </summary>
    public class Clip
    {
        /// <summary>
        /// The broadcast of the clip. This should only be used to fetch the ID of the broadcast.
        /// Because not all videos have broadcasts (e.g. uploads), not all clips will have a broadcast.
        /// </summary>
        [JsonPropertyName("broadcast")]
        public Broadcast Broadcast { get; set; }

        /// <summary>
        /// The broadcaster from which the clip originated.
        /// </summary>
        [JsonPropertyName("broadcaster")]
        public User broadcaster { get; set; }

        /// <summary>
        /// The curator's clip champ badge if it has been attained on the broadcaster's channel.
        /// This has been deprecated and will be always be null.
        /// </summary>
        [Obsolete("Clip Champ Badges are no longer being awarded")]
        [JsonPropertyName("champBadge")]
        public Badge ChampBadge { get; set; }

        /// <summary>
        /// The time when the clip was created.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Different video qualities are being created in the background.
        /// The creation state indicates when the source quality clip is playable
        /// and transcoding of the clip in other video qualities has begun.
        /// </summary>
        [JsonPropertyName("creationState")]
        public ClipCreationState CreationState { get; set; }

        /// <summary>
        /// The user who created the clip.
        /// </summary>
        [JsonPropertyName("curator")]
        public User Curator { get; set; }

        /// <summary>
        /// The duration of the clip, in seconds.
        /// </summary>
        [JsonPropertyName("durationSeconds")]
        public int DurationSeconds { get; set; }

        /// <summary>
        /// The URL used in the embed player.
        /// </summary>
        [JsonPropertyName("embedURL")]
        public string EmbedURL { get; set; }

        /// <summary>
        /// The game depicted in the clip.
        /// </summary>
        [JsonPropertyName("game")]
        public Game Game { get; set; }

        /// <summary>
        /// The clip's unique identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Whether or not the clip has been published.
        /// </summary>
        [JsonPropertyName("isPublished")]
        public bool IsPublished { get; set; }

        /// <summary>
        /// The language of the clip.
        /// </summary>
        [JsonPropertyName("language")]
        public Language Language { get; set; }

        /// <summary>
        /// The playback access token that determines whether the user can watch the clip.
        /// Fetched for both authed and unauthed users.
        /// </summary>
        [JsonPropertyName("playbackAccessToken")]
        public PlaybackAccessToken PlaybackAccessToken { get; set; }

        /// <summary>
        /// Metadata around the raw media.
        /// </summary>
        [JsonPropertyName("rawMedia")]
        public ClipRawMedia RawMedia { get; set; }

        /// <summary>
        /// The different quality options of this clip's raw media used for editing.
        /// </summary>
        [JsonPropertyName("rawVideoQualities")]
        public IEnumerable<ClipVideoQuality> RawVideoQualities { get; set; }

        /// <summary>
        /// The reactions associated with this clips.
        /// </summary>
        [JsonPropertyName("reactions")]
        public IEnumerator<Reaction> Reactions { get; set; }

        /// <summary>
        /// Lists of related clips based on different algorithms.
        /// </summary>
        [JsonPropertyName("relatedClips")]
        public ClipRelatedClips RelatedClips { get; set; }

        /// <summary>
        /// A URL-friendly identifier.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// A URL to a thumbnail image.
        /// Valid sizes are "86x45", "260x147", and "480x272".
        /// </summary>
        [JsonPropertyName("thumbnailURL")]
        public string ThumbnailURL { get; set; }

        /// <summary>
        /// The title of the clip.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// A URL to the clip's page.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// The video of the clip. Because not all broadcasts are archived, not all clips will
        /// have a video.
        /// </summary>
        [JsonPropertyName("video")]
        public Video Video { get; set; }

        /// <summary>
        /// The number of seconds into a VOD this clip was generated from.
        /// </summary>
        [JsonPropertyName("videoOffsetSeconds")]
        public int VideoOffsetSeconds { get; set; }

        /// <summary>
        /// The different quality options of this clip available for playback.
        /// The clip will first be available in the source video quality, indicated by when the
        /// clipCreationState is 'CREATED'. videoQualities will gradually be added to afterwards as
        /// more video quality options become playable.
        /// </summary>
        [JsonPropertyName("videoQualities")]
        public IEnumerable<ClipVideoQuality> VideoQualities { get; set; }

        /// <summary>
        /// The number of times this clip has been viewed.
        /// </summary>
        [JsonPropertyName("viewCount")]
        public int ViewCount { get; set; }
    }
}