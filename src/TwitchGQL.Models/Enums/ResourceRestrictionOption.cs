namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// An enumeration of the different restriction options.
    /// </summary>
    public enum ResourceRestrictionOption
    {
        /// <summary>
        /// Allows users holding the channel VIP role to access the resource.
        /// </summary>
        ALLOW_CHANNEL_VIP,

        /// <summary>
        /// Allows users holding the channel moderator role to access the resource.
        /// </summary>
        ALLOW_CHANNEL_MODERATOR,

        /// <summary>
        /// Allows only users with tier 3 subscriptions to access the resource.
        /// </summary>
        ALLOW_TIER_3_ONLY,

        /// <summary>
        /// Allows only users with tier 2 and 3 subscriptions to access the resource.
        /// </summary>
        ALLOW_TIER_2_AND_3_ONLY,

        /// <summary>
        /// Allows users with any tier subscriptions to access the resource.
        /// </summary>
        ALLOW_ALL_TIERS
    }
}