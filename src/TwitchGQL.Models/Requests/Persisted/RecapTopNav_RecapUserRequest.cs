namespace TwitchGQL.Models.Requests.Persisted
{
    public class RecapTopNav_RecapUserRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "RecapTopNav_RecapUser";
        public const int version = 1;
        public const string sha256Hash = "c81c9786507f604f53baaa7f34b86a83610a51868772155e33f3d5e38ce3df2f";

        #endregion Fields

        #region Constructors

        public RecapTopNav_RecapUserRequest() : base(null, new { }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}