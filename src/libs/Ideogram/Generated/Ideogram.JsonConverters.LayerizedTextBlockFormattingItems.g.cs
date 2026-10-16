#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class LayerizedTextBlockFormattingItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.LayerizedTextBlockFormattingItems>
    {
        /// <inheritdoc />
        public override global::Ideogram.LayerizedTextBlockFormattingItems Read(
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
                        return global::Ideogram.LayerizedTextBlockFormattingItemsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.LayerizedTextBlockFormattingItems)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.LayerizedTextBlockFormattingItems);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.LayerizedTextBlockFormattingItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.LayerizedTextBlockFormattingItemsExtensions.ToValueString(value));
        }
    }
}
