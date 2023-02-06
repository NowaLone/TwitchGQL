using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using TwitchGQL.Client.Converters;
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

        public TwitchGQLClient(string endPoint = "https://gql.twitch.tv/gql", ILogger logger = default) : base(endPoint, new SystemTextJsonSerializer(Configure()))
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

        private static Action<JsonSerializerOptions> Configure()
        {
            return (o) =>
            {
                o.Converters.Add(new JsonStringEnumConverter(new UppercaseJsonNamingPolicy()));
                o.Converters.Add(new PanelConverter());
            };
        }

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

        public Task<DirectoryPage_Game> SendQueryAsync(DirectoryPage_GameRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<DirectoryPage_Game>(request, cancellationToken);
        }

        public Task<DirectoryRoot_Directory> SendQueryAsync(DirectoryRoot_DirectoryRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<DirectoryRoot_Directory>(request, cancellationToken);
        }

        public Task<Directory_DirectoryBanner> SendQueryAsync(Directory_DirectoryBannerRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<Directory_DirectoryBanner>(request, cancellationToken);
        }

        public Task<ChannelPanels> SendQueryAsync(ChannelPanelsRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<ChannelPanels>(request, cancellationToken);
        }

        public Task<VideoCommentsByOffsetOrCursor> SendQueryAsync(VideoCommentsByOffsetOrCursorRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<VideoCommentsByOffsetOrCursor>(request, cancellationToken);
        }

        public Task<VideoPlayerStreamInfoOverlayVOD> SendQueryAsync(VideoPlayerStreamInfoOverlayVODRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<VideoPlayerStreamInfoOverlayVOD>(request, cancellationToken);
        }

        public Task<CoreActionsCurrentUser> SendQueryAsync(CoreActionsCurrentUserRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<CoreActionsCurrentUser>(request, cancellationToken);
        }

        public Task<RecapTopNav_RecapUser> SendQueryAsync(RecapTopNav_RecapUserRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<RecapTopNav_RecapUser>(request, cancellationToken);
        }

        public Task<AnnualRecap> SendQueryAsync(AnnualRecapRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<AnnualRecap>(request, cancellationToken);
        }

        public Task<TrackingManager_RequestInfo> SendQueryAsync(TrackingManager_RequestInfoRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<TrackingManager_RequestInfo>(request, cancellationToken);
        }

        public Task<MessageBufferChatHistory> SendQueryAsync(MessageBufferChatHistoryRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<MessageBufferChatHistory>(request, cancellationToken);
        }

        public Task<ChatList_Badges> SendQueryAsync(ChatList_BadgesRequest request, CancellationToken cancellationToken = default)
        {
            return SendQueryAsync<ChatList_Badges>(request, cancellationToken);
        }

        #endregion Methods
    }
}