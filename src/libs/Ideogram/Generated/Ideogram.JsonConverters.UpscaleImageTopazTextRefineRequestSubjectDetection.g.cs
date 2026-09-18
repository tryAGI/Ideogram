#nullable enable

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpscaleImageTopazTextRefineRequestSubjectDetectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.UpscaleImageTopazTextRefineRequestSubjectDetection>
    {
        /// <inheritdoc />
        public override global::Ideogram.UpscaleImageTopazTextRefineRequestSubjectDetection Read(
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
                        return global::Ideogram.UpscaleImageTopazTextRefineRequestSubjectDetectionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ideogram.UpscaleImageTopazTextRefineRequestSubjectDetection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ideogram.UpscaleImageTopazTextRefineRequestSubjectDetection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.UpscaleImageTopazTextRefineRequestSubjectDetection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ideogram.UpscaleImageTopazTextRefineRequestSubjectDetectionExtensions.ToValueString(value));
        }
    }
}
