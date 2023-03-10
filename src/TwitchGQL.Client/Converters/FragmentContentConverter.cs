using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Types;
using TwitchGQL.Models.Unions;

namespace TwitchGQL.Client.Converters
{
    internal class FragmentContentConverter : JsonConverter<IFragmentContent>
    {
        public override IFragmentContent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Utf8JsonReader readerClone = reader;
            string type = null;
            do
            {
                if (readerClone.TokenType == JsonTokenType.PropertyName)
                {
                    string propertyName = readerClone.GetString();
                    if (propertyName == "__typename")
                    {
                        readerClone.Read();
                        if (readerClone.TokenType == JsonTokenType.String)
                        {
                            type = readerClone.GetString();
                            break;
                        }
                    }
                }
            } while (readerClone.Read());

            switch (type)
            {
                case nameof(Emote):
                    return JsonSerializer.Deserialize<Emote>(ref reader, options);

                default:
                    throw new JsonException();
            }
        }

        public override void Write(Utf8JsonWriter writer, IFragmentContent value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}