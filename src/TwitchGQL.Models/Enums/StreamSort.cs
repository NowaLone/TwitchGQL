namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// Possible ways of sorting collections of live streams.
    /// </summary>
    public enum StreamSort
    {
        /// <summary>
        /// Sort streams by number of concurrent viewers, descending (most viewers first). This is the default if StreamSort is not set or is a deprecated field.
        /// </summary>
        VIEWER_COUNT,

        /// <summary>
        /// Sort streams by number of concurrent viewers, ascending (least viewers first).
        /// </summary>
        VIEWER_COUNT_ASC,

        /// <summary>
        /// Sort by stream creation time, most recently started streams first.
        /// </summary>
        RECENT,

        /// <summary>
        /// Sort by relevance to the current user.
        /// </summary>
        RELEVANCE,

        /// <summary>
        /// Sort streams for the game "Counter-Strike: Global Offensive" by skill, descending (highest skill first). Other streams are included last, sorted at random. <b>Deprecated: this sort option no longer exists.</b>
        /// </summary>
        CSGO_SKILL,

        /// <summary>
        /// Sort streams for the game "League of Legends" by summoner rank, descending (highest rank first). Other streams are included last, sorted at random. <b>Deprecated: this sort option no longer exists.</b>
        /// </summary>
        LOL_SUMMONER_RANK
    }
}