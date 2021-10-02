namespace TwitchGQL.Models.Requests.Persisted
{
    public class DirectoryRoot_DirectoryRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "DirectoryRoot_Directory";
        public const int version = 1;
        public const string sha256Hash = "9f4f6ae67f21ee50b454fcf048691107a52bfe7907ead73b9427398e343ca319";

        #endregion Fields

        #region Constructors

        public DirectoryRoot_DirectoryRequest(string name) : base(null, new { name }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}