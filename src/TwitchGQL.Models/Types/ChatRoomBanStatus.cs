using System;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class ChatRoomBanStatus
    {
        /// <summary>
        /// The user being banned of this chat.
        /// </summary>
        [JsonPropertyName("bannedUser")]
        public User BannedUser { get; set; }

        /// <summary>
        /// The time the ban was imposed.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time at which the ban will automatically expire.
        /// </summary>
        [JsonPropertyName("expiresAt")]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The time in ms at which the ban will expire.
        /// </summary>
        [JsonPropertyName("expiresInMs")]
        public int? ExpiresInMs { get; set; }

        /// <summary>
        /// Conveys if the ban is permanent.
        /// </summary>
        [JsonPropertyName("isPermanent")]
        public bool IsPermanent { get; set; }

        /// <summary>
        /// The moderator that carried out the action.
        /// </summary>
        [JsonPropertyName("moderator")]
        public User Moderator { get; set; }

        /// <summary>
        /// The reason the user was banned.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The entity representing the users channel or chat room.
        /// </summary>
        [JsonPropertyName("roomOwner")]
        public User RoomOwner { get; set; }
    }
}