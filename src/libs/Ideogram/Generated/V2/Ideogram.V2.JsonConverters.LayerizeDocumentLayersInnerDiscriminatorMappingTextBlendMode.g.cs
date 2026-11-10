#nullable enable

namespace Ideogram.V2.JsonConverters
{
    /// <inheritdoc />
    public sealed class LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode>
    {
        /// <inheritdoc />
        public override global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode Read(
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
                        return global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendModeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendModeExtensions.ToValueString(value));
        }
    }
}
