using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Interfaces
{
    /// <summary>
    /// Panel is information about a single info panel for a channel.
    /// </summary>
    public interface IPanel
    {
        /// <summary>
        /// id is a unique identifier for the panel.
        /// </summary>
        [JsonPropertyName("id")]
        string Id { get; set; }

        /// <summary>
        /// type is the kind of panel.
        /// </summary>
        [JsonPropertyName("type")]
        PanelType Type { get; set; }
    }
}