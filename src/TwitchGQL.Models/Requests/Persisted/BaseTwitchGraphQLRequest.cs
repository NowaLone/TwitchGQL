using GraphQL;

namespace TwitchGQL.Models.Requests.Persisted
{
    public class BaseTwitchGraphQLRequest : GraphQLRequest
    {
        #region Constructors

        public BaseTwitchGraphQLRequest(int version = 1, string sha256Hash = null) : base()
        {
            Add("extensions", new
            {
                persistedQuery = new
                {
                    version,
                    sha256Hash
                }
            });
        }

        public BaseTwitchGraphQLRequest(GraphQLRequest other, int version = 1, string sha256Hash = null) : base(other)
        {
            Add("extensions", new
            {
                persistedQuery = new
                {
                    version,
                    sha256Hash
                }
            });
        }

        public BaseTwitchGraphQLRequest(string query, object variables = null, string operationName = null, int version = 1, string sha256Hash = null) : base(query, variables, operationName)
        {
            Add("extensions", new
            {
                persistedQuery = new
                {
                    version,
                    sha256Hash
                }
            });
        }

        #endregion Constructors
    }
}