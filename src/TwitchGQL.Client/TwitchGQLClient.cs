using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using TwitchGQL.Models.Requests.Persisted;
using TwitchGQL.Models.Requests.Templates;
using TwitchGQL.Models.Responses;

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

            logger.LogInformation("{OperationName} request has {errorCount} errors.", request.OperationName, result.Errors?.Length);

            if (result.Errors?.Length > 0)
            {
                foreach (GraphQLError error in result.Errors)
                {
                    logger.LogError(error.Message);
                }
            }

            return result.Data;
        }

        public Task<ViewerCardModLogsMessagesBySender> SendQueryAsync(ViewerCardModLogsMessagesBySenderRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<ViewerCardModLogsMessagesBySender>(request, cancellationToken);
        }

        public Task<PlaybackAccessToken> SendQueryAsync(PlaybackAccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<PlaybackAccessToken>(request, cancellationToken);
        }

        public Task<FollowButton_FollowUser> SendQueryAsync(FollowButton_FollowUserRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<FollowButton_FollowUser>(request, cancellationToken);
        }

        public Task<FollowButton_UnfollowUser> SendQueryAsync(FollowButton_UnfollowUserRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<FollowButton_UnfollowUser>(request, cancellationToken);
        }

        #endregion Methods
    }
}