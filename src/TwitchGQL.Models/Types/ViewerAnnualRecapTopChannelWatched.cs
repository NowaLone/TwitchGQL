using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    public class ViewerAnnualRecapTopChannelWatched
    {
        [JsonPropertyName("channel")]
        public Channel Channel { get; set; }

        [JsonPropertyName("hoursWatched")]
        public int HoursWatched { get; set; }

        [JsonPropertyName("chatMessagesSent")]
        public int ChatMessagesSent { get; set; }

        [JsonPropertyName("percentileChatter")]
        public double PercentileChatter { get; set; }

        [JsonPropertyName("bitsCheered")]
        public int BitsCheered { get; set; }

        [JsonPropertyName("channelPointsEarned")]
        public int ChannelPointsEarned { get; set; }

        [JsonPropertyName("emotesSent")]
        public int EmotesSent { get; set; }

        [JsonPropertyName("monthsSubscribed")]
        public int MonthsSubscribed { get; set; }
    }
}