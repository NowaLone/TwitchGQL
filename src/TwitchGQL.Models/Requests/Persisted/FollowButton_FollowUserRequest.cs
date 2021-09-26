﻿namespace TwitchGQL.Models.Requests.Persisted
{
    public class FollowButton_FollowUserRequest : BaseTwitchGraphQLRequest
    {
        #region Fields

        public const string operationName = "FollowButton_FollowUser";
        public const string sha256Hash = "14319edb840c1dfce880dc64fa28a1f4eb69d821901e9e96eb9610d2e52b54f2";

        #endregion Fields

        #region Constructors

        public FollowButton_FollowUserRequest(bool disableNotifications, string targetID) : base(null, new { input = new { disableNotifications, targetID } }, operationName, 1, sha256Hash)
        {
        }

        #endregion Constructors
    }
}