#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class SeedDance25ResolutionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.SeedDance25Resolution>
    {
        /// <inheritdoc />
        public override global::Ideogram.SeedDance25Resolution Read(
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
                        return global::Ideogram.SeedDance25ResolutionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.SeedDance25Resolution)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.SeedDance25Resolution);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.SeedDance25Resolution value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.SeedDance25ResolutionExtensions.ToValueString(value));
        }
    }
}
