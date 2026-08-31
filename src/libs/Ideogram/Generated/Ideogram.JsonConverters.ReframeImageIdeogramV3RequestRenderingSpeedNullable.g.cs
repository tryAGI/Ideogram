#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReframeImageIdeogramV3RequestRenderingSpeedNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed?>
    {
        /// <inheritdoc />
        public override global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed? Read(
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
                        return global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeedExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeedExtensions.ToValueString(value.Value));
            }
        }
    }
}
