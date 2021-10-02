using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A live stream.
    /// </summary>
    public class Stream
    {
        /// <summary>
        /// The user who is broadcasting the live stream.
        /// </summary>
        [JsonPropertyName("broadcaster")]
        public User Broadcaster { get; set; }

        /// <summary>
        /// Information about the game being streamed.
        /// </summary>
        [JsonPropertyName("game")]
        public Game Game { get; set; }

        /// <summary>
        /// The stream's unique identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// A URL to a dynamically sized image. If either <c>height</c> or <c>width</c> are not given, a templated value will be present instead.
        /// </summary>
        [JsonPropertyName("previewImageURL")]
        public Uri PreviewImageURL { get; set; }

        /// <summary>
        /// Tags are used as a discovery and search mechanism for tags and tagged content. The tag data may not be updated immediately after streamers update their tags. Please use <see cref="User.Tags"/> instead if you want real time data from Graffiti. For example, you should use <see cref="<see cref="Stream.Tags"/>"/> for the channel page and the browse page, but use <see cref="User.Tags"/> for the dashboard.
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<Tag> Tags { get; set; }

        /// <summary>
        /// A user-defined title describing the stream.
        /// </summary>
        [Obsolete("Title field in Users has been deprecated. Use broadcaster.broadcastSettings.title instead")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// What type of stream this is (e.g. live, playlist, watch_party).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The number of viewers currently watching the stream.
        /// </summary>
        [JsonPropertyName("viewersCount")]
        public int ViewersCount { get; set; }
    }
}