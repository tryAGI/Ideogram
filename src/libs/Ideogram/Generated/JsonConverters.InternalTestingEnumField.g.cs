#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class InternalTestingEnumFieldJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.InternalTestingEnumField>
    {
        /// <inheritdoc />
        public override global::Ideogram.InternalTestingEnumField Read(
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
                        return global::Ideogram.InternalTestingEnumFieldExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.InternalTestingEnumField)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.InternalTestingEnumField value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.InternalTestingEnumFieldExtensions.ToValueString(value));
        }
    }
}
