#nullable enable

namespace Ideogram.V2.JsonConverters
{
    /// <inheritdoc />
    public sealed class DetectedTextBlockRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.V2.DetectedTextBlockRole?>
    {
        /// <inheritdoc />
        public override global::Ideogram.V2.DetectedTextBlockRole? Read(
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
                        return global::Ideogram.V2.DetectedTextBlockRoleExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.V2.DetectedTextBlockRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.V2.DetectedTextBlockRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.V2.DetectedTextBlockRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ideogram.V2.DetectedTextBlockRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
