#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationResponseDataInnerVariant3ObjectTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.GenerationResponseDataInnerVariant3ObjectType>
    {
        /// <inheritdoc />
        public override global::Ideogram.GenerationResponseDataInnerVariant3ObjectType Read(
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
                        return global::Ideogram.GenerationResponseDataInnerVariant3ObjectTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.GenerationResponseDataInnerVariant3ObjectType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.GenerationResponseDataInnerVariant3ObjectType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.GenerationResponseDataInnerVariant3ObjectType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.GenerationResponseDataInnerVariant3ObjectTypeExtensions.ToValueString(value));
        }
    }
}
