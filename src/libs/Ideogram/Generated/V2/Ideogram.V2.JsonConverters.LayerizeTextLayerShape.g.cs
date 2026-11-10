#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Ideogram.V2.JsonConverters
{
    /// <inheritdoc />
    public class LayerizeTextLayerShapeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.V2.LayerizeTextLayerShape>
    {
        /// <inheritdoc />
        public override global::Ideogram.V2.LayerizeTextLayerShape Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerShapeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerShapeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.LayerizeTextLayerShapeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Ideogram.V2.LayerizeTextLayerShapeVariant1? arc = default;
            if (discriminator?.Type == global::Ideogram.V2.LayerizeTextLayerShapeDiscriminatorType.Arc)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerShapeVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.LayerizeTextLayerShapeVariant1)}");
                arc = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.V2.LayerizeTextLayerShapeVariant2? path = default;
            if (discriminator?.Type == global::Ideogram.V2.LayerizeTextLayerShapeDiscriminatorType.Path)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerShapeVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.LayerizeTextLayerShapeVariant2)}");
                path = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.V2.LayerizeTextLayerShapeVariant3? envelope = default;
            if (discriminator?.Type == global::Ideogram.V2.LayerizeTextLayerShapeDiscriminatorType.Envelope)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerShapeVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.LayerizeTextLayerShapeVariant3)}");
                envelope = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Ideogram.V2.LayerizeTextLayerShape(
                discriminator?.Type,
                arc,

                path,

                envelope
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.V2.LayerizeTextLayerShape value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsArc)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerShapeVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickArc(), typeInfo);
            }
            else if (value.IsPath)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerShapeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPath(), typeInfo);
            }
            else if (value.IsEnvelope)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerShapeVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickEnvelope(), typeInfo);
            }
        }
    }
}