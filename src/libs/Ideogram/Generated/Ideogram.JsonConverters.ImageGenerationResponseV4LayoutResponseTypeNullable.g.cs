#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageGenerationResponseV4LayoutResponseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.ImageGenerationResponseV4LayoutResponseType?>
    {
        /// <inheritdoc />
        public override global::Ideogram.ImageGenerationResponseV4LayoutResponseType? Read(
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
                        return global::Ideogram.ImageGenerationResponseV4LayoutResponseTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.ImageGenerationResponseV4LayoutResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.ImageGenerationResponseV4LayoutResponseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.ImageGenerationResponseV4LayoutResponseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.ImageGenerationResponseV4LayoutResponseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
