using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    /// <summary>
    ///
    /// </summary>
    public class Directory_DirectoryBanner
    {
        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("game")]
        public Game Game { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("currentUser")]
        public User CurrentUser { get; set; }
    }
}