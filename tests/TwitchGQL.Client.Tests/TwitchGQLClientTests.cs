using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace TwitchGQL.Client.Tests
{
    [TestClass]
    public class TwitchGQLClientTests
    {
        private const string testLogin = "monstercat";
        private readonly ITwitchGQLClient twitchGQLClient;

        public TwitchGQLClientTests()
        {
            twitchGQLClient = new TwitchGQLClient
            {
                ClientId = "kimne78kx3ncx6brgo4mv6wki5h1ko"
            };
        }

        [TestMethod]
        public async Task SendQueryAsync_PlaybackAccessTokenRequest_ShouldReturnData()
        {
            // arrange
            Models.Requests.Templates.PlaybackAccessTokenRequest request = new(login: testLogin);

            // act
            var data = await twitchGQLClient.SendQueryAsync(request).ConfigureAwait(false);

            // assert
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.StreamPlaybackAccessToken);
            Assert.IsFalse(string.IsNullOrWhiteSpace(data.StreamPlaybackAccessToken.Value));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data.StreamPlaybackAccessToken.Signature));
        }
    }
}