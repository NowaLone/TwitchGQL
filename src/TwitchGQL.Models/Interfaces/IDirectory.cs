using System;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Interfaces
{
    /// <summary>
    /// A Directory is a container of content – Streams, Videos, and Clips – on Twitch.
    /// </summary>
    public interface IDirectory
    { /// <summary>
      /// URL to an avatar image. The image dimensions are specifiable via the <c>height</c> and <c>width</c> parameters.
      /// </summary>
      /// <remarks>
      /// If <c>height</c> or <c>width</c> are not specified, the URL will contain the template strings <c>{height}</c> and/or <c>{width}</c> in their respective places.
      /// </remarks>
        [JsonPropertyName("avatarURL")]
        Uri AvatarURL { get; set; }

        /// <summary>
        /// Number of broadcasters currently broadcasting in this directory.
        /// </summary>
        [JsonPropertyName("broadcastersCount")]
        int? BroadcastersCount { get; set; }

        /// <summary>
        /// URL to a cover image. The image dimensions are specifiable via the <c>height</c> and <c>width</c> parameters.
        /// </summary>
        /// <remarks>
        /// If <c>height</c> or <c>width</c> are not specified, the URL will contain the template strings <c>{height}</c> and/or <c>{width}</c> in their respective places.
        /// </remarks>
        [JsonPropertyName("coverURL")]
        Uri CoverURL { get; set; }

        /// <summary>
        /// The type of directory – community or game.
        /// </summary>
        [JsonPropertyName("directoryType")]
        DirectoryType? DirectoryType { get; set; }

        /// <summary>
        /// The name to display for the directory.
        /// </summary>
        [JsonPropertyName("displayName")]
        string DisplayName { get; set; }

        /// <summary>
        /// Number of users that follow this directory.
        /// </summary>
        [JsonPropertyName("followersCount")]
        int? FollowersCount { get; set; }

        /// <summary>
        /// The directory's unique Twitch identifier.
        /// </summary>
        [JsonPropertyName("id")]
        string Id { get; set; }

        /// <summary>
        /// The canonical name of the directory.
        /// </summary>
        [JsonPropertyName("name")]
        string Name { get; set; }

        /// <summary>
        /// Get a page of live streams broadcasting in this directory. If no language filters are provided all languages will be returned. Tags are an array of tag ID as optional filters for streams.
        /// </summary>
        [JsonPropertyName("streams")]
        StreamConnection Streams { get; set; }

        /// <summary>
        /// Number of viewers currently watching a stream which is in this directory.
        /// </summary>
        [JsonPropertyName("viewersCount")]
        int? ViewersCount { get; set; }
    }
}