namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// An enumeration of the different exemption types.
    /// </summary>
    public enum ResourceRestrictionExemptionType
    {
        /// <summary>
        /// The restriction is exempt for an unknown reason.
        /// </summary>
        UNKNOWN,

        /// <summary>
        /// The restriction is exempt for all users.
        /// </summary>
        ALL,

        /// <summary>
        /// The restriction is exempt for staff accounts.
        /// </summary>
        STAFF,

        /// <summary>
        /// The restriction is exempt for site admins.
        /// </summary>
        SITE_ADMIN,

        /// <summary>
        /// The restriction is exempt for owning a product.
        /// </summary>
        PRODUCT,

        /// <summary>
        /// The restriction is exempt for viewers that are in the same org as the channel owner.
        /// </summary>
        ORGANIZATION_MEMBER,

        /// <summary>
        /// The restriction is exempt for the preview duration.
        /// </summary>
        PREVIEW,

        /// <summary>
        /// The restriction is exempt for channel moderators.
        /// </summary>
        CHANNEL_MODERATOR,

        /// <summary>
        /// The restriction is exempt for channel VIPs.
        /// </summary>
        CHANNEL_VIP
    }
}