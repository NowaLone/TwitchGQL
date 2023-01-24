using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Description data for clients to get for user actions to get exempt.
    /// </summary>
    public class ResourceRestrictionExemptionAction
    {
        /// <summary>
        /// Name of the action need. e.g. Ticket Product short name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The human readable title of the restriction.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}