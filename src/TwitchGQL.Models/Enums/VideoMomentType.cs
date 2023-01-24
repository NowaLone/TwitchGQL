namespace TwitchGQL.Models.Enums
{
    /// <summary>
    /// Marker types present in momentum.
    /// </summary>
    public enum VideoMomentType
    {
        /// <summary>
        /// Creator/editor selected moment.
        /// </summary>
        STREAM_MARKER,

        /// <summary>
        /// <see cref="GAME_CHANGE"/> is when the streamer changes the game during their stream.
        /// </summary>
        GAME_CHANGE,

        /// <summary>
        /// Hearthstone video content analysis markers.
        /// </summary>
        HEARTHSTONE_VCA,

        /// <summary>
        /// Overwatch video content analysis markers.
        /// </summary>
        OVERWATCH_VCA,

        /// <summary>
        /// PUBG video content analysis markers.
        /// </summary>
        PUBG_VCA,

        /// <summary>
        /// VCA generic VCA analysis markers.
        /// </summary>
        VCA
    }
}