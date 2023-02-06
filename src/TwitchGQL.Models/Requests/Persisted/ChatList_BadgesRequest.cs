namespace TwitchGQL.Models.Requests.Persisted
{
    public class ChatList_BadgesRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "ChatList_Badges";
        public const int version = 1;
        public const string sha256Hash = "86f43113c04606e6476e39dcd432dee47c994d77a83e54b732e11d4935f0cd08";

        #endregion Fields

        #region Constructors

        public ChatList_BadgesRequest(string channelLogin) : base(null, new { channelLogin }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}