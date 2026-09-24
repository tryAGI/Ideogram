#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class IdeogramV3AspectRatioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.IdeogramV3AspectRatio>
    {
        /// <inheritdoc />
        public override global::Ideogram.IdeogramV3AspectRatio Read(
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
                        return global::Ideogram.IdeogramV3AspectRatioExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.IdeogramV3AspectRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.IdeogramV3AspectRatio);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.IdeogramV3AspectRatio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.IdeogramV3AspectRatioExtensions.ToValueString(value));
        }
    }
}
