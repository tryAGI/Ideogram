#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class RemixImageIdeogramV4RequestRenderingSpeedNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed?>
    {
        /// <inheritdoc />
        public override global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed? Read(
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
                        return global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeedExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeedExtensions.ToValueString(value.Value));
            }
        }
    }
}
