using GraphQL;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;
using TwitchGQL.Models.Requests.Persisted;
using TwitchGQL.Models.Responses;
using TwitchGQL.Models.Types;

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
            Models.Responses.PlaybackAccessToken data = await twitchGQLClient.SendQueryAsync<Models.Responses.PlaybackAccessToken>(request).ConfigureAwait(false);

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
            object data = await twitchGQLClient.SendQueryAsync<object>(request).ConfigureAwait(false);

            // assert
            Assert.IsNull(data);
        }

        [TestMethod]
        public async Task SendQueryAsync_PlaybackAccessTokenRequest_ShouldReturnData()
        {
            // arrange
            Models.Requests.Templates.PlaybackAccessTokenRequest request = new(login: "monstercat");

            // act
            Models.Responses.PlaybackAccessToken data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

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
            FollowButton_UnfollowUserRequest unfollowRequest = new("12826");
            FollowButton_FollowUserRequest request = new("12826");

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
            FollowButton_FollowUserRequest followRequest = new("12826");
            FollowButton_UnfollowUserRequest request = new("12826");

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

        [TestMethod]
        public async Task SendQueryAsync_DirectoryPage_GameRequest_ShouldReturnData()
        {
            // arrange
            DirectoryPage_GameRequest request = new("music");

            // act
            DirectoryPage_Game data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.Game);
            Assert.AreEqual("Music", data.Game.DisplayName);
            Assert.AreEqual("26936", data.Game.Id);
            Assert.AreEqual("Music", data.Game.Name);
            Assert.IsNotNull(data.Game.Streams);
            Assert.IsNotNull(data.Game.Streams.Edges);
            Assert.IsNotNull(data.Game.Streams.PageInfo);
            Assert.IsTrue(data.Game.Streams.PageInfo.HasNextPage);

            StreamEdge stream = data.Game.Streams.Edges.FirstOrDefault(e => e.Node.Broadcaster.Id == "27446517");
            Assert.IsNotNull(stream);
            Assert.IsFalse(string.IsNullOrWhiteSpace(stream.Cursor));
            Assert.IsNotNull(stream.Node);
            Assert.IsNull(stream.TrackingID);

            Assert.IsNotNull(stream.Node.Broadcaster);
            Assert.IsNotNull(stream.Node.Game);
            Assert.IsFalse(string.IsNullOrWhiteSpace(stream.Node.Id));
            Assert.IsNotNull(stream.Node.PreviewImageURL);
            Assert.AreEqual("https://static-cdn.jtvnw.net/previews-ttv/live_user_monstercat-440x248.jpg", stream.Node.PreviewImageURL.AbsoluteUri);
            Assert.IsNotNull(stream.Node.Tags);
            Assert.AreEqual("Non Stop Music - Monstercat TV  🎶", stream.Node.Title);
            Assert.AreEqual("live", stream.Node.Type);
            Assert.AreNotEqual(0, stream.Node.ViewersCount);

            Assert.AreEqual("Monstercat", stream.Node.Broadcaster.DisplayName);
            Assert.AreEqual("27446517", stream.Node.Broadcaster.Id);
            Assert.AreEqual("monstercat", stream.Node.Broadcaster.Login);
            Assert.AreEqual("917DF4", stream.Node.Broadcaster.PrimaryColorHex);
            Assert.IsNotNull(stream.Node.Broadcaster.ProfileImageURL);
            Assert.AreEqual("https://static-cdn.jtvnw.net/jtv_user_pictures/monstercat-profile_image-3e109d75f8413319-50x50.jpeg", stream.Node.Broadcaster.ProfileImageURL.AbsoluteUri);
            Assert.IsNotNull(stream.Node.Broadcaster.Roles);
            Assert.IsTrue(stream.Node.Broadcaster.Roles.IsPartner);

            Assert.AreEqual("https://static-cdn.jtvnw.net/ttv-boxart/Music-40x56.jpg", stream.Node.Game.BoxArtURL.AbsoluteUri);
            Assert.AreEqual("Music", stream.Node.Game.DisplayName);
            Assert.AreEqual("26936", stream.Node.Game.Id);
            Assert.AreEqual("Music", stream.Node.Game.Name);

            Tag tag = stream.Node.Tags.FirstOrDefault(e => e.Id == "6ea6bca4-4712-4ab9-a906-e3336a9d8039");
            Assert.IsNotNull(tag);
            Assert.AreEqual("6ea6bca4-4712-4ab9-a906-e3336a9d8039", tag.Id);
            Assert.IsTrue(tag.IsLanguageTag);
            Assert.AreEqual("English", tag.LocalizedName);
            Assert.AreEqual("auto___lang_en", tag.TagName);
        }

        [TestMethod]
        public async Task SendQueryAsync_DirectoryRoot_DirectoryRequest_ShouldReturnData()
        {
            // arrange
            DirectoryRoot_DirectoryRequest request = new("grand theft auto v");

            // act
            DirectoryRoot_Directory data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.Game);
            Assert.AreEqual("Grand Theft Auto V", data.Game.DisplayName);
            Assert.AreEqual("32982", data.Game.Id);
        }

        #endregion Methods
    }
}