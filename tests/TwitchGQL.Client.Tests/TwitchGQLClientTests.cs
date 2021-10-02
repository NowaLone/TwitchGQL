using GraphQL;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TwitchGQL.Models.Responses;

namespace TwitchGQL.Client.Tests
{
    [TestClass]
    public class TwitchGQLClientTests
    {
        #region Fields

        private readonly ITwitchGQLClient twitchGQLClient;

        #endregion Fields

        #region Constructors

        public TwitchGQLClientTests()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
               .AddUserSecrets<TwitchGQLClientTests>()
               .Build();

            twitchGQLClient = new TwitchGQLClient
            {
                ClientId = config.GetSection(nameof(TwitchGQLClient.ClientId)).Value,
                Authorization = config.GetSection(nameof(TwitchGQLClient.Authorization)).Value
            };
        }

        #endregion Constructors

        #region Methods

        [TestMethod]
        public async Task SendQueryAsync_Generic_ShouldReturnData()
        {
            // arrange
            Models.Requests.Templates.PlaybackAccessTokenRequest request = new(login: "monstercat");

            // act
            PlaybackAccessToken data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.StreamPlaybackAccessToken);
            Assert.IsFalse(string.IsNullOrWhiteSpace(data.StreamPlaybackAccessToken.Value));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data.StreamPlaybackAccessToken.Signature));
        }

        [TestMethod]
        public async Task SendQueryAsync_Generic_WithWrongRequest_ShouldReturnNull()
        {
            // arrange
            GraphQLRequest request = new();

            // act
            PlaybackAccessToken data = await twitchGQLClient.SendQueryAsync<PlaybackAccessToken>(request).ConfigureAwait(false);

            // assert
            Assert.IsNull(data);
        }

        [TestMethod]
        public async Task SendQueryAsync_PlaybackAccessTokenRequest_ShouldReturnData()
        {
            // arrange
            Models.Requests.Templates.PlaybackAccessTokenRequest request = new(login: "monstercat");

            // act
            PlaybackAccessToken data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.StreamPlaybackAccessToken);
            Assert.IsFalse(string.IsNullOrWhiteSpace(data.StreamPlaybackAccessToken.Value));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data.StreamPlaybackAccessToken.Signature));
        }

        [TestMethod]
        public async Task SendQueryAsync_FollowButton_FollowUserRequest_ShouldReturnData()
        {
            // arrange
            Models.Requests.Persisted.FollowButton_UnfollowUserRequest unfollowRequest = new("12826");
            Models.Requests.Persisted.FollowButton_FollowUserRequest request = new(false, "12826");

            // act
            await twitchGQLClient.SendQueryAsync(unfollowRequest).ConfigureAwait(false);
            FollowButton_FollowUser data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.FollowUser);
            Assert.IsNull(data.FollowUser.Error);
            Assert.IsNotNull(data.FollowUser.Follow);
            Assert.IsFalse(data.FollowUser.Follow.DisableNotifications);
            Assert.IsNotNull(data.FollowUser.Follow.User);
            Assert.AreEqual("12826", data.FollowUser.Follow.User.Id);
            Assert.AreEqual("Twitch", data.FollowUser.Follow.User.DisplayName);
            Assert.AreEqual("twitch", data.FollowUser.Follow.User.Login);
            Assert.IsNotNull(data.FollowUser.Follow.User.Self);
            Assert.IsTrue(data.FollowUser.Follow.User.Self.CanFollow);
            Assert.IsNotNull(data.FollowUser.Follow.User.Self.Follower);
            Assert.IsFalse(data.FollowUser.Follow.User.Self.Follower.DisableNotifications);
        }

        [TestMethod]
        public async Task SendQueryAsync_FollowButton_UnfollowUserRequest_ShouldReturnData()
        {
            // arrange
            Models.Requests.Persisted.FollowButton_FollowUserRequest followRequest = new(false, "12826");
            Models.Requests.Persisted.FollowButton_UnfollowUserRequest request = new("12826");

            // act
            await twitchGQLClient.SendQueryAsync(followRequest).ConfigureAwait(false);
            FollowButton_UnfollowUser data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.UnfollowUser);
            Assert.IsNotNull(data.UnfollowUser.Follow);
            Assert.IsFalse(data.UnfollowUser.Follow.DisableNotifications);
            Assert.IsNotNull(data.UnfollowUser.Follow.User);
            Assert.AreEqual("12826", data.UnfollowUser.Follow.User.Id);
            Assert.AreEqual("Twitch", data.UnfollowUser.Follow.User.DisplayName);
            Assert.AreEqual("twitch", data.UnfollowUser.Follow.User.Login);
            Assert.IsNotNull(data.UnfollowUser.Follow.User.Self);
            Assert.IsTrue(data.UnfollowUser.Follow.User.Self.CanFollow);
            Assert.IsNull(data.UnfollowUser.Follow.User.Self.Follower);
        }

        #endregion Methods
    }
}