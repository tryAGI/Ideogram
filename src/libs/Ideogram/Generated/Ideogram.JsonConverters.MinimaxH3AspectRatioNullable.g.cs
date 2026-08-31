#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class MinimaxH3AspectRatioNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.MinimaxH3AspectRatio?>
    {
        /// <inheritdoc />
        public override global::Ideogram.MinimaxH3AspectRatio? Read(
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
                        return global::Ideogram.MinimaxH3AspectRatioExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.MinimaxH3AspectRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.MinimaxH3AspectRatio?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.MinimaxH3AspectRatio? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.MinimaxH3AspectRatioExtensions.ToValueString(value.Value));
            }
        }
    }
}
