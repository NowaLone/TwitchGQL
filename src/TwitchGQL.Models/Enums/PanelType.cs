namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// PanelType is the kind of panel.
    /// </summary>
    public enum PanelType
    {
        /// <summary>
        /// DEFAULT panels contain one or more of the content values in `Panel` to display.
        /// </summary>
        DEFAULT,

        /// <summary>
        /// EXTENSION panels are placeholders for extension content.
        /// </summary>
        EXTENSION
    }
}