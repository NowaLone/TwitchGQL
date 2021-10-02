using System;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Tag(s) are used as a discovery and search mechanism for tagged content, including Streams, Clips, and VODs.
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Timestamp of the creation of this tag.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// This tag's unique identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Whether this tag is auto generated.
        /// </summary>
        [JsonPropertyName("isAutomated")]
        public bool IsAutomated { get; set; }

        /// <summary>
        /// Whether this tag is a language tag.
        /// </summary>
        [JsonPropertyName("isLanguageTag")]
        public bool IsLanguageTag { get; set; }

        /// <summary>
        /// Localized description of this tag.
        /// </summary>
        [JsonPropertyName("localizedDescription")]
        public string LocalizedDescription { get; set; }

        /// <summary>
        /// Localized Name of this tag.
        /// </summary>
        [JsonPropertyName("localizedName")]
        public string LocalizedName { get; set; }

        /// <summary>
        /// Scope of the Tag.
        /// </summary>
        [JsonPropertyName("scope")]
        public TagScope Scope { get; set; }

        /// <summary>
        /// Official Name of this tag in English.
        /// </summary>
        [JsonPropertyName("tagName")]
        public string TagName { get; set; }
    }
}