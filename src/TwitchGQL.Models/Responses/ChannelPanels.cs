using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    /// <summary>
    ///
    /// </summary>
    public class ChannelPanels
    {
        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("currentUser")]
        public User CurrentUser { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}