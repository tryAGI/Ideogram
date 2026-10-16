#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public class GenerationResponseDataInnerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.GenerationResponseDataInner>
    {
        /// <inheritdoc />
        public override global::Ideogram.GenerationResponseDataInner Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.GenerationResponseDataInnerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Ideogram.GenerationResponseDataInnerVariant1? imageWithoutPromptOrSeed = default;
            if (discriminator?.ObjectType == global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType.ImageWithoutPromptOrSeed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.GenerationResponseDataInnerVariant1)}");
                imageWithoutPromptOrSeed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.GenerationResponseDataInnerVariant2? svgGeneration = default;
            if (discriminator?.ObjectType == global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType.SvgGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.GenerationResponseDataInnerVariant2)}");
                svgGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.GenerationResponseDataInnerVariant3? imageGeneration = default;
            if (discriminator?.ObjectType == global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType.ImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.GenerationResponseDataInnerVariant3)}");
                imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.GenerationResponseDataInnerVariant4? videoGeneration = default;
            if (discriminator?.ObjectType == global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType.VideoGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.GenerationResponseDataInnerVariant4)}");
                videoGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.GenerationResponseDataInnerVariant5? layerizedImage = default;
            if (discriminator?.ObjectType == global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType.LayerizedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.GenerationResponseDataInnerVariant5)}");
                layerizedImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.GenerationResponseDataInnerVariant6? layerizedDesignGeneration = default;
            if (discriminator?.ObjectType == global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType.LayerizedDesignGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.GenerationResponseDataInnerVariant6)}");
                layerizedDesignGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Ideogram.GenerationResponseDataInner(
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
            global::Ideogram.GenerationResponseDataInner value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImageWithoutPromptOrSeed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.GenerationResponseDataInnerVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImageWithoutPromptOrSeed(), typeInfo);
            }
            else if (value.IsSvgGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.GenerationResponseDataInnerVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSvgGeneration(), typeInfo);
            }
            else if (value.IsImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.GenerationResponseDataInnerVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImageGeneration(), typeInfo);
            }
            else if (value.IsVideoGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.GenerationResponseDataInnerVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVideoGeneration(), typeInfo);
            }
            else if (value.IsLayerizedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.GenerationResponseDataInnerVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLayerizedImage(), typeInfo);
            }
            else if (value.IsLayerizedDesignGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.GenerationResponseDataInnerVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.GenerationResponseDataInnerVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.GenerationResponseDataInnerVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLayerizedDesignGeneration(), typeInfo);
            }
        }
    }
}