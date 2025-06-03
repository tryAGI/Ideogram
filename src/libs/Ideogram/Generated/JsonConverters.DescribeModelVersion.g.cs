#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class DescribeModelVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.DescribeModelVersion>
    {
        /// <inheritdoc />
        public override global::Ideogram.DescribeModelVersion Read(
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
                        return global::Ideogram.DescribeModelVersionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.DescribeModelVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.DescribeModelVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.DescribeModelVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.DescribeModelVersionExtensions.ToValueString(value));
        }
    }
}
