#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public class ColorPaletteWithPresetNameOrMembersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.ColorPaletteWithPresetNameOrMembers>
    {
        /// <inheritdoc />
        public override global::Ideogram.ColorPaletteWithPresetNameOrMembers Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Ideogram.ColorPaletteWithPresetName?  = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ColorPaletteWithPresetName), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ColorPaletteWithPresetName> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.ColorPaletteWithPresetName).Name}");
                 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Ideogram.ColorPaletteWithMembers?  = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ColorPaletteWithMembers), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ColorPaletteWithMembers> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.ColorPaletteWithMembers).Name}");
                 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Ideogram.ColorPaletteWithPresetNameOrMembers(
                ,
                );

            if ( != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ColorPaletteWithPresetName), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ColorPaletteWithPresetName> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.ColorPaletteWithPresetName).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if ( != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ColorPaletteWithMembers), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ColorPaletteWithMembers> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.ColorPaletteWithMembers).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.Is)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ColorPaletteWithPresetName), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ColorPaletteWithPresetName?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.ColorPaletteWithPresetName).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value., typeInfo);
            }
            else if (value.Is)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ColorPaletteWithMembers), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ColorPaletteWithMembers?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.ColorPaletteWithMembers).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value., typeInfo);
            }
        }
    }
}