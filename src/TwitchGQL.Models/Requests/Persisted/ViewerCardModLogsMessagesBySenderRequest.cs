namespace TwitchGQL.Models.Requests.Persisted
{
    public class ViewerCardModLogsMessagesBySenderRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "ViewerCardModLogsMessagesBySender";
        public const int version = 1;
        public const string sha256Hash = "437f209626e6536555a08930f910274528a8dea7e6ccfbef0ce76d6721c5d0e7";

        #endregion Fields

        #region Constructors

        public ViewerCardModLogsMessagesBySenderRequest(string senderID, string channelLogin, bool includeAutoModCaughtMessages = true, string cursor = null) : base(null, new { senderID, channelLogin, includeAutoModCaughtMessages, cursor }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}