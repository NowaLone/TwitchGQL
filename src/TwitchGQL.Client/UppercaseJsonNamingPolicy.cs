using System.Text.Json;

namespace TwitchGQL.Client
{
    internal class UppercaseJsonNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name) => $"{name.ToUpper()}";
    }
}