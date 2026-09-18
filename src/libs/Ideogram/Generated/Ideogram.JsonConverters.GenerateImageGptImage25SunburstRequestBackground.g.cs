#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateImageGptImage25SunburstRequestBackgroundJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.GenerateImageGptImage25SunburstRequestBackground>
    {
        /// <inheritdoc />
        public override global::Ideogram.GenerateImageGptImage25SunburstRequestBackground Read(
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
                        return global::Ideogram.GenerateImageGptImage25SunburstRequestBackgroundExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.GenerateImageGptImage25SunburstRequestBackground)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.GenerateImageGptImage25SunburstRequestBackground);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.GenerateImageGptImage25SunburstRequestBackground value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.GenerateImageGptImage25SunburstRequestBackgroundExtensions.ToValueString(value));
        }
    }
}
