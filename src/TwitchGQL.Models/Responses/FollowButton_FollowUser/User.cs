using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.FollowButton_FollowUser
{
    public class User
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("self")]
        public UserSelfConnection Self { get; set; }
    }
}