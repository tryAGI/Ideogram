#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?>
    {
        /// <inheritdoc />
        public override global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? Read(
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
                        return global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorExtensions.ToValueString(value.Value));
            }
        }
    }
}
