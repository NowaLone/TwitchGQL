using System.Text.Json.Serialization;
using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// The appeal information associated with the flagged track.
    /// </summary>
    public class FlaggedTrackAppeal
    {
        /// <summary>
        /// ID of the track appeal.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Reason for the track appeal.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Status of the track appeal, ie. PENDING, RESOLVED, UNKNOWN.
        /// </summary>
        [JsonPropertyName("status")]
        public FlaggedTrackAppealStatus Status { get; set; }
    }
}