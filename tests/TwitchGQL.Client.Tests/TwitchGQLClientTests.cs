using GraphQL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging.Debug;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitchGQL.Models.Enums;
using TwitchGQL.Models.Interfaces;
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

            twitchGQLClient = new TwitchGQLClient(logger: new DebugLoggerProvider().CreateLogger(nameof(TwitchGQLClient)))
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
            // Arrange
            Models.Requests.Templates.PlaybackAccessTokenRequest request = new(login: "monstercat");

            // Act
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
            // Arrange
            GraphQLRequest request = new();

            // Act
            object data = await twitchGQLClient.SendQueryAsync<object>(request).ConfigureAwait(false);

            // assert
            Assert.IsNull(data);
        }

        [TestMethod]
        public async Task SendQueryAsync_PlaybackAccessTokenRequest_ShouldReturnData()
        {
            // Arrange
            Models.Requests.Templates.PlaybackAccessTokenRequest request = new(login: "monstercat");

            // Act
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
            // Arrange
            FollowButton_UnfollowUserRequest unfollowRequest = new("12826");
            FollowButton_FollowUserRequest request = new("12826");

            // Act
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
            // Arrange
            FollowButton_FollowUserRequest followRequest = new("12826");
            FollowButton_UnfollowUserRequest request = new("12826");

            // Act
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
            // Arrange
            DirectoryPage_GameRequest request = new("music");

            // Act
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
            Assert.AreEqual("Non Stop Music - Monstercat TV 🎶", stream.Node.Title);
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
            // Arrange
            DirectoryRoot_DirectoryRequest request = new("grand theft auto v");

            // Act
            DirectoryRoot_Directory data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.Game);
            Assert.AreEqual("Grand Theft Auto V", data.Game.DisplayName);
            Assert.AreEqual("32982", data.Game.Id);
        }

        [TestMethod]
        public async Task SendQueryAsync_Directory_DirectoryBannerRequest_ShouldReturnData()
        {
            // Arrange
            Directory_DirectoryBannerRequest request = new("Grand Theft Auto V");
            IEnumerable<Tag> tags = new Tag[]
            {
                new Tag
                {
                    Id="80427d95-bb46-42d3-bf4d-408e9bdca49a",
                    IsLanguageTag=false,
                    LocalizedName="Adventure Game",
                    TagName="Adventure Game"
                },
                new Tag
                {
                    Id="a69f7ffb-ddda-4c05-8d7d-f0b24975a2c3",
                    IsLanguageTag=false,
                    LocalizedName="FPS",
                    TagName="FPS"
                },
                new Tag
                {
                    Id="523fe736-fa95-44c7-b22f-13008ca2172c",
                    IsLanguageTag=false,
                    LocalizedName="Shooter",
                    TagName="Shooter"
                },
                new Tag
                {
                    Id="4d1eaa36-f750-4862-b7e9-d0a13970d535",
                    IsLanguageTag=false,
                    LocalizedName="Action",
                    TagName="Action"
                },
                new Tag
                {
                    Id="a682f560-5186-4871-b97a-8d8e3f4308e9",
                    IsLanguageTag=false,
                    LocalizedName="Open World",
                    TagName="Open World"
                },
            };
            // Act
            Directory_DirectoryBanner data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.Game);
            Assert.IsNotNull(data.CurrentUser);

            Assert.IsNull(data.Game.ActiveDropCampaigns);
            Assert.AreEqual("https://static-cdn.jtvnw.net/ttv-boxart/Grand%20Theft%20Auto%20V-144x192.jpg", data.Game.AvatarURL.AbsoluteUri);
            Assert.AreEqual("https://static-cdn.jtvnw.net/categorydb-production-game-banners/32982/en-us/781d77d7-834c-4650-9b34-42945e1b8e8f.png", data.Game.CoverURL.AbsoluteUri);
            Assert.AreEqual("The biggest, most dynamic and most diverse open world ever created, Grand Theft Auto V blends storytelling and gameplay in new ways as players repeatedly jump in and out of the lives of the game’s three lead characters, playing all sides of the game’s interwoven story.", data.Game.Description);
            Assert.AreEqual("Grand Theft Auto V", data.Game.DisplayName);
            Assert.AreNotEqual(0, data.Game.FollowersCount);
            Assert.AreEqual("32982", data.Game.Id);
            Assert.AreEqual("Grand Theft Auto V", data.Game.Name);
            Assert.IsNull(data.Game.PrestoID);
            Assert.IsNotNull(data.Game.Streams);
            Assert.IsNotNull(data.Game.Tags);
            Assert.AreNotEqual(0, data.Game.ViewersCount);

            Assert.IsFalse(string.IsNullOrWhiteSpace(data.CurrentUser.Id));
            Assert.IsNull(data.CurrentUser.Roles.IsSiteAdmin);
            Assert.IsNull(data.CurrentUser.Roles.IsStaff);

            Assert.IsNotNull(data.Game.Streams.Edges);
            Assert.AreEqual(1, data.Game.Streams.Edges.Count());

            StreamEdge node = data.Game.Streams.Edges.First();
            Assert.IsNotNull(node.Node);
            Assert.IsFalse(string.IsNullOrWhiteSpace(node.Node.Id));
            Assert.IsNotNull(node.Node.PreviewImageURL);
            Assert.AreEqual(tags.Count(), data.Game.Tags.Count());
            Assert.IsFalse(data.Game.Tags.Any(t => tags.FirstOrDefault(ta => ta.Id == t.Id && ta.IsLanguageTag == t.IsLanguageTag && ta.LocalizedName == t.LocalizedName && ta.TagName == t.TagName) == default));
        }

        [TestMethod]
        public async Task SendQueryAsync_ChannelPanelsRequest_ShouldReturnData()
        {
            // Arrange
            ChannelPanelsRequest request = new("12826");
            IEnumerable<IPanel> panels = new IPanel[]
            {
                new DefaultPanel
                {
                    Description=null,
                    Id="108497086",
                    ImageURL=new Uri("https://panels-images.twitch.tv/panel-12826-image-b4f68cb5-8aa8-47b7-bdbc-febf0bf28be6"),
                    LinkURL=null,
                    Title=null,
                    Type=PanelType.DEFAULT
                },
                new DefaultPanel
                {
                    Description=null,
                    Id="47505838",
                    ImageURL=new Uri("https://panels-images.twitch.tv/panel-12826-image-8a6f2d17-b7e3-4e1d-a05f-7535c0ed54bc"),
                    LinkURL=new Uri("https://twitch.app.link/RziDvXOBu1"),
                    Title=null,
                    Type=PanelType.DEFAULT
                },
                new DefaultPanel
                {
                    Description=null,
                    Id="45704882",
                    ImageURL=new Uri("https://panels-images.twitch.tv/panel-12826-image-ea744eb9-0ae8-417e-b071-85c9630d1cdd"),
                    LinkURL=new Uri("https://www.twitch.tv/p/legal/community-guidelines/"),
                    Title=null,
                    Type=PanelType.DEFAULT
                },
                new DefaultPanel
                {
                    Description=null,
                    Id="50630002",
                    ImageURL=new Uri("https://panels-images.twitch.tv/panel-12826-image-04528640-4c11-4018-82a1-7677ac722667"),
                    LinkURL=new Uri("https://dashboard.twitch.tv/extensions/skt182bso1i1ah7dnmkwqkdk26dak4"),
                    Title=null,
                    Type=PanelType.DEFAULT
                },
                new DefaultPanel
                {
                    Description=null,
                    Id="89453673",
                    ImageURL=new Uri("https://panels-images.twitch.tv/panel-12826-image-58140f8b-53aa-40f3-8d18-cb6e096dd75e"),
                    LinkURL=new Uri("https://www.twitch.tv/broadcast/soundtrack"),
                    Title=null,
                    Type=PanelType.DEFAULT
                },
                new ExtensionPanel
                {
                    Id = "45797311",
                    SlotID="extension-panel-1",
                    Type=PanelType.EXTENSION
                }
            };

            // Act
            ChannelPanels data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.CurrentUser);
            Assert.IsNotNull(data.User);

            Assert.IsFalse(string.IsNullOrWhiteSpace(data.CurrentUser.Id));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data.CurrentUser.Login));
            Assert.IsNotNull(data.CurrentUser.Roles);
            Assert.IsNull(data.CurrentUser.Roles.IsSiteAdmin);
            Assert.IsNull(data.CurrentUser.Roles.IsStaff);

            Assert.IsNotNull(data.User.Cheer);
            Assert.AreEqual("12826", data.User.Cheer.Id);
            Assert.AreEqual("12826", data.User.Id);
            Assert.AreEqual("twitch", data.User.Login);
            Assert.IsNotNull(data.User.Panels);
            Assert.AreEqual(panels.Count(), data.User.Panels.Count());
            Assert.IsFalse(data.User.Panels.OfType<DefaultPanel>().Any(p => panels.OfType<DefaultPanel>().FirstOrDefault(pa => pa.Description == p.Description && pa.Id == p.Id && pa.ImageURL == p.ImageURL && pa.LinkURL == p.LinkURL && pa.Title == p.Title && pa.Type == p.Type) == default));
            Assert.IsFalse(data.User.Panels.OfType<ExtensionPanel>().Any(p => panels.OfType<ExtensionPanel>().FirstOrDefault(pa => pa.Id == p.Id && pa.SlotID == p.SlotID && pa.Type == p.Type) == default));
            Assert.IsNotNull(data.User.Self);
            Assert.IsNull(data.User.Self.BanStatus);
        }

        [TestMethod]
        public async Task SendQueryAsync_VideoCommentsByOffsetOrCursorRequest_ShouldReturnData()
        {
            // Arrange
            VideoCommentsByOffsetOrCursorRequest request = new("803755667", 0);

            // Act
            VideoCommentsByOffsetOrCursor data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.Video);

            Assert.AreEqual("803755667", data.Video.Id);
            Assert.AreEqual("12826", data.Video.Creator.Id);
            Assert.AreEqual("12826", data.Video.Creator.Channel.Id);
            Assert.IsTrue(data.Video.Comments.PageInfo.HasNextPage);
            Assert.IsFalse(data.Video.Comments.PageInfo.HasPreviousPage);
            Assert.IsTrue(data.Video.Comments.Edges.All(e => !string.IsNullOrWhiteSpace(e.Cursor)));

            Assert.IsTrue(data.Video.Comments.Edges.Any(e => e.Node.Id == "j3P7zQ6cRxandQ"));
            Assert.IsTrue(data.Video.Comments.Edges.First(e => e.Node.Id == "j3P7zQ6cRxandQ").Node.Commenter.Id == "227398738");
            Assert.IsTrue(data.Video.Comments.Edges.First(e => e.Node.Id == "j3P7zQ6cRxandQ").Node.Commenter.Login == "corndog829");
            Assert.IsTrue(data.Video.Comments.Edges.First(e => e.Node.Id == "j3P7zQ6cRxandQ").Node.Commenter.DisplayName == "corndog829");
            Assert.IsTrue(data.Video.Comments.Edges.First(e => e.Node.Id == "j3P7zQ6cRxandQ").Node.ContentOffsetSeconds == 0);
            Assert.IsTrue(data.Video.Comments.Edges.First(e => e.Node.Id == "j3P7zQ6cRxandQ").Node.CreatedAt == new DateTime(2020, 11, 15, 6, 56, 17, 992, DateTimeKind.Utc));
            Assert.IsTrue(data.Video.Comments.Edges.First(e => e.Node.Id == "j3P7zQ6cRxandQ").Node.Message.Fragments.SingleOrDefault(f => f.Emote == default && f.Text == "gdgfbhfyhghf") != default);
            Assert.IsTrue(data.Video.Comments.Edges.First(e => e.Node.Id == "j3P7zQ6cRxandQ").Node.Message.UserBadges.SingleOrDefault(b => b.Id == "Z2xpdGNoY29uMjAyMDsxOw==" && b.SetID == "glitchcon2020" && b.Version == "1") != default);
            Assert.IsTrue(data.Video.Comments.Edges.First(e => e.Node.Id == "j3P7zQ6cRxandQ").Node.Message.UserColor == "#B22222");
        }

        [TestMethod]
        public async Task SendQueryAsync_VideoPlayerStreamInfoOverlayVODRequest_ShouldReturnData()
        {
            // Arrange
            VideoPlayerStreamInfoOverlayVODRequest request = new("150942279", true);

            // Act
            VideoPlayerStreamInfoOverlayVOD data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.Video);

            Assert.AreEqual("150942279", data.Video.Id);
            Assert.AreEqual("EA PLAY LIVE 2017", data.Video.Title);
            Assert.IsNotNull(data.Video.Owner);
            Assert.AreEqual("12826", data.Video.Owner.Id);
            Assert.AreEqual("twitch", data.Video.Owner.Login);
            Assert.AreEqual("Twitch", data.Video.Owner.DisplayName);
            Assert.AreEqual(new Uri("https://static-cdn.jtvnw.net/jtv_user_pictures/c2178e3b-acad-4d0a-8f85-95240ebd11d2-profile_image-150x150.png"), data.Video.Owner.ProfileImageURL);
            Assert.IsNotNull(data.Video.ContentTags);
            Assert.AreEqual(0, data.Video.ContentTags.Count());
        }

        [TestMethod]
        public async Task SendQueryAsync_CoreActionsCurrentUserRequest_ShouldReturnData()
        {
            // Arrange
            CoreActionsCurrentUserRequest request = new();

            // Act
            CoreActionsCurrentUser data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.CurrentUser);

            Assert.AreEqual("NowaruAlone", data.CurrentUser.DisplayName);
            Assert.AreEqual("54475050", data.CurrentUser.Id);
            Assert.AreEqual("nowarualone", data.CurrentUser.Login);
            Assert.IsNotNull(data.CurrentUser.Roles);
            Assert.IsNull(data.CurrentUser.Roles.IsStaff);

            Assert.IsNotNull(data.CurrentUser.Settings);
            Assert.AreEqual("EN", data.CurrentUser.Settings.PreferredLanguageTag.ToString());
        }

        [TestMethod]
        public async Task SendQueryAsync_RecapTopNav_RecapUserRequest_ShouldReturnData()
        {
            // Arrange
            RecapTopNav_RecapUserRequest request = new();

            // Act
            RecapTopNav_RecapUser data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.CurrentUser);

            Assert.AreEqual("NowaruAlone", data.CurrentUser.DisplayName);
            Assert.AreEqual("54475050", data.CurrentUser.Id);
            Assert.AreEqual("nowarualone", data.CurrentUser.Login);
            Assert.AreEqual(new Uri("https://static-cdn.jtvnw.net/jtv_user_pictures/8d8d23f5-0269-40e7-a537-86fa4bf3e6af-profile_image-70x70.png"), data.CurrentUser.ProfileImageURL);
        }

        [TestMethod]
        public async Task SendQueryAsync_TrackingManager_RequestInfoRequest_ShouldReturnData()
        {
            // Arrange
            TrackingManager_RequestInfoRequest request = new();

            // Act
            TrackingManager_RequestInfo data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.RequestInfo);

            Assert.AreEqual("RU", data.RequestInfo.CountryCode);
            Assert.AreEqual("95.55.214.12", data.RequestInfo.IpAddress);
        }

        [TestMethod]
        public async Task SendQueryAsync_AnnualRecapRequest_ShouldReturnData()
        {
            // Arrange
            AnnualRecapRequest request = new("54475050");

            // Act
            Models.Responses.AnnualRecap data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);

            Assert.IsNotNull(data.CurrentUser);
            Assert.AreEqual("NowaruAlone", data.CurrentUser.DisplayName);
            Assert.AreEqual("54475050", data.CurrentUser.Id);
            Assert.AreEqual("FFBF00", data.CurrentUser.PrimaryColorHex);
            Assert.AreEqual(new Uri("https://static-cdn.jtvnw.net/jtv_user_pictures/8d8d23f5-0269-40e7-a537-86fa4bf3e6af-profile_image-300x300.png"), data.CurrentUser.ProfileImageURL);

            //Assert.IsNotNull(data.AnnualRecap);
            //Assert.IsNotNull(data.AnnualRecap.Creator);
            //Assert.AreEqual(8272, data.AnnualRecap.Creator.TotalHoursViewersWatched);

            //Assert.IsNotNull(data.AnnualRecap.Viewer);

            //Assert.IsNull(data.AnnualRecap.Error);
        }

        [TestMethod]
        public async Task SendQueryAsync_MessageBufferChatHistoryRequest_ShouldReturnData()
        {
            // Arrange
            MessageBufferChatHistoryRequest request = new("twitch");

            // Act
            MessageBufferChatHistory data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);

            Assert.IsNotNull(data.Channel);
            Assert.AreEqual("12826", data.Channel.Id);

            Assert.IsNotNull(data.Channel.RecentChatMessages);
        }


        [TestMethod]
        public async Task SendQueryAsync_ChatList_BadgesRequest_ShouldReturnData()
        {
            // Arrange
            ChatList_BadgesRequest request = new("twitch");

            // Act
            ChatList_Badges data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);

            Assert.IsNotNull(data.Badges);
            Assert.AreEqual(215, data.Badges.Count());
            CollectionAssert.AllItemsAreNotNull((ICollection)data.Badges);

            Assert.IsNotNull(data.User);
            Assert.AreEqual("12826", data.User.Id);
            Assert.IsNull(data.User.PrimaryColorHex);
            Assert.AreEqual(3,data.User.BroadcastBadges.Count());
            CollectionAssert.AllItemsAreNotNull((ICollection)data.User.BroadcastBadges);
            Assert.IsNotNull(data.User.Self);

        }

        #endregion Methods
    }
}