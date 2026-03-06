#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextLayerV3AlignmentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.TextLayerV3Alignment>
    {
        /// <inheritdoc />
        public override global::Ideogram.TextLayerV3Alignment Read(
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
                        return global::Ideogram.TextLayerV3AlignmentExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.TextLayerV3Alignment)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.TextLayerV3Alignment);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.TextLayerV3Alignment value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.TextLayerV3AlignmentExtensions.ToValueString(value));
        }
    }
}
