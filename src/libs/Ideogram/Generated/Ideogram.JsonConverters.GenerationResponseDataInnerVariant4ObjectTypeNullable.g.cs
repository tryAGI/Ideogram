#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationResponseDataInnerVariant4ObjectTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.GenerationResponseDataInnerVariant4ObjectType?>
    {
        /// <inheritdoc />
        public override global::Ideogram.GenerationResponseDataInnerVariant4ObjectType? Read(
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
                        return global::Ideogram.GenerationResponseDataInnerVariant4ObjectTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.GenerationResponseDataInnerVariant4ObjectType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.GenerationResponseDataInnerVariant4ObjectType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.GenerationResponseDataInnerVariant4ObjectType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.GenerationResponseDataInnerVariant4ObjectTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
