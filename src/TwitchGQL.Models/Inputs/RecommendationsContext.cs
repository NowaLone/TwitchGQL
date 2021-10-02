using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Inputs
{
    /// <summary>
    /// RecommendationsContext define parameters which can control recommendations logic. Clients should strive to fill in as many fields as possible for the highest quality recommendaitons. Many of these fields should be identical to what is sent in pageview events: <see href="https://blueprint.di.xarth.tv/#/schema/pageview"/>.
    /// </summary>
    public class RecommendationsContext
    {
        /// <summary>
        /// The 'app_window_height' field sent in pageview events.
        /// </summary>
        [JsonPropertyName("appWindowHeight")]
        public int AppWindowHeight { get; set; }

        /// <summary>
        /// The 'app_window_width' field sent in pageview events.
        /// </summary>
        [JsonPropertyName("appWindowWidth")]
        public int AppWindowWidth { get; set; }

        /// <summary>
        /// The 'client_app' field sent in pageview events.
        /// </summary>
        [JsonPropertyName("clientApp")]
        public string ClientApp { get; set; }

        /// <summary>
        /// Optional ISO country code, defaults to use the country code from the geoip of the request.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The 'location' field sent in pageview events (signifying the location on the site or app).
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Web, ios, android, etc.
        /// </summary>
        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// The 'referrer_domain' field sent in pageview events.
        /// </summary>
        [JsonPropertyName("referrerDomain")]
        public string ReferrerDomain { get; set; }

        /// <summary>
        /// The 'viewport_height' field sent in pageview events.
        /// </summary>
        [JsonPropertyName("viewportHeight")]
        public int ViewportHeight { get; set; }

        /// <summary>
        /// The 'viewport_width' field sent in pageview events.
        /// </summary>
        [JsonPropertyName("viewportWidth")]
        public int ViewportWidth { get; set; }
    }
}