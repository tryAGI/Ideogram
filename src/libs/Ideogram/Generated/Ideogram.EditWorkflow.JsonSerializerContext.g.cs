
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage), TypeInfoPropertyName = "V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdLocalizerQuality), TypeInfoPropertyName = "AdLocalizerQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdLocalizerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution), TypeInfoPropertyName = "V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform), TypeInfoPropertyName = "V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerQuality), TypeInfoPropertyName = "AdResizerQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType), TypeInfoPropertyName = "V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsQuality), TypeInfoPropertyName = "AdVariationsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorwaysQuality), TypeInfoPropertyName = "ColorwaysQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorwaysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView), TypeInfoPropertyName = "V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinQuality), TypeInfoPropertyName = "GhostMannequinQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MaterialSwapQuality), TypeInfoPropertyName = "MaterialSwapQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MaterialSwapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelPoseVariantsQuality), TypeInfoPropertyName = "ModelPoseVariantsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelPoseVariantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SketchToRenderQuality), TypeInfoPropertyName = "SketchToRenderQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SketchToRenderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostAdLocalizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostAdResizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostAdVariationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostColorwaysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostGhostMannequinRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostMaterialSwapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostModelPoseVariantsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostSketchToRenderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason?), TypeInfoPropertyName = "NullableGenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed?), TypeInfoPropertyName = "NullableGenerationErrorResponseTaskCompletionSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage?), TypeInfoPropertyName = "NullableV2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdLocalizerQuality?), TypeInfoPropertyName = "NullableAdLocalizerQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution?), TypeInfoPropertyName = "NullableV2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform?), TypeInfoPropertyName = "NullableV2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerQuality?), TypeInfoPropertyName = "NullableAdResizerQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType?), TypeInfoPropertyName = "NullableV2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsQuality?), TypeInfoPropertyName = "NullableAdVariationsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorwaysQuality?), TypeInfoPropertyName = "NullableColorwaysQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType?), TypeInfoPropertyName = "NullableAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView?), TypeInfoPropertyName = "NullableV2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinQuality?), TypeInfoPropertyName = "NullableGhostMannequinQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MaterialSwapQuality?), TypeInfoPropertyName = "NullableMaterialSwapQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelPoseVariantsQuality?), TypeInfoPropertyName = "NullableModelPoseVariantsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SketchToRenderQuality?), TypeInfoPropertyName = "NullableSketchToRenderQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    internal sealed partial class EditWorkflowSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditWorkflowSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


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

                    || typeToConvert == typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed?)

                    || typeToConvert == typeof(global::Ideogram.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage)

                    || typeToConvert == typeof(global::Ideogram.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage?)

                    || typeToConvert == typeof(global::Ideogram.AdLocalizerQuality)

                    || typeToConvert == typeof(global::Ideogram.AdLocalizerQuality?)

                    || typeToConvert == typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution)

                    || typeToConvert == typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution?)

                    || typeToConvert == typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform)

                    || typeToConvert == typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform?)

                    || typeToConvert == typeof(global::Ideogram.AdResizerQuality)

                    || typeToConvert == typeof(global::Ideogram.AdResizerQuality?)

                    || typeToConvert == typeof(global::Ideogram.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType)

                    || typeToConvert == typeof(global::Ideogram.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType?)

                    || typeToConvert == typeof(global::Ideogram.AdVariationsQuality)

                    || typeToConvert == typeof(global::Ideogram.AdVariationsQuality?)

                    || typeToConvert == typeof(global::Ideogram.ColorwaysQuality)

                    || typeToConvert == typeof(global::Ideogram.ColorwaysQuality?)

                    || typeToConvert == typeof(global::Ideogram.AssetType)

                    || typeToConvert == typeof(global::Ideogram.AssetType?)

                    || typeToConvert == typeof(global::Ideogram.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView)

                    || typeToConvert == typeof(global::Ideogram.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView?)

                    || typeToConvert == typeof(global::Ideogram.GhostMannequinQuality)

                    || typeToConvert == typeof(global::Ideogram.GhostMannequinQuality?)

                    || typeToConvert == typeof(global::Ideogram.MaterialSwapQuality)

                    || typeToConvert == typeof(global::Ideogram.MaterialSwapQuality?)

                    || typeToConvert == typeof(global::Ideogram.ModelPoseVariantsQuality)

                    || typeToConvert == typeof(global::Ideogram.ModelPoseVariantsQuality?)

                    || typeToConvert == typeof(global::Ideogram.SketchToRenderQuality)

                    || typeToConvert == typeof(global::Ideogram.SketchToRenderQuality?);
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

                if (typeToConvert == typeof(global::Ideogram.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage))
                {
                    return new global::Ideogram.JsonConverters.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage?))
                {
                    return new global::Ideogram.JsonConverters.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdLocalizerQuality))
                {
                    return new global::Ideogram.JsonConverters.AdLocalizerQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdLocalizerQuality?))
                {
                    return new global::Ideogram.JsonConverters.AdLocalizerQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution))
                {
                    return new global::Ideogram.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution?))
                {
                    return new global::Ideogram.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform))
                {
                    return new global::Ideogram.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform?))
                {
                    return new global::Ideogram.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdResizerQuality))
                {
                    return new global::Ideogram.JsonConverters.AdResizerQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdResizerQuality?))
                {
                    return new global::Ideogram.JsonConverters.AdResizerQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType))
                {
                    return new global::Ideogram.JsonConverters.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType?))
                {
                    return new global::Ideogram.JsonConverters.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdVariationsQuality))
                {
                    return new global::Ideogram.JsonConverters.AdVariationsQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdVariationsQuality?))
                {
                    return new global::Ideogram.JsonConverters.AdVariationsQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ColorwaysQuality))
                {
                    return new global::Ideogram.JsonConverters.ColorwaysQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ColorwaysQuality?))
                {
                    return new global::Ideogram.JsonConverters.ColorwaysQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType?))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView))
                {
                    return new global::Ideogram.JsonConverters.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView?))
                {
                    return new global::Ideogram.JsonConverters.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GhostMannequinQuality))
                {
                    return new global::Ideogram.JsonConverters.GhostMannequinQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GhostMannequinQuality?))
                {
                    return new global::Ideogram.JsonConverters.GhostMannequinQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MaterialSwapQuality))
                {
                    return new global::Ideogram.JsonConverters.MaterialSwapQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MaterialSwapQuality?))
                {
                    return new global::Ideogram.JsonConverters.MaterialSwapQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelPoseVariantsQuality))
                {
                    return new global::Ideogram.JsonConverters.ModelPoseVariantsQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelPoseVariantsQuality?))
                {
                    return new global::Ideogram.JsonConverters.ModelPoseVariantsQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SketchToRenderQuality))
                {
                    return new global::Ideogram.JsonConverters.SketchToRenderQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SketchToRenderQuality?))
                {
                    return new global::Ideogram.JsonConverters.SketchToRenderQualityNullableJsonConverter();
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