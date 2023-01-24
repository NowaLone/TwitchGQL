namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// <see cref="LeaderboardTimePeriodType"/> enumerates the various types of supported Leaderboards.
    /// </summary>
    public enum LeaderboardTimePeriodType
    {
        /// <summary>
        /// Daily leaderboards reset at midnight PT.
        /// </summary>
        DAY,

        /// <summary>
        /// Weekly leaderboards reset at midnight PT between Sunday and Monday.
        /// </summary>
        WEEK,

        /// <summary>
        /// Monthly leaderboards reset at midnight PT on the last day of the month.
        /// </summary>
        MONTH,

        /// <summary>
        /// All time leaderboards are cumulative back to when Bits launched in June of 2016.
        /// </summary>
        ALLTIME,
    }
}