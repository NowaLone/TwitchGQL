namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// The available types of lookups for a user query.
    /// </summary>
    public enum UserLookupType
    {
        /// <summary>
        /// Retrieves only active users without TOS/DMCA violations.
        /// </summary>
        ACTIVE,

        /// <summary>
        /// Includes suspended or deleted users in the results.
        /// </summary>
        ALL,
    }
}