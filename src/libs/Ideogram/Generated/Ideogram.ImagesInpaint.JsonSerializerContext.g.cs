
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptOption), TypeInfoPropertyName = "MagicPromptOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV3), TypeInfoPropertyName = "StyleTypeV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StylePresetV3), TypeInfoPropertyName = "StylePresetV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason), TypeInfoPropertyName = "GenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.InpaintedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3RequestRenderingSpeed), TypeInfoPropertyName = "InpaintImageIdeogramV3RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed), TypeInfoPropertyName = "InpaintImageIdeogramV3CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed), TypeInfoPropertyName = "InpaintImageIdeogramV3CharacterRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType), TypeInfoPropertyName = "InpaintImageIdeogramV3CharacterRequestStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptOption?), TypeInfoPropertyName = "NullableMagicPromptOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV3?), TypeInfoPropertyName = "NullableStyleTypeV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StylePresetV3?), TypeInfoPropertyName = "NullableStylePresetV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason?), TypeInfoPropertyName = "NullableGenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3RequestRenderingSpeed?), TypeInfoPropertyName = "NullableInpaintImageIdeogramV3RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed?), TypeInfoPropertyName = "NullableInpaintImageIdeogramV3CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed?), TypeInfoPropertyName = "NullableInpaintImageIdeogramV3CharacterRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType?), TypeInfoPropertyName = "NullableInpaintImageIdeogramV3CharacterRequestStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType?), TypeInfoPropertyName = "NullableAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AssetIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.InpaintedImageObject>))]
    internal sealed partial class ImagesInpaintSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesInpaintSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImagesInpaintSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImagesInpaintSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Ideogram.GenerationRejectReason)

                    || typeToConvert == typeof(global::Ideogram.GenerationRejectReason?)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType?)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptOption)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptOption?)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV3)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV3?)

                    || typeToConvert == typeof(global::Ideogram.StylePresetV3)

                    || typeToConvert == typeof(global::Ideogram.StylePresetV3?)

                    || typeToConvert == typeof(global::Ideogram.AssetType)

                    || typeToConvert == typeof(global::Ideogram.AssetType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Ideogram.GenerationRejectReason))
                {
                    return new global::Ideogram.JsonConverters.GenerationRejectReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationRejectReason?))
                {
                    return new global::Ideogram.JsonConverters.GenerationRejectReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3RequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.InpaintImageIdeogramV3RequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3RequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.InpaintImageIdeogramV3RequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.InpaintImageIdeogramV3CustomModelRequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.InpaintImageIdeogramV3CustomModelRequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.InpaintImageIdeogramV3CharacterRequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.InpaintImageIdeogramV3CharacterRequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType))
                {
                    return new global::Ideogram.JsonConverters.InpaintImageIdeogramV3CharacterRequestStyleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType?))
                {
                    return new global::Ideogram.JsonConverters.InpaintImageIdeogramV3CharacterRequestStyleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptOption))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptOption?))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptOptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleTypeV3))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleTypeV3?))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StylePresetV3))
                {
                    return new global::Ideogram.JsonConverters.StylePresetV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StylePresetV3?))
                {
                    return new global::Ideogram.JsonConverters.StylePresetV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType?))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeNullableJsonConverter();
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
                    0 => new ImagesInpaintSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}