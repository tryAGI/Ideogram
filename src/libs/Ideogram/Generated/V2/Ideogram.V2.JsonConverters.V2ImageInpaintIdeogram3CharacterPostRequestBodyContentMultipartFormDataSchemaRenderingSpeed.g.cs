#nullable enable

namespace Ideogram.V2.JsonConverters
{
    /// <inheritdoc />
    public sealed class V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed>
    {
        /// <inheritdoc />
        public override global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed Read(
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
                        return global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedExtensions.ToValueString(value));
        }
    }
}
