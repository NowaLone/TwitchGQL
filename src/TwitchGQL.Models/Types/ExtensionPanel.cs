using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;
using TwitchGQL.Models.Interfaces;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// ExtensionPanel is a placeholder in the panel list for arbitrary iframed content.
    /// </summary>
    public class ExtensionPanel : IPanel
    {
        /// <summary>
        /// id is a unique identifier for the panel.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// slotID is an identifier to map extensions content from <see cref="User.Extensions"/> to the proper place in the <see cref="User.Panels"/> list.
        /// </summary>
        [JsonPropertyName("slotID")]
        public string SlotID { get; set; }

        /// <summary>
        /// type is <see cref="PanelType.EXTENSION"/>.
        /// </summary>
        [JsonPropertyName("type")]
        public PanelType Type { get; set; }
    }
}