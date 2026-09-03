#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class IntegrationErrorResponseErrorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.IntegrationErrorResponseError?>
    {
        /// <inheritdoc />
        public override global::Ideogram.IntegrationErrorResponseError? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Ideogram.IntegrationErrorResponseErrorExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.IntegrationErrorResponseError)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.IntegrationErrorResponseError?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.IntegrationErrorResponseError? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.IntegrationErrorResponseErrorExtensions.ToValueString(value.Value));
            }
        }
    }
}
