﻿using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    /// <summary>
    ///
    /// </summary>
    public class DirectoryPage_Game
    {
        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("game")]
        public Game Game { get; set; }
    }
}