#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageGenerationResponseV4ImageToImageResponseTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType>
    {
        /// <inheritdoc />
        public override global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType Read(
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
                        return global::Ideogram.ImageGenerationResponseV4ImageToImageResponseTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.ImageGenerationResponseV4ImageToImageResponseTypeExtensions.ToValueString(value));
        }
    }
}
