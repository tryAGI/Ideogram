#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Ideogram.V2.JsonConverters
{
    /// <inheritdoc />
    public class LayerizeTextLayerFillJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.V2.LayerizeTextLayerFill>
    {
        /// <inheritdoc />
        public override global::Ideogram.V2.LayerizeTextLayerFill Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerFillDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerFillDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.LayerizeTextLayerFillDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Ideogram.V2.LayerizeTextLayerFillVariant1? solid = default;
            if (discriminator?.Type == global::Ideogram.V2.LayerizeTextLayerFillDiscriminatorType.Solid)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerFillVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerFillVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.LayerizeTextLayerFillVariant1)}");
                solid = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.V2.LayerizeTextLayerFillVariant2? gradient = default;
            if (discriminator?.Type == global::Ideogram.V2.LayerizeTextLayerFillDiscriminatorType.Gradient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerFillVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerFillVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.LayerizeTextLayerFillVariant2)}");
                gradient = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Ideogram.V2.LayerizeTextLayerFill(
                discriminator?.Type,
                solid,

                gradient
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.V2.LayerizeTextLayerFill value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSolid)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerFillVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerFillVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.LayerizeTextLayerFillVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSolid(), typeInfo);
            }
            else if (value.IsGradient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.LayerizeTextLayerFillVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.LayerizeTextLayerFillVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.LayerizeTextLayerFillVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGradient(), typeInfo);
            }
        }
    }
}