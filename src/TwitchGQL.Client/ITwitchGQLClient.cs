using GraphQL;
using System.Threading;
using System.Threading.Tasks;
using TwitchGQL.Models.Requests.Persisted;
using TwitchGQL.Models.Requests.Templates;

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

        Task<Models.Responses.ViewerCardModLogsMessagesBySender.Data> SendQueryAsync(ViewerCardModLogsMessagesBySenderRequest request, CancellationToken cancellationToken = default);

        Task<Models.Responses.PlaybackAccessToken.Data> SendQueryAsync(PlaybackAccessTokenRequest request, CancellationToken cancellationToken = default);

        Task<Models.Responses.FollowButton_FollowUser.Data> SendQueryAsync(FollowButton_FollowUserRequest request, CancellationToken cancellationToken = default);

        Task<Models.Responses.FollowButton_UnfollowUser.Data> SendQueryAsync(FollowButton_UnfollowUserRequest request, CancellationToken cancellationToken = default);

        #endregion Methods
    }
}