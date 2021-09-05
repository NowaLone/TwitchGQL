using System;
using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Responses.ViewerCardModLogsMessagesBySender
{
    public class ModLogsMessage
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("sentAt")]
        public DateTime SentAt { get; set; }

        [JsonPropertyName("content")]
        public ModLogsMessageContent Content { get; set; }

        [JsonPropertyName("sender")]
        public User Sender { get; set; }
    }
}