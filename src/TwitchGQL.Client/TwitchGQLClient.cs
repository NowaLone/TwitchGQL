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

        public TwitchGQLClient(string endPoint = "https://gql.twitch.tv/gql", ILogger logger = default) : base(endPoint, new SystemTextJsonSerializer())
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

        public new async Task<TResult> SendQueryAsync<TResult>(GraphQLRequest request, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("Sending {OperationName} request.", request.OperationName);

            GraphQLResponse<TResult> result = await base.SendQueryAsync<TResult>(request, cancellationToken).ConfigureAwait(false);

            if (result.Errors?.Length > 0)
            {
                foreach (GraphQLError error in result.Errors)
                {
                    logger.LogError(error.Message);
                }
            }

            return result.Data;
        }

        public Task<Models.Responses.ViewerCardModLogsMessagesBySender.Data> SendQueryAsync(ViewerCardModLogsMessagesBySenderRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<Models.Responses.ViewerCardModLogsMessagesBySender.Data>(request, cancellationToken);
        }

        public Task<Models.Responses.PlaybackAccessToken.Data> SendQueryAsync(PlaybackAccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<Models.Responses.PlaybackAccessToken.Data>(request, cancellationToken);
        }

        public Task<Models.Responses.FollowButton_FollowUser.Data> SendQueryAsync(FollowButton_FollowUserRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<Models.Responses.FollowButton_FollowUser.Data>(request, cancellationToken);
        }

        public Task<Models.Responses.FollowButton_UnfollowUser.Data> SendQueryAsync(FollowButton_UnfollowUserRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<Models.Responses.FollowButton_UnfollowUser.Data>(request, cancellationToken);
        }

        #endregion Methods
    }
}