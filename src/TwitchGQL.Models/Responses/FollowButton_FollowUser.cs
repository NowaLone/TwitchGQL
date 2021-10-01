using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Models.Responses
{
    public class FollowButton_FollowUser
    {
        [JsonPropertyName("followUser")]
        public FollowUserPayload FollowUser { get; set; }
    }
}