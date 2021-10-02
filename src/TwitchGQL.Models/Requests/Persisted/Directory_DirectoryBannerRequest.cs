namespace TwitchGQL.Models.Requests.Persisted
{
    public class Directory_DirectoryBannerRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "Directory_DirectoryBanner";
        public const int version = 1;
        public const string sha256Hash = "2670fbecd8fbea0211c56528d6eff5752ef9d6c73cd5238d395784b46335ded4";

        #endregion Fields

        #region Constructors

        public Directory_DirectoryBannerRequest(string name) : base(null, new { name }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}