namespace TwitchGQL.Models.Requests.Enums
{
    /// <summary>
    /// An enumeration on the different scope of a tag.
    /// </summary>
    public enum TagScope
    {
        /// <summary>
        /// Tags that can be applied to all content types.
        /// </summary>
        ALL,

        /// <summary>
        /// Tags that can only be applied to the CATEGORY content type.
        /// </summary>
        CATEGORY
    }
}