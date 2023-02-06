using System;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Communicates a user's status in chat.
    /// </summary>
    public class Badge
    {
        /// <summary>
        /// Identifies an action to trigger when this badge is clicked.
        /// </summary>
        [Obsolete("Should use onClickAction instead")]
        [JsonPropertyName("clickAction")]
        public BadgeClickAction? ClickAction { get; set; }

        /// <summary>
        /// The URL to redirect to if the badge's onClickAction is VISIT_URL.
        /// </summary>
        [JsonPropertyName("clickURL")]
        public Uri ClickURL { get; set; }

        /// <summary>
        /// A localized, human-friendly description of the badge.
        /// Defaults to English if no translation exists for the requested locale.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The badge's unique identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("image1x")]
        public Uri Image1x { get; set; }

        [JsonPropertyName("image2x")]
        public Uri Image2x { get; set; }

        [JsonPropertyName("image4x")]
        public Uri Image4x { get; set; }

        /// <summary>
        /// A URL to the badge's image.
        /// </summary>
        [Obsolete]
        [JsonPropertyName("imageURL")]
        public Uri ImageURL { get; set; }

        /// <summary>
        /// Identifies an action to trigger when this badge is clicked.
        /// </summary>
        [JsonPropertyName("onClickAction")]
        public BadgeClickAction? OnClickAction { get; set; }

        /// <summary>
        /// Information about the user's relationship to this badge.
        /// </summary>
        [JsonPropertyName("self")]
        public BadgeSelfEdge Self { get; set; }

        /// <summary>
        /// The identifier of the set which this badge belongs (e.g. "subscriber").
        /// </summary>
        [JsonPropertyName("setID")]
        public string SetID { get; set; }

        /// <summary>
        /// A localized, human-friendly title for the badge.
        /// Defaults to English if no translation exists for the requested locale.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// The badge's associated broadcaster.
        /// Returns null if this is a global badge.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; }

        /// <summary>
        /// The badge's version (e.g. "1mo").
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}