using System;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// A Game is often the subject of a Stream on Twitch.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// URL to a box art image. The image dimensions are specifiable via the <c>height</c> and <c>width</c> parameters.
        /// </summary>
        /// <remarks>
        ///  If <c>height</c> or <c>width</c> are not specified, the URL will contain the template strings <c>{height}</c> and/or <c>{width}</c> in their respective places.
        ///  </remarks>
        [JsonPropertyName("boxArtURL")]
        public Uri BoxArtURL { get; set; }

        /// <summary>
        /// The translated game name used for display purposes. Use name for tracking props or URLs.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The game's unique Twitch identifier. It is used to associate games with product offers.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the game. This string is untranslated. This field should only be used in limited occassions, like tracking and URLs. You should use displayName for all all game names shown to the users.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Get a page of live streams broadcasting this game. The languages param can be used to filter the streams. Otherwise all languages will be returned. The filters param contains additional metadata filters, for example {hearthstoneGameMode: "arena"}
        /// </summary>
        ///<remarks>
        /// The sort param can be used to change the default sorting, which sometimes is specific to specific games. The tags param are an array of tag ID as optional filters for streams. DEPRECATED field arguments: languages, requestID, sort, tags Use GameStreamOptions instead.
        ///</remarks>
        [JsonPropertyName("streams")]
        public StreamConnection Streams { get; set; }
    }
}