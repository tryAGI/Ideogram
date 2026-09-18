#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateImageIdeogramV3TransparentRequestUpscaleFactorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor?>
    {
        /// <inheritdoc />
        public override global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor? Read(
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
                        return global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactorExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactorExtensions.ToValueString(value.Value));
            }
        }
    }
}
