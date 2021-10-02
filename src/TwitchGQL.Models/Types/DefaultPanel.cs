using System;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;
using TwitchGQL.Models.Interfaces;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// DefaultPanel is the normal panel type that displays text and images.
    /// </summary>
    public class DefaultPanel: IPanel
    {
        /// <summary>
        /// description is markdown-formatted text to be displayed below the title and image. If the panel doesn't have a description this will be <see langword="null"/>.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// id is a unique identifier for the panel.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// imageURL is a URL to an image to be displayed at the top of the panel (but below the header). If the panel doesn't use an image this will be <see langword="null"/>.
        /// </summary>
        [JsonPropertyName("imageURL")]
        public Uri ImageURL { get; set; }

        /// <summary>
        /// linkURL is the URL to navigate to when a user clicks on the image. If the panel's image doesn't link anywhere this will be <see langword="null"/>.
        /// </summary>
        [JsonPropertyName("linkURL")]
        public Uri LinkURL { get; set; }

        /// <summary>
        /// title is the header text to display in the panel. If the panel doesn't have a title this will return <see langword="null"/>.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// type is <see cref="PanelType.DEFAULT"/>.
        /// </summary>
        [JsonPropertyName("type")]
        public PanelType Type { get; set; }
    }
}