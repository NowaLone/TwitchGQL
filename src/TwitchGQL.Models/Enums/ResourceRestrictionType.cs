namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// An enumeration of the different restriction types.
    /// </summary>
    public enum ResourceRestrictionType
    {
        /// <summary>
        /// The resource is restricted for an unknown reason.
        /// </summary>
        UNKNOWN,

        /// <summary>
        /// The resource is restricted by a subscription.
        /// </summary>
        SUB_ONLY_LIVE,

        /// <summary>
        /// The resource is restricted by the All-Access Pass.
        /// </summary>
        ALL_ACCESS_PASS,

        /// <summary>
        /// The resource is restricted by the organization membership logic in RBAC.
        /// </summary>
        ORGANIZATION_ACCESS_ONLY
    }
}