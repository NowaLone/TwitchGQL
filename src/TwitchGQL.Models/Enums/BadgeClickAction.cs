namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// Enumerates possible badge click actions.
    /// </summary>
    public enum BadgeClickAction
    {
        /// <summary>
        /// Go to the user's subscription page.
        /// </summary>
        SUBSCRIBE,

        /// <summary>
        /// Go to the Twitch Turbo purchasing page.
        /// </summary>
        GET_TURBO,

        /// <summary>
        /// Go to the Bits purchasing page.
        /// </summary>
        GET_BITS,

        /// <summary>
        /// Redirect the user to the badge click URL.
        /// </summary>
        VISIT_URL,
    }
}