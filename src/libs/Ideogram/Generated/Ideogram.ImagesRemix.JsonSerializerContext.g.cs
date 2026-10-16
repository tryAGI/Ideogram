
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason), TypeInfoPropertyName = "GenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed), TypeInfoPropertyName = "GenerationErrorResponseTaskCompletionSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptMode), TypeInfoPropertyName = "MagicPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4), TypeInfoPropertyName = "ResolutionV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV3), TypeInfoPropertyName = "ResolutionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPalettePresetName), TypeInfoPropertyName = "IdeogramColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPaletteWithPresetName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPalette), TypeInfoPropertyName = "IdeogramColorPalette2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV3StyleType), TypeInfoPropertyName = "IdeogramV3StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV3StylePreset), TypeInfoPropertyName = "IdeogramV3StylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3), TypeInfoPropertyName = "AspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageIdeogramV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.RemixedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType), TypeInfoPropertyName = "V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageIdeogramV3CharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageIdeogramV3CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesRemixPostRemixImageV2IdeogramV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesRemixPostRemixImageV2IdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesRemixPostRemixImageV2IdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesRemixPostRemixImageV2IdeogramV3CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason?), TypeInfoPropertyName = "NullableGenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed?), TypeInfoPropertyName = "NullableGenerationErrorResponseTaskCompletionSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptMode?), TypeInfoPropertyName = "NullableMagicPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4?), TypeInfoPropertyName = "NullableResolutionV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV3?), TypeInfoPropertyName = "NullableResolutionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPalettePresetName?), TypeInfoPropertyName = "NullableIdeogramColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPalette?), TypeInfoPropertyName = "NullableIdeogramColorPalette2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV3StyleType?), TypeInfoPropertyName = "NullableIdeogramV3StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV3StylePreset?), TypeInfoPropertyName = "NullableIdeogramV3StylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3?), TypeInfoPropertyName = "NullableAspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?), TypeInfoPropertyName = "NullableV2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?), TypeInfoPropertyName = "NullableV2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?), TypeInfoPropertyName = "NullableV2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType?), TypeInfoPropertyName = "NullableV2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?), TypeInfoPropertyName = "NullableV2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.RemixedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    internal sealed partial class ImagesRemixSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesRemixSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImagesRemixSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImagesRemixSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Ideogram.JsonConverters.IdeogramColorPaletteJsonConverter());
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

                    || typeToConvert == typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed?)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptMode)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptMode?)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV4)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV4?)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV3)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV3?)

                    || typeToConvert == typeof(global::Ideogram.IdeogramColorPalettePresetName)

                    || typeToConvert == typeof(global::Ideogram.IdeogramColorPalettePresetName?)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV3StyleType)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV3StyleType?)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV3StylePreset)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV3StylePreset?)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV3)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV3?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType)

                    || typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?);
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

                if (typeToConvert == typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed))
                {
                    return new global::Ideogram.JsonConverters.GenerationErrorResponseTaskCompletionSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed?))
                {
                    return new global::Ideogram.JsonConverters.GenerationErrorResponseTaskCompletionSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptMode))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptMode?))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV4))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV4JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV4?))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV3))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV3?))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IdeogramColorPalettePresetName))
                {
                    return new global::Ideogram.JsonConverters.IdeogramColorPalettePresetNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IdeogramColorPalettePresetName?))
                {
                    return new global::Ideogram.JsonConverters.IdeogramColorPalettePresetNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IdeogramV3StyleType))
                {
                    return new global::Ideogram.JsonConverters.IdeogramV3StyleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IdeogramV3StyleType?))
                {
                    return new global::Ideogram.JsonConverters.IdeogramV3StyleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IdeogramV3StylePreset))
                {
                    return new global::Ideogram.JsonConverters.IdeogramV3StylePresetJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IdeogramV3StylePreset?))
                {
                    return new global::Ideogram.JsonConverters.IdeogramV3StylePresetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV3))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV3?))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType))
                {
                    return new global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter();
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
                    0 => new ImagesRemixSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}