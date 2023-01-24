namespace TwitchGQL.Models.Requests.Persisted
{
    public class VideoCommentsByOffsetOrCursorRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "VideoCommentsByOffsetOrCursor";
        public const int version = 1;
        public const string sha256Hash = "b70a3591ff0f4e0313d126c6a1502d79a1c02baebb288227c582044aa76adf6a";

        #endregion Fields

        #region Constructors

        public VideoCommentsByOffsetOrCursorRequest(string videoID, int contentOffsetSeconds) : base(null, new { videoID, contentOffsetSeconds }, operationName, version, sha256Hash)
        {
        }

        public VideoCommentsByOffsetOrCursorRequest(string videoID, string cursor) : base(null, new { videoID, cursor }, operationName, version, sha256Hash)
        {
        }

        #endregion Constructors
    }
}