using GraphQL;
using System.Threading;
using System.Threading.Tasks;
using TwitchGQL.Models.Requests.Persisted;
using TwitchGQL.Models.Requests.Templates;
using TwitchGQL.Models.Responses;

namespace TwitchGQL.Client
{
    public interface ITwitchGQLClient
    {
        #region Properties

        string ClientId { get; set; }
        string Authorization { get; set; }

        #endregion Properties

        #region Methods

        Task<TResult> SendQueryAsync<TResult>(GraphQLRequest request, CancellationToken cancellationToken = default);

        Task<ViewerCardModLogsMessagesBySender> SendQueryAsync(ViewerCardModLogsMessagesBySenderRequest request, CancellationToken cancellationToken = default);

        Task<PlaybackAccessToken> SendQueryAsync(PlaybackAccessTokenRequest request, CancellationToken cancellationToken = default);

        Task<FollowButton_FollowUser> SendQueryAsync(FollowButton_FollowUserRequest request, CancellationToken cancellationToken = default);

        Task<FollowButton_UnfollowUser> SendQueryAsync(FollowButton_UnfollowUserRequest request, CancellationToken cancellationToken = default);

        Task<DirectoryPage_Game> SendQueryAsync(DirectoryPage_GameRequest request, CancellationToken cancellationToken = default);

        #endregion Methods
    }
}