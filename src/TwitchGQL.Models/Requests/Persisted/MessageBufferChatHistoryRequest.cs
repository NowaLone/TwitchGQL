namespace TwitchGQL.Models.Requests.Persisted
{
    public class MessageBufferChatHistoryRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "MessageBufferChatHistory";
        public const int version = 1;
        public const string sha256Hash = "323028b2fa8f8b5717dfdc5069b3880a2ad4105b168773c3048275b79ab81e2f";

        #endregion Fields

        #region Constructors

        public MessageBufferChatHistoryRequest(string channelLogin) : base(null, new { channelLogin }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}