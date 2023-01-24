using System.Collections.Generic;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A restriction for a specific resource.
    /// </summary>
    public class ResourceRestriction
    {
        /// <summary>
        /// The list of exemptions for a given resource restriction.
        /// </summary>
        [JsonPropertyName("exemptions")]
        public IEnumerable<ResourceRestrictionExemption> Exemptions { get; set; }

        /// <summary>
        /// The list of options that were applied at time of creation for a given resource restriction.
        /// </summary>
        [JsonPropertyName("options")]
        public IEnumerable<ResourceRestrictionOption> Options { get; set; }

        /// <summary>
        /// The type of restriction on this resource.
        /// </summary>
        [JsonPropertyName("type")]
        public ResourceRestrictionType Type { get; set; }
    }
}