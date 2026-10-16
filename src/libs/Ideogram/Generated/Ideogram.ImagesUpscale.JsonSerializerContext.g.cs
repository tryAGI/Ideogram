
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.UpscaleImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageNanoBananaProResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageTopazBloom2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection), TypeInfoPropertyName = "V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageTopazRedefineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection), TypeInfoPropertyName = "V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageTopazStandardV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection), TypeInfoPropertyName = "V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageTopazTextRefineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength), TypeInfoPropertyName = "V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageTopazWonder35Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageNanoBananaProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageTopazBloom2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageTopazRedefineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageTopazStandardV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageTopazTextRefineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageTopazWonder35Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason?), TypeInfoPropertyName = "NullableGenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed?), TypeInfoPropertyName = "NullableGenerationErrorResponseTaskCompletionSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier?), TypeInfoPropertyName = "NullableV2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?), TypeInfoPropertyName = "NullableV2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?), TypeInfoPropertyName = "NullableV2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection?), TypeInfoPropertyName = "NullableV2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?), TypeInfoPropertyName = "NullableV2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection?), TypeInfoPropertyName = "NullableV2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?), TypeInfoPropertyName = "NullableV2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection?), TypeInfoPropertyName = "NullableV2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?), TypeInfoPropertyName = "NullableV2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength?), TypeInfoPropertyName = "NullableV2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.UpscaleImageObject>))]
    internal sealed partial class ImagesUpscaleSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesUpscaleSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImagesUpscaleSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImagesUpscaleSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength)

                    || typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength?);
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

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrengthJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength?))
                {
                    return new global::Ideogram.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrengthNullableJsonConverter();
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
                    0 => new ImagesUpscaleSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}