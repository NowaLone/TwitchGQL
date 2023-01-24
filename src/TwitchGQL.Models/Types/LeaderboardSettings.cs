using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Partner dashboard settings for the bits cheering and sub gifting leaderboards.
    /// </summary>
    public class LeaderboardSettings
    {
        /// <summary>
        /// The default leaderboard the user wants to show.
        /// </summary>
        [JsonPropertyName("defaultLeaderboard")]
        public LeaderboardType DefaultLeaderboard { get; set; }
        /// <summary>
        /// Flag that is true if the user has bits cheering leaderboards turned on.
        /// </summary>
        [JsonPropertyName("isCheerEnabled")]
        public bool IsCheerEnabled { get; set; }
        /// <summary>
        /// Flag that is true if the user has sub gifting leaderboards turned on.
        /// </summary>
        [JsonPropertyName("isSubGiftEnabled")]
        public bool IsSubGiftEnabled { get; set; }
        /// <summary>
        /// The time period the user wants the leaderboard to be displayed as.
        /// </summary>
        [JsonPropertyName("timePeriod")]
        public LeaderboardTimePeriodType TimePeriod { get; set; }
    }
}