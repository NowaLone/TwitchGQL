using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Exemption information for a specific resource restriction.
    /// </summary>
    public class ResourceRestrictionExemption
    {
        /// <summary>
        /// The list of description data a user make take to become exempt for the given restriction.
        /// </summary>
        [JsonPropertyName("actions")]
        public IEnumerable<ResourceRestrictionExemptionAction> Actions { get; set; }

        /// <summary>
        /// The time that the restriction is no longer active.
        /// </summary>
        [JsonPropertyName("endsAt")]
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// The keys needed for a given restriction.
        /// </summary>
        [JsonPropertyName("keys")]
        public IEnumerable<string> Keys { get; set; }

        /// <summary>
        /// The time that the restriction becomes active.
        /// </summary>
        [JsonPropertyName("startsAt")]
        public DateTime? StartsAt { get; set; }

        /// <summary>
        /// The type of exemption.
        /// </summary>
        [JsonPropertyName("type")]
        public ResourceRestrictionExemptionType Type { get; set; }
    }
}