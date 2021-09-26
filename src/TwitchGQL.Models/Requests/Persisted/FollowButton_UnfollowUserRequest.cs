namespace TwitchGQL.Models.Requests.Persisted
{
    public class FollowButton_UnfollowUserRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "FollowButton_UnfollowUser";
        public const string sha256Hash = "29783a1dac24124e02f7295526241a9f1476cd2f5ce1e394f93ea50c253d8628";

        #endregion Fields

        #region Constructors

        public FollowButton_UnfollowUserRequest(string targetID) : base(null, new { input = new { targetID } }, operationName, 1, sha256Hash)
        {
        }

        #endregion Constructors
    }
}