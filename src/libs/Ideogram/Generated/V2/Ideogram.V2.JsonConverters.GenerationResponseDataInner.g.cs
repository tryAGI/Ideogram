#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Ideogram.V2.JsonConverters
{
    /// <inheritdoc />
    public class GenerationResponseDataInnerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.V2.GenerationResponseDataInner>
    {
        /// <inheritdoc />
        public override global::Ideogram.V2.GenerationResponseDataInner Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.GenerationResponseDataInnerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Ideogram.V2.GenerationResponseDataInnerVariant1? imageWithoutPromptOrSeed = default;
            if (discriminator?.ObjectType == global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorObjectType.ImageWithoutPromptOrSeed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.GenerationResponseDataInnerVariant1)}");
                imageWithoutPromptOrSeed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.V2.GenerationResponseDataInnerVariant2? svgGeneration = default;
            if (discriminator?.ObjectType == global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorObjectType.SvgGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.GenerationResponseDataInnerVariant2)}");
                svgGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.V2.GenerationResponseDataInnerVariant3? imageGeneration = default;
            if (discriminator?.ObjectType == global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorObjectType.ImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.GenerationResponseDataInnerVariant3)}");
                imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.V2.GenerationResponseDataInnerVariant4? videoGeneration = default;
            if (discriminator?.ObjectType == global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorObjectType.VideoGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.GenerationResponseDataInnerVariant4)}");
                videoGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.V2.GenerationResponseDataInnerVariant5? layerizedImage = default;
            if (discriminator?.ObjectType == global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorObjectType.LayerizedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.GenerationResponseDataInnerVariant5)}");
                layerizedImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.V2.GenerationResponseDataInnerVariant6? layerizedDesignGeneration = default;
            if (discriminator?.ObjectType == global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorObjectType.LayerizedDesignGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.V2.GenerationResponseDataInnerVariant6)}");
                layerizedDesignGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Ideogram.V2.GenerationResponseDataInner(
                discriminator?.ObjectType,
                imageWithoutPromptOrSeed,

                svgGeneration,

                imageGeneration,

                videoGeneration,

                layerizedImage,

                layerizedDesignGeneration
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.V2.GenerationResponseDataInner value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImageWithoutPromptOrSeed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImageWithoutPromptOrSeed(), typeInfo);
            }
            else if (value.IsSvgGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSvgGeneration(), typeInfo);
            }
            else if (value.IsImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImageGeneration(), typeInfo);
            }
            else if (value.IsVideoGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVideoGeneration(), typeInfo);
            }
            else if (value.IsLayerizedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLayerizedImage(), typeInfo);
            }
            else if (value.IsLayerizedDesignGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.V2.GenerationResponseDataInnerVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLayerizedDesignGeneration(), typeInfo);
            }
        }
    }
}