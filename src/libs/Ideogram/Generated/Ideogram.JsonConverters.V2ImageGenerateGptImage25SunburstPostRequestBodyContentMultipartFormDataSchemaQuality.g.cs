#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality>
    {
        /// <inheritdoc />
        public override global::Ideogram.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality Read(
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
                        return global::Ideogram.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQualityExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQualityExtensions.ToValueString(value));
        }
    }
}
