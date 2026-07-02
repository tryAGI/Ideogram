#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public class V4PromptElementJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.V4PromptElement>
    {
        /// <inheritdoc />
        public override global::Ideogram.V4PromptElement Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V4PromptElementDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V4PromptElementDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V4PromptElementDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Ideogram.V4ObjPromptElement? obj = default;
            if (discriminator?.Type == global::Ideogram.V4PromptElementDiscriminatorType.Obj)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V4ObjPromptElement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V4ObjPromptElement> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V4ObjPromptElement)}");
                obj = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.V4TextPromptElement? text = default;
            if (discriminator?.Type == global::Ideogram.V4PromptElementDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V4TextPromptElement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V4TextPromptElement> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V4TextPromptElement)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Ideogram.V4PromptElement(
                discriminator?.Type,
                obj,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.V4PromptElement value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsObj)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V4ObjPromptElement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V4ObjPromptElement?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V4ObjPromptElement).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Obj!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V4TextPromptElement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V4TextPromptElement?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V4TextPromptElement).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}