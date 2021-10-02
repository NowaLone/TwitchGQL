using System.Text.Json.Serialization;

namespace TwitchGQL.Models.Types
{
    /// <summary>
    /// PageInfo is a special field which contains information about the page, specifically the cursors which the page starts and ends, and whether or not the client can forward-paginate or backward-paginate. This is part of the Relay Cursor Connections Specification: <see href="https://facebook.github.io/relay/graphql/connections.htm"/>.
    /// </summary>
    public class PageInfo
    {
        [JsonPropertyName("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonPropertyName("hasPreviousPage")]
        public bool HasPreviousPage { get; set; }
    }
}