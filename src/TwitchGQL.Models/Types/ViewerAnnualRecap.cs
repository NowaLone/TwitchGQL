using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    public class ViewerAnnualRecap
    {
        [JsonPropertyName("distinctViewingDays")]
        public int DistinctViewingDays { get; set; }

        [JsonPropertyName("totalHoursWatched")]
        public int TotalHoursWatched { get; set; }

        [JsonPropertyName("totalChatMessages")]
        public int TotalChatMessages { get; set; }

        [JsonPropertyName("topEmotesUsed")]
        public IEnumerable<AnnualRecapEmoteStat> TopEmotesUsed { get; set; }

        [JsonPropertyName("topCategories")]
        public IEnumerable<Game> TopCategories { get; set; }

        [JsonPropertyName("totalSubsGifted")]
        public int TotalSubsGifted { get; set; }

        [JsonPropertyName("channelsModded")]
        public int ChannelsModded { get; set; }

        [JsonPropertyName("totalHoursWatchedAsMod")]
        public int TotalHoursWatchedAsMod { get; set; }

        [JsonPropertyName("topChannels")]
        public IEnumerable<ViewerAnnualRecapTopChannelWatched> TopChannels { get; set; }

        [JsonPropertyName("totalChannelPointsAccumulated")]
        public int TotalChannelPointsAccumulated { get; set; }

        [JsonPropertyName("artistEmotesCreated")]
        public int ArtistEmotesCreated { get; set; }

        [JsonPropertyName("artistEmotesUsage")]
        public int ArtistEmotesUsage { get; set; }
    }
}