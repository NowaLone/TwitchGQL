using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using TwitchGQL.Models.Requests.Persisted;
using TwitchGQL.Models.Requests.Templates;

namespace TwitchGQL.Client
{
    public class TwitchGQLClient : GraphQLHttpClient, ITwitchGQLClient
    {
        #region Fields

        private readonly ILogger logger;
        private string clientId;
        private string authorization;

        #endregion Fields

        #region Constructors

        public TwitchGQLClient(ILogger logger = default) : base("https://gql.twitch.tv/gql", new SystemTextJsonSerializer())
        {
            this.logger = logger ?? Microsoft.Extensions.Logging.Abstractions.NullLogger<TwitchGQLClient>.Instance;
        }

        #endregion Constructors

        #region Properties

        public string ClientId
        {
            get => clientId;
            set
            {
                clientId = value;
                HttpClient.DefaultRequestHeaders.Add("Client-ID", value);
            }
        }

        public string Authorization
        {
            get => authorization;
            set
            {
                authorization = value;
                HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("OAuth", value);
            }
        }

        #endregion Properties

        #region Methods

        public async Task<Models.Responses.ViewerCardModLogsMessagesBySender.Data> SendQueryAsync(ViewerCardModLogsMessagesBySenderRequest request, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("Sending {OperationName} request.", request.OperationName);

            GraphQLResponse<Models.Responses.ViewerCardModLogsMessagesBySender.Data> result = await SendQueryAsync<Models.Responses.ViewerCardModLogsMessagesBySender.Data>(request, cancellationToken).ConfigureAwait(false);

            if (result.Errors.Length > 0)
            {
                foreach (GraphQLError error in result.Errors)
                {
                    logger.LogError(error.Message);
                }
            }

            return result.Data;
        }

        public async Task<Models.Responses.PlaybackAccessToken.Data> SendQueryAsync(PlaybackAccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("Sending {OperationName} request.", request.OperationName);

            GraphQLResponse<Models.Responses.PlaybackAccessToken.Data> result = await SendQueryAsync<Models.Responses.PlaybackAccessToken.Data>(request, cancellationToken).ConfigureAwait(false);

            if (result.Errors?.Length > 0)
            {
                foreach (GraphQLError error in result.Errors)
                {
                    logger.LogError(error.Message);
                }
            }

            return result.Data;
        }

        #endregion Methods
    }
}