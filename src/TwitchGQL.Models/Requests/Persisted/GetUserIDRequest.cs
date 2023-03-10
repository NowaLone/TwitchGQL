using TwitchGQL.Models.Enums;

namespace TwitchGQL.Models.Requests.Persisted
{
    public class GetUserIDRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "GetUserID";
        public const int version = 1;
        public const string sha256Hash = "bf6c594605caa0c63522f690156aa04bd434870bf963deb76668c381d16fcaa5";

        #endregion Fields

        #region Constructors

        public GetUserIDRequest(string login, UserLookupType lookupType) : base(null, new { login, lookupType }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}