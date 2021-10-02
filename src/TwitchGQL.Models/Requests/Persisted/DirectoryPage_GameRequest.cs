using TwitchGQL.Models.Requests.Enums;

namespace TwitchGQL.Models.Requests.Persisted
{
    public class DirectoryPage_GameRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "DirectoryPage_Game";
        public const int version = 1;
        public const string sha256Hash = "d5c5df7ab9ae65c3ea0f225738c08a36a4a76e4c6c31db7f8c4b8dc064227f9e";

        #endregion Fields

        #region Constructors

        public DirectoryPage_GameRequest(string name, Sort sort = Sort.RELEVANCE, string platform = "web", string requestID = "JIRA-VXP-2397", int limit = 30) : base(null, new { name, options = new { sort = sort.ToString(), recommendationsContext = new { platform }, requestID, tags = new string[0] }, sortTypeIsRecency = sort == Sort.RECENT, limit }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}