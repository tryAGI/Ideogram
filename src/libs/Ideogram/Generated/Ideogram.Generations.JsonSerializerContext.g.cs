
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseStatus), TypeInfoPropertyName = "GenerationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseResponseType), TypeInfoPropertyName = "GenerationResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.GenerationResponseDataInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInner), TypeInfoPropertyName = "GenerationResponseDataInner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageObjectWithoutPromptOrSeed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType), TypeInfoPropertyName = "ImageObjectWithoutPromptOrSeedObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObjectObjectType), TypeInfoPropertyName = "ImageGenerationObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObjectObjectType), TypeInfoPropertyName = "LayerizedImageObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SvgGenerationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SvgGenerationObjectObjectType), TypeInfoPropertyName = "SvgGenerationObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SvgGenerationObjectMimeType), TypeInfoPropertyName = "SvgGenerationObjectMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoObjectObjectType), TypeInfoPropertyName = "VideoObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockAlignment), TypeInfoPropertyName = "DetectedTextBlockAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlockFormattingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockFormattingItem), TypeInfoPropertyName = "DetectedTextBlockFormattingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockRole), TypeInfoPropertyName = "DetectedTextBlockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerDiscriminatorObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseStatus?), TypeInfoPropertyName = "NullableGenerationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseResponseType?), TypeInfoPropertyName = "NullableGenerationResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInner?), TypeInfoPropertyName = "NullableGenerationResponseDataInner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType?), TypeInfoPropertyName = "NullableImageObjectWithoutPromptOrSeedObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObjectObjectType?), TypeInfoPropertyName = "NullableImageGenerationObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObjectObjectType?), TypeInfoPropertyName = "NullableLayerizedImageObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SvgGenerationObjectObjectType?), TypeInfoPropertyName = "NullableSvgGenerationObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SvgGenerationObjectMimeType?), TypeInfoPropertyName = "NullableSvgGenerationObjectMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoObjectObjectType?), TypeInfoPropertyName = "NullableVideoObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockAlignment?), TypeInfoPropertyName = "NullableDetectedTextBlockAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockFormattingItem?), TypeInfoPropertyName = "NullableDetectedTextBlockFormattingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockRole?), TypeInfoPropertyName = "NullableDetectedTextBlockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType?), TypeInfoPropertyName = "NullableGenerationResponseDataInnerDiscriminatorObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.GenerationResponseDataInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DetectedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DetectedTextBlockFormattingItem>))]
    internal sealed partial class GenerationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GenerationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GenerationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Ideogram.JsonConverters.GenerationResponseDataInnerJsonConverter());
            options.Converters.Add(new global::Ideogram.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Ideogram.GenerationResponseStatus)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseStatus?)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseResponseType)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseResponseType?)

                    || typeToConvert == typeof(global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType)

                    || typeToConvert == typeof(global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType?)

                    || typeToConvert == typeof(global::Ideogram.ImageGenerationObjectObjectType)

                    || typeToConvert == typeof(global::Ideogram.ImageGenerationObjectObjectType?)

                    || typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType)

                    || typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType?)

                    || typeToConvert == typeof(global::Ideogram.SvgGenerationObjectObjectType)

                    || typeToConvert == typeof(global::Ideogram.SvgGenerationObjectObjectType?)

                    || typeToConvert == typeof(global::Ideogram.SvgGenerationObjectMimeType)

                    || typeToConvert == typeof(global::Ideogram.SvgGenerationObjectMimeType?)

                    || typeToConvert == typeof(global::Ideogram.VideoObjectObjectType)

                    || typeToConvert == typeof(global::Ideogram.VideoObjectObjectType?)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockAlignment)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockAlignment?)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockFormattingItem)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockFormattingItem?)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockRole)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockRole?)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Ideogram.GenerationResponseStatus))
                {
                    return new global::Ideogram.JsonConverters.GenerationResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationResponseStatus?))
                {
                    return new global::Ideogram.JsonConverters.GenerationResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationResponseResponseType))
                {
                    return new global::Ideogram.JsonConverters.GenerationResponseResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationResponseResponseType?))
                {
                    return new global::Ideogram.JsonConverters.GenerationResponseResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType))
                {
                    return new global::Ideogram.JsonConverters.ImageObjectWithoutPromptOrSeedObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType?))
                {
                    return new global::Ideogram.JsonConverters.ImageObjectWithoutPromptOrSeedObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ImageGenerationObjectObjectType))
                {
                    return new global::Ideogram.JsonConverters.ImageGenerationObjectObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ImageGenerationObjectObjectType?))
                {
                    return new global::Ideogram.JsonConverters.ImageGenerationObjectObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType))
                {
                    return new global::Ideogram.JsonConverters.LayerizedImageObjectObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType?))
                {
                    return new global::Ideogram.JsonConverters.LayerizedImageObjectObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SvgGenerationObjectObjectType))
                {
                    return new global::Ideogram.JsonConverters.SvgGenerationObjectObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SvgGenerationObjectObjectType?))
                {
                    return new global::Ideogram.JsonConverters.SvgGenerationObjectObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SvgGenerationObjectMimeType))
                {
                    return new global::Ideogram.JsonConverters.SvgGenerationObjectMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SvgGenerationObjectMimeType?))
                {
                    return new global::Ideogram.JsonConverters.SvgGenerationObjectMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.VideoObjectObjectType))
                {
                    return new global::Ideogram.JsonConverters.VideoObjectObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.VideoObjectObjectType?))
                {
                    return new global::Ideogram.JsonConverters.VideoObjectObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockAlignment))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockAlignmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockAlignment?))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockAlignmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockFormattingItem))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockFormattingItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockFormattingItem?))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockFormattingItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockRole))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockRole?))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType))
                {
                    return new global::Ideogram.JsonConverters.GenerationResponseDataInnerDiscriminatorObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType?))
                {
                    return new global::Ideogram.JsonConverters.GenerationResponseDataInnerDiscriminatorObjectTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new GenerationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}