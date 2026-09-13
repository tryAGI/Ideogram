
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Quality), TypeInfoPropertyName = "Quality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason), TypeInfoPropertyName = "GenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GptImage2Quality), TypeInfoPropertyName = "GptImage2Quality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookRequestCategory), TypeInfoPropertyName = "LookbookRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelPoseVariantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelPoseVariantsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotView), TypeInfoPropertyName = "PackshotView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinRequestView), TypeInfoPropertyName = "GhostMannequinRequestView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditModel), TypeInfoPropertyName = "PreciseMaskedEditModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VirtualTryOnResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VirtualTryOnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorwaysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorwaysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequestResolution), TypeInfoPropertyName = "AdResizerRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequestPlatform), TypeInfoPropertyName = "AdResizerRequestPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsRequestVariationType), TypeInfoPropertyName = "AdVariationsRequestVariationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SketchToRenderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SketchToRenderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelSwapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelSwapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MaterialSwapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MaterialSwapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Quality?), TypeInfoPropertyName = "NullableQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason?), TypeInfoPropertyName = "NullableGenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GptImage2Quality?), TypeInfoPropertyName = "NullableGptImage2Quality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookRequestCategory?), TypeInfoPropertyName = "NullableLookbookRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotView?), TypeInfoPropertyName = "NullablePackshotView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinRequestView?), TypeInfoPropertyName = "NullableGhostMannequinRequestView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditModel?), TypeInfoPropertyName = "NullablePreciseMaskedEditModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequestResolution?), TypeInfoPropertyName = "NullableAdResizerRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequestPlatform?), TypeInfoPropertyName = "NullableAdResizerRequestPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsRequestVariationType?), TypeInfoPropertyName = "NullableAdVariationsRequestVariationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType?), TypeInfoPropertyName = "NullableAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AssetIdentifier>))]
    internal sealed partial class EditWorkflowSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditWorkflowSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EditWorkflowSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EditWorkflowSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Ideogram.LookbookRequestCategory)

                    || typeToConvert == typeof(global::Ideogram.LookbookRequestCategory?)

                    || typeToConvert == typeof(global::Ideogram.PackshotView)

                    || typeToConvert == typeof(global::Ideogram.PackshotView?)

                    || typeToConvert == typeof(global::Ideogram.GhostMannequinRequestView)

                    || typeToConvert == typeof(global::Ideogram.GhostMannequinRequestView?)

                    || typeToConvert == typeof(global::Ideogram.PreciseMaskedEditModel)

                    || typeToConvert == typeof(global::Ideogram.PreciseMaskedEditModel?)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestResolution)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestResolution?)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestPlatform)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestPlatform?)

                    || typeToConvert == typeof(global::Ideogram.AdVariationsRequestVariationType)

                    || typeToConvert == typeof(global::Ideogram.AdVariationsRequestVariationType?)

                    || typeToConvert == typeof(global::Ideogram.Quality)

                    || typeToConvert == typeof(global::Ideogram.Quality?)

                    || typeToConvert == typeof(global::Ideogram.AssetType)

                    || typeToConvert == typeof(global::Ideogram.AssetType?)

                    || typeToConvert == typeof(global::Ideogram.GptImage2Quality)

                    || typeToConvert == typeof(global::Ideogram.GptImage2Quality?);
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

                if (typeToConvert == typeof(global::Ideogram.LookbookRequestCategory))
                {
                    return new global::Ideogram.JsonConverters.LookbookRequestCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LookbookRequestCategory?))
                {
                    return new global::Ideogram.JsonConverters.LookbookRequestCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PackshotView))
                {
                    return new global::Ideogram.JsonConverters.PackshotViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PackshotView?))
                {
                    return new global::Ideogram.JsonConverters.PackshotViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GhostMannequinRequestView))
                {
                    return new global::Ideogram.JsonConverters.GhostMannequinRequestViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GhostMannequinRequestView?))
                {
                    return new global::Ideogram.JsonConverters.GhostMannequinRequestViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PreciseMaskedEditModel))
                {
                    return new global::Ideogram.JsonConverters.PreciseMaskedEditModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PreciseMaskedEditModel?))
                {
                    return new global::Ideogram.JsonConverters.PreciseMaskedEditModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdResizerRequestResolution))
                {
                    return new global::Ideogram.JsonConverters.AdResizerRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdResizerRequestResolution?))
                {
                    return new global::Ideogram.JsonConverters.AdResizerRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdResizerRequestPlatform))
                {
                    return new global::Ideogram.JsonConverters.AdResizerRequestPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdResizerRequestPlatform?))
                {
                    return new global::Ideogram.JsonConverters.AdResizerRequestPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdVariationsRequestVariationType))
                {
                    return new global::Ideogram.JsonConverters.AdVariationsRequestVariationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdVariationsRequestVariationType?))
                {
                    return new global::Ideogram.JsonConverters.AdVariationsRequestVariationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.Quality))
                {
                    return new global::Ideogram.JsonConverters.QualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.Quality?))
                {
                    return new global::Ideogram.JsonConverters.QualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType?))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GptImage2Quality))
                {
                    return new global::Ideogram.JsonConverters.GptImage2QualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GptImage2Quality?))
                {
                    return new global::Ideogram.JsonConverters.GptImage2QualityNullableJsonConverter();
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
                    0 => new EditWorkflowSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}