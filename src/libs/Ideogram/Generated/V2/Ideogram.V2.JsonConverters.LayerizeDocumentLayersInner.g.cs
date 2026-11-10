#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Ideogram.V2.JsonConverters
{
    /// <inheritdoc />
    public class LayerizeDocumentLayersInnerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.V2.LayerizeDocumentLayersInner>
    {
        /// <inheritdoc />
        public override global::Ideogram.V2.LayerizeDocumentLayersInner Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1? image = default;
            if (discriminator?.Type == global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2? text = default;
            if (discriminator?.Type == global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3? container = default;
            if (discriminator?.Type == global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorType.Container)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3)}");
                container = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Ideogram.V2.LayerizeDocumentLayersInner(
                discriminator?.Type,
                image,

                text,

                container
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.V2.LayerizeDocumentLayersInner value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImage(), typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
            else if (value.IsContainer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickContainer(), typeInfo);
            }
        }
    }
}