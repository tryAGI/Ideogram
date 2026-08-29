#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Ideogram.JsonConverters
{
    /// <inheritdoc />
    public class PostGenerateDesignV4200ResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ideogram.PostGenerateDesignV4200Response>
    {
        /// <inheritdoc />
        public override global::Ideogram.PostGenerateDesignV4200Response Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.PostGenerateDesignV4200ResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.PostGenerateDesignV4200ResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.PostGenerateDesignV4200ResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Ideogram.LayeredImageGenerationResponseV3? layered = default;
            if (discriminator?.ResponseType == global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType.Layered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.LayeredImageGenerationResponseV3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.LayeredImageGenerationResponseV3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.LayeredImageGenerationResponseV3)}");
                layered = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ideogram.ImageGenerationResponseV4Layout? url = default;
            if (discriminator?.ResponseType == global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ImageGenerationResponseV4Layout), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ImageGenerationResponseV4Layout> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ideogram.ImageGenerationResponseV4Layout)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Ideogram.PostGenerateDesignV4200Response(
                discriminator?.ResponseType,
                layered,

                url
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ideogram.PostGenerateDesignV4200Response value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLayered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.LayeredImageGenerationResponseV3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.LayeredImageGenerationResponseV3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.LayeredImageGenerationResponseV3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Layered!, typeInfo);
            }
            else if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ideogram.ImageGenerationResponseV4Layout), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ideogram.ImageGenerationResponseV4Layout?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ideogram.ImageGenerationResponseV4Layout).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url!, typeInfo);
            }
        }
    }
}