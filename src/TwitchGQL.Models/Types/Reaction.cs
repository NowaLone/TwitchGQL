using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    public class Reaction
    {
        /// <summary>
        /// count of users that reacted with a particular Emote.
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// The Emote associated with the Reaction.
        /// </summary>
        [JsonPropertyName("emote")]
        public Emote Emote { get; set; }

        /// <summary>
        /// The authenticated user's relationship with this reaction.
        /// </summary>
        [JsonPropertyName("self")]
        public ReactionSelfConnection Self { get; set; }
    }
}