using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TwitchGQL.Models.Interfaces;
using TwitchGQL.Models.Types;

namespace TwitchGQL.Client.Converters
{
    internal class PanelConverter : JsonConverter<IPanel>
    {
        public override IPanel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
                case nameof(DefaultPanel):
                    return JsonSerializer.Deserialize<DefaultPanel>(ref reader, options);

                case nameof(ExtensionPanel):
                    return JsonSerializer.Deserialize<ExtensionPanel>(ref reader, options);

                default:
                    throw new JsonException();
            }
        }

        public override void Write(Utf8JsonWriter writer, IPanel value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}