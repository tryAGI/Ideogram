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

            global::Ideogram.ImageObjectWithoutPromptOrSeed? imageWithoutPromptOrSeed = default;
            if (discriminator?.ObjectType == global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType.ImageWithoutPromptOrSeed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ImageObjectWithoutPromptOrSeed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ImageObjectWithoutPromptOrSeed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.ImageObjectWithoutPromptOrSeed)}");
                imageWithoutPromptOrSeed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.ImageGenerationObject? imageGeneration = default;
            if (discriminator?.ObjectType == global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType.ImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ImageGenerationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ImageGenerationObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.ImageGenerationObject)}");
                imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.VideoObject? videoGeneration = default;
            if (discriminator?.ObjectType == global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType.VideoGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.VideoObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.VideoObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.VideoObject)}");
                videoGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.LayerizedImageObject? layerizedImage = default;
            if (discriminator?.ObjectType == global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType.LayerizedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.LayerizedImageObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.LayerizedImageObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.LayerizedImageObject)}");
                layerizedImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Ideogram.GenerationResponseDataInner(
                discriminator?.ObjectType,
                imageWithoutPromptOrSeed,

                imageGeneration,

                videoGeneration,

                layerizedImage
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ImageObjectWithoutPromptOrSeed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ImageObjectWithoutPromptOrSeed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.ImageObjectWithoutPromptOrSeed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageWithoutPromptOrSeed!, typeInfo);
            }
            else if (value.IsImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ImageGenerationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ImageGenerationObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.ImageGenerationObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGeneration!, typeInfo);
            }
            else if (value.IsVideoGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.VideoObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.VideoObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.VideoObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoGeneration!, typeInfo);
            }
            else if (value.IsLayerizedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.LayerizedImageObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.LayerizedImageObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.LayerizedImageObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LayerizedImage!, typeInfo);
            }
        }
    }
}