#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class AdLocalizerRequestLanguageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.AdLocalizerRequestLanguage>
    {
        /// <inheritdoc />
        public override global::Ideogram.AdLocalizerRequestLanguage Read(
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
                        return global::Ideogram.AdLocalizerRequestLanguageExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.AdLocalizerRequestLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.AdLocalizerRequestLanguage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.AdLocalizerRequestLanguage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.AdLocalizerRequestLanguageExtensions.ToValueString(value));
        }
    }
}
