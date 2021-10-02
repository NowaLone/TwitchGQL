namespace TwitchGQL.Models.Requests.Persisted
{
    public class ChannelPanelsRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "ChannelPanels";
        public const int version = 1;
        public const string sha256Hash = "c388999b5fcd8063deafc7f7ad32ebd1cce3d94953c20bf96cffeef643327322";

        #endregion Fields

        #region Constructors

        public ChannelPanelsRequest(string id) : base(null, new { id }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}