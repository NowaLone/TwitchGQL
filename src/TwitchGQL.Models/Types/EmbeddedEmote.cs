using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// <see cref="EmbeddedEmote"/> is an encoding format used to describe an emote embedded in a string of text.
    /// </summary>
    /// <example>body = "hey KappaHD"
    /// <see cref="From"/> = 4
    /// <see cref="To"/> = 10
    /// "KappaHD" will be replaced with the KappaHD emote image.
    /// </example>
    public class EmbeddedEmote
    {
        /// <summary>
        /// The emote's identifier, for example "115847" -> KappaHD.
        /// </summary>
        [JsonPropertyName("emoteID")]
        public string EmoteID { get; set; }

        /// <summary>
        /// <see cref="From"/> is the utf-8 index of the string where replacement starts.
        /// </summary>
        [JsonPropertyName("from")]
        public int From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// <see cref="SetID"/> is the identifier of the set this emote is in.
        /// </summary>
        [JsonPropertyName("setID")]
        public string SetID { get; set; }

        /// <summary>
        /// <see cref="To"/> is the index of the string where replacement ends.
        /// </summary>
        [JsonPropertyName("to")]
        public int To { get; set; }
    }
}