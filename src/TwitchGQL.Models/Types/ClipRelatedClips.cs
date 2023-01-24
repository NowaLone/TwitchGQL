using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// There are different algorithms that return a different set of related clips.
    /// They only return up to 4 clips per list.
    /// </summary>
    public class ClipRelatedClips
    {
        /// <summary>
        /// Up-to 4  randomly selected, top viewed clips from the same broadcaster created within the last 4 days.
        /// </summary>
        [JsonPropertyName("broadcaster")]
        public IEnumerable<Clip> Broadcaster { get; set; }

        /// <summary>
        /// Up-to 10 clips, in order, combined from the other returned clip sets.
        /// Clips are included in the priority of similar, broadcaster, game, and then top.
        /// </summary>
        [JsonPropertyName("combined")]
        public IEnumerable<Clip> Combined { get; set; }

        /// <summary>
        /// Up-to 4  randomly selected, top viewed clips from the same user created within the last 4 days.
        /// </summary>
        [JsonPropertyName("curator")]
        public IEnumerable<Clip> Curator { get; set; }

        /// <summary>
        /// Up-to 4  randomly selected, top viewed clips from the same game created within the last 4 days.
        /// </summary>
        [JsonPropertyName("game")]
        public IEnumerable<Clip> Game { get; set; }

        /// <summary>
        /// Up-to 4 similar clips, based on the recommendations service.
        /// Deprecated: The underlying recommendations service that determined similar clips has been deprecated.
        /// </summary>
        [Obsolete("Similar clips relied on a deprecated backend service.")]
        [JsonPropertyName("similar")]
        public IEnumerable<Clip> Similar { get; set; }

        /// <summary>
        /// Up-to 4 randomly selected, top viewed clips created within the last 4 days.
        /// </summary>
        [JsonPropertyName("top")]
        public IEnumerable<Clip> Top { get; set; }
    }
}