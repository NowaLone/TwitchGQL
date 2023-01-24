using System.Text.Json.Serialization;

namespace TwitchGQL.Models
{
    /// <summary>
    /// Metadata about a GraphQL request.
    /// </summary>
    public class RequestInfo
    {
        /// <summary>
        /// The country code where the request originated. Defaults to "US" if geoip lookup fails.
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Whether the request came from a country belonging to the European Union.
        /// </summary>
        [JsonPropertyName("fromEU")]
        public bool FromEU { get; set; }

        /// <summary>
        /// The IP address where the request originated.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Whether the request came from a country belonging to the European Economic Area.
        /// </summary>
        [JsonPropertyName("isFromEEA")]
        public bool IsFromEEA { get; set; }
    }
}