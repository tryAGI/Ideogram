#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpscaleImageGemini3ProRequestResolutionTierNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.UpscaleImageGemini3ProRequestResolutionTier?>
    {
        /// <inheritdoc />
        public override global::Ideogram.UpscaleImageGemini3ProRequestResolutionTier? Read(
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
                        return global::Ideogram.UpscaleImageGemini3ProRequestResolutionTierExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.UpscaleImageGemini3ProRequestResolutionTier)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.UpscaleImageGemini3ProRequestResolutionTier?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.UpscaleImageGemini3ProRequestResolutionTier? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.UpscaleImageGemini3ProRequestResolutionTierExtensions.ToValueString(value.Value));
            }
        }
    }
}
