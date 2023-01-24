namespace TwitchGQL.Models.Requests.Persisted
{
    public class VideoPlayerStreamInfoOverlayVODRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "VideoPlayerStreamInfoOverlayVOD";
        public const int version = 1;
        public const string sha256Hash = "682ddbe13e290d601bc500b961da5ea24c5d6193c9cef70bae1d9b520dca24b0";

        #endregion Fields

        #region Constructors

        public VideoPlayerStreamInfoOverlayVODRequest(string videoID, bool includePrivate) : base(null, new { videoID, includePrivate }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}