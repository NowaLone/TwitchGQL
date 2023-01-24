namespace TwitchGQL.Models.Requests.Persisted
{
    public class CoreActionsCurrentUserRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "CoreActionsCurrentUser";
        public const int version = 1;
        public const string sha256Hash = "6b5b63a013cf66a995d61f71a508ab5c8e4473350c5d4136f846ba65e8101e95";

        #endregion Fields

        #region Constructors

        public CoreActionsCurrentUserRequest() : base(null, new { }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}