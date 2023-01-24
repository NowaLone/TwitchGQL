namespace TwitchGQL.Models.Requests.Persisted
{
    public class AnnualRecapRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "AnnualRecap";
        public const int version = 1;
        public const string sha256Hash = "694a0400b4c677a172da30cd5561b8954cc60ca688f40e7095abb2b86f00f825";

        #endregion Fields

        #region Constructors

        public AnnualRecapRequest(string channelID) : base(null, new { channelID }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}