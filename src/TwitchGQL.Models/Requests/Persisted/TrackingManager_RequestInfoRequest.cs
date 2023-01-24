namespace TwitchGQL.Models.Requests.Persisted
{
    public class TrackingManager_RequestInfoRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "TrackingManager_RequestInfo";
        public const int version = 1;
        public const string sha256Hash = "aacdbed250e409105d124ea697ad291a06864c9343067714559fa01230c4cf1b";

        #endregion Fields

        #region Constructors

        public TrackingManager_RequestInfoRequest() : base(null, new { }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}