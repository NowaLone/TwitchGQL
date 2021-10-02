namespace TwitchGQL.Models.Requests.Enums
{
    /// <summary>
    /// Sort by.
    /// </summary>
    public enum Sort
    {
        /// <summary>
        /// Recommended For You.
        /// </summary>
        RELEVANCE,

        /// <summary>
        /// Viewers (High to Low).
        /// </summary>
        VIEWER_COUNT,

        /// <summary>
        /// Viewers (Low to High).
        /// </summary>
        VIEWER_COUNT_ASC,

        /// <summary>
        /// Recently Started.
        /// </summary>
        RECENT
    }
}