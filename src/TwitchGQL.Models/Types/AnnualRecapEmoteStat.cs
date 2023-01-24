using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    public class AnnualRecapEmoteStat
    {
        [JsonPropertyName("emote")]
        public Emote Emote { get; set; }

        [JsonPropertyName("timesUsed")]
        public int TimesUsed { get; set; }
    }
}