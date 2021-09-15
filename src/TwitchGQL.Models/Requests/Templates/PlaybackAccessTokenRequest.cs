using GraphQL;

namespace TwitchGQL.Models.Requests.Templates
{
    public class PlaybackAccessTokenRequest : GraphQLRequest
    {
        #region Fields

        public const string operationName = "PlaybackAccessToken_Template";
        public const string query = "query PlaybackAccessToken_Template($login: String!, $isLive: Boolean!, $vodID: ID!, $isVod: Boolean!, $playerType: String!) {  streamPlaybackAccessToken(channelName: $login, params: {platform: \"web\", playerBackend: \"mediaplayer\", playerType: $playerType}) @include(if: $isLive) {    value    signature    __typename  }  videoPlaybackAccessToken(id: $vodID, params: {platform: \"web\", playerBackend: \"mediaplayer\", playerType: $playerType}) @include(if: $isVod) {    value    signature    __typename  }}";

        #endregion Fields

        #region Constructors

        public PlaybackAccessTokenRequest(bool isLive = true, string login = default, bool isVod = false, string vodID = "", string playerType = "site") : base(query, new { isLive, login, isVod, vodID, playerType }, operationName)
        {
        }

        #endregion Constructors
    }
}