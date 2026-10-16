#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTier?>
    {
        /// <inheritdoc />
        public override global::Ideogram.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTier? Read(
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
                        return global::Ideogram.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTierExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTier)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTier?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTier? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTierExtensions.ToValueString(value.Value));
            }
        }
    }
}
