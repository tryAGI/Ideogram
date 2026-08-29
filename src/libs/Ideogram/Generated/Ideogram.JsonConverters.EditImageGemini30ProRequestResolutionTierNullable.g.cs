#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditImageGemini30ProRequestResolutionTierNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.EditImageGemini30ProRequestResolutionTier?>
    {
        /// <inheritdoc />
        public override global::Ideogram.EditImageGemini30ProRequestResolutionTier? Read(
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
                        return global::Ideogram.EditImageGemini30ProRequestResolutionTierExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.EditImageGemini30ProRequestResolutionTier)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.EditImageGemini30ProRequestResolutionTier?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.EditImageGemini30ProRequestResolutionTier? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.EditImageGemini30ProRequestResolutionTierExtensions.ToValueString(value.Value));
            }
        }
    }
}
