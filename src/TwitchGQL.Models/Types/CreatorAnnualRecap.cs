using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    public class CreatorAnnualRecap
    {
        [JsonPropertyName("totalHoursViewersWatched")]
        public int TotalHoursViewersWatched { get; set; }

        [JsonPropertyName("totalFollowers")]
        public int TotalFollowers { get; set; }

        [JsonPropertyName("totalNewFollowers")]
        public int TotalNewFollowers { get; set; }

        [JsonPropertyName("streamsBroadcasted")]
        public int StreamsBroadcasted { get; set; }

        [JsonPropertyName("totalChatMessagesSent")]
        public int TotalChatMessagesSent { get; set; }

        [JsonPropertyName("uniqueCategory")]
        public Game UniqueCategory { get; set; }

        [JsonPropertyName("uniqueCategoryPercentile")]
        public double UniqueCategoryPercentile { get; set; }

        [JsonPropertyName("totalNumberOfClips")]
        public int TotalNumberOfClips { get; set; }

        [JsonPropertyName("channelPointsAccumulated")]
        public int ChannelPointsAccumulated { get; set; }

        [JsonPropertyName("hasBecomePartner")]
        public bool HasBecomePartner { get; set; }

        [JsonPropertyName("hasBecomeAffiliate")]
        public bool HasBecomeAffiliate { get; set; }

        [JsonPropertyName("topEmotesUsed")]
        public IEnumerable<AnnualRecapEmoteStat> TopEmotesUsed { get; set; }

        [JsonPropertyName("totalSubscribers")]
        public int TotalSubscribers { get; set; }

        [JsonPropertyName("newSubscribers")]
        public int NewSubscribers { get; set; }

        [JsonPropertyName("totalSubsGiftedInCommunity")]
        public int TotalSubsGiftedInCommunity { get; set; }
        [JsonPropertyName("topCategoriesStreamed")]
        public IEnumerable<Game> TopCategoriesStreamed { get; set; }
    }
}