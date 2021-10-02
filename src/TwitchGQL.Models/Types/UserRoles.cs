using System;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// Groups site-wide user roles together.
    /// </summary>
    public class UserRoles
    {
        /// <summary>
        /// Whether or not the user is enrolled in the affiliate program. See <see href="https://affiliate.twitch.tv"/> for more information.
        /// </summary>
        [JsonPropertyName("isAffiliate")]
        public bool IsAffiliate { get; set; }

        /// <summary>
        /// Whether or not the user is allowed to approve extensions on Twitch.
        /// </summary>
        [Obsolete("This role is no longer surfaced through the API")]
        [JsonPropertyName("isExtensionsApprover")]
        public bool IsExtensionsApprover { get; set; }

        /// <summary>
        /// Whether or not the user is enrolled in the extensions developer program. See <see href="https://dev.twitch.tv/docs/extensions/onboarding"/> for more information.
        /// </summary>
        [JsonPropertyName("isExtensionsDeveloper")]
        public bool IsExtensionsDeveloper { get; set; }

        /// <summary>
        /// Whether or not the user can moderate any broadcast chat.
        /// </summary>
        [JsonPropertyName("isGlobalMod")]
        public bool IsGlobalMod { get; set; }

        /// <summary>
        /// Whether or not the user is a partnered broadcaster with Twitch.
        /// </summary>
        [JsonPropertyName("isPartner")]
        public bool IsPartner { get; set; }

        /// <summary>
        /// Whether or not the user is a site admininistrator.
        /// </summary>
        [JsonPropertyName("isSiteAdmin")]
        public bool IsSiteAdmin { get; set; }

        /// <summary>
        /// Whether or not the user is a Twitch staff member.
        /// </summary>
        [JsonPropertyName("isStaff")]
        public bool IsStaff { get; set; }
    }
}