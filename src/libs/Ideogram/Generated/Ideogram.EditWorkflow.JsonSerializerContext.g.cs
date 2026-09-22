
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason), TypeInfoPropertyName = "GenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundQuality), TypeInfoPropertyName = "ReplaceBackgroundQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundIdeogramV3RequestRenderingSpeed), TypeInfoPropertyName = "ReplaceBackgroundIdeogramV3RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookRequestCategory), TypeInfoPropertyName = "LookbookRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelPoseVariantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelPoseVariantsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelPoseVariantsQuality), TypeInfoPropertyName = "ModelPoseVariantsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotView), TypeInfoPropertyName = "PackshotView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotsQuality), TypeInfoPropertyName = "PackshotsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinRequestView), TypeInfoPropertyName = "GhostMannequinRequestView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinQuality), TypeInfoPropertyName = "GhostMannequinQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditModel), TypeInfoPropertyName = "PreciseMaskedEditModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditQuality), TypeInfoPropertyName = "PreciseMaskedEditQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VirtualTryOnResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VirtualTryOnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorwaysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorwaysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorwaysQuality), TypeInfoPropertyName = "ColorwaysQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdLocalizerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdLocalizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdLocalizerRequestLanguage), TypeInfoPropertyName = "AdLocalizerRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdLocalizerQuality), TypeInfoPropertyName = "AdLocalizerQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequestResolution), TypeInfoPropertyName = "AdResizerRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequestPlatform), TypeInfoPropertyName = "AdResizerRequestPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerQuality), TypeInfoPropertyName = "AdResizerQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsRequestVariationType), TypeInfoPropertyName = "AdVariationsRequestVariationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsQuality), TypeInfoPropertyName = "AdVariationsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SketchToRenderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SketchToRenderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SketchToRenderQuality), TypeInfoPropertyName = "SketchToRenderQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SoleSwapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SoleSwapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SoleSwapRequestBaseGenerationSize), TypeInfoPropertyName = "SoleSwapRequestBaseGenerationSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SoleSwapQuality), TypeInfoPropertyName = "SoleSwapQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwapProductResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwapProductRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwapProductMode), TypeInfoPropertyName = "SwapProductMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwapProductQuality), TypeInfoPropertyName = "SwapProductQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SkechersStyleEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SkechersStyleEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SkechersStyleEditRequestAspectRatio), TypeInfoPropertyName = "SkechersStyleEditRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SkechersStyleEditRequestBaseGenerationSize), TypeInfoPropertyName = "SkechersStyleEditRequestBaseGenerationSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SkechersStyleEditQuality), TypeInfoPropertyName = "SkechersStyleEditQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoDesignResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoDesignRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoDesignRequestLogoStyle), TypeInfoPropertyName = "SwanSLogoDesignRequestLogoStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoDesignRequestSourceMode), TypeInfoPropertyName = "SwanSLogoDesignRequestSourceMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoDesignRequestDesignVariant), TypeInfoPropertyName = "SwanSLogoDesignRequestDesignVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoQuality), TypeInfoPropertyName = "SwanSLogoQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoInstallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoInstallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoInstallRequestLogoStyle), TypeInfoPropertyName = "SwanSLogoInstallRequestLogoStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelSwapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelSwapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelSwapQuality), TypeInfoPropertyName = "ModelSwapQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MaterialSwapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MaterialSwapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MaterialSwapQuality), TypeInfoPropertyName = "MaterialSwapQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason?), TypeInfoPropertyName = "NullableGenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundQuality?), TypeInfoPropertyName = "NullableReplaceBackgroundQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundIdeogramV3RequestRenderingSpeed?), TypeInfoPropertyName = "NullableReplaceBackgroundIdeogramV3RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookRequestCategory?), TypeInfoPropertyName = "NullableLookbookRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelPoseVariantsQuality?), TypeInfoPropertyName = "NullableModelPoseVariantsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotView?), TypeInfoPropertyName = "NullablePackshotView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotsQuality?), TypeInfoPropertyName = "NullablePackshotsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinRequestView?), TypeInfoPropertyName = "NullableGhostMannequinRequestView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GhostMannequinQuality?), TypeInfoPropertyName = "NullableGhostMannequinQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditModel?), TypeInfoPropertyName = "NullablePreciseMaskedEditModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditQuality?), TypeInfoPropertyName = "NullablePreciseMaskedEditQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorwaysQuality?), TypeInfoPropertyName = "NullableColorwaysQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdLocalizerRequestLanguage?), TypeInfoPropertyName = "NullableAdLocalizerRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdLocalizerQuality?), TypeInfoPropertyName = "NullableAdLocalizerQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequestResolution?), TypeInfoPropertyName = "NullableAdResizerRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequestPlatform?), TypeInfoPropertyName = "NullableAdResizerRequestPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerQuality?), TypeInfoPropertyName = "NullableAdResizerQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsRequestVariationType?), TypeInfoPropertyName = "NullableAdVariationsRequestVariationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsQuality?), TypeInfoPropertyName = "NullableAdVariationsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SketchToRenderQuality?), TypeInfoPropertyName = "NullableSketchToRenderQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SoleSwapRequestBaseGenerationSize?), TypeInfoPropertyName = "NullableSoleSwapRequestBaseGenerationSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SoleSwapQuality?), TypeInfoPropertyName = "NullableSoleSwapQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwapProductMode?), TypeInfoPropertyName = "NullableSwapProductMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwapProductQuality?), TypeInfoPropertyName = "NullableSwapProductQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SkechersStyleEditRequestAspectRatio?), TypeInfoPropertyName = "NullableSkechersStyleEditRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SkechersStyleEditRequestBaseGenerationSize?), TypeInfoPropertyName = "NullableSkechersStyleEditRequestBaseGenerationSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SkechersStyleEditQuality?), TypeInfoPropertyName = "NullableSkechersStyleEditQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoDesignRequestLogoStyle?), TypeInfoPropertyName = "NullableSwanSLogoDesignRequestLogoStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoDesignRequestSourceMode?), TypeInfoPropertyName = "NullableSwanSLogoDesignRequestSourceMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoDesignRequestDesignVariant?), TypeInfoPropertyName = "NullableSwanSLogoDesignRequestDesignVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoQuality?), TypeInfoPropertyName = "NullableSwanSLogoQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SwanSLogoInstallRequestLogoStyle?), TypeInfoPropertyName = "NullableSwanSLogoInstallRequestLogoStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelSwapQuality?), TypeInfoPropertyName = "NullableModelSwapQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MaterialSwapQuality?), TypeInfoPropertyName = "NullableMaterialSwapQuality2")]
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

                    || typeToConvert == typeof(global::Ideogram.ReplaceBackgroundQuality)

                    || typeToConvert == typeof(global::Ideogram.ReplaceBackgroundQuality?)

                    || typeToConvert == typeof(global::Ideogram.ReplaceBackgroundIdeogramV3RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.ReplaceBackgroundIdeogramV3RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.LookbookRequestCategory)

                    || typeToConvert == typeof(global::Ideogram.LookbookRequestCategory?)

                    || typeToConvert == typeof(global::Ideogram.ModelPoseVariantsQuality)

                    || typeToConvert == typeof(global::Ideogram.ModelPoseVariantsQuality?)

                    || typeToConvert == typeof(global::Ideogram.PackshotView)

                    || typeToConvert == typeof(global::Ideogram.PackshotView?)

                    || typeToConvert == typeof(global::Ideogram.PackshotsQuality)

                    || typeToConvert == typeof(global::Ideogram.PackshotsQuality?)

                    || typeToConvert == typeof(global::Ideogram.GhostMannequinRequestView)

                    || typeToConvert == typeof(global::Ideogram.GhostMannequinRequestView?)

                    || typeToConvert == typeof(global::Ideogram.GhostMannequinQuality)

                    || typeToConvert == typeof(global::Ideogram.GhostMannequinQuality?)

                    || typeToConvert == typeof(global::Ideogram.PreciseMaskedEditModel)

                    || typeToConvert == typeof(global::Ideogram.PreciseMaskedEditModel?)

                    || typeToConvert == typeof(global::Ideogram.PreciseMaskedEditQuality)

                    || typeToConvert == typeof(global::Ideogram.PreciseMaskedEditQuality?)

                    || typeToConvert == typeof(global::Ideogram.ColorwaysQuality)

                    || typeToConvert == typeof(global::Ideogram.ColorwaysQuality?)

                    || typeToConvert == typeof(global::Ideogram.AdLocalizerRequestLanguage)

                    || typeToConvert == typeof(global::Ideogram.AdLocalizerRequestLanguage?)

                    || typeToConvert == typeof(global::Ideogram.AdLocalizerQuality)

                    || typeToConvert == typeof(global::Ideogram.AdLocalizerQuality?)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestResolution)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestResolution?)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestPlatform)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestPlatform?)

                    || typeToConvert == typeof(global::Ideogram.AdResizerQuality)

                    || typeToConvert == typeof(global::Ideogram.AdResizerQuality?)

                    || typeToConvert == typeof(global::Ideogram.AdVariationsRequestVariationType)

                    || typeToConvert == typeof(global::Ideogram.AdVariationsRequestVariationType?)

                    || typeToConvert == typeof(global::Ideogram.AdVariationsQuality)

                    || typeToConvert == typeof(global::Ideogram.AdVariationsQuality?)

                    || typeToConvert == typeof(global::Ideogram.SketchToRenderQuality)

                    || typeToConvert == typeof(global::Ideogram.SketchToRenderQuality?)

                    || typeToConvert == typeof(global::Ideogram.SoleSwapRequestBaseGenerationSize)

                    || typeToConvert == typeof(global::Ideogram.SoleSwapRequestBaseGenerationSize?)

                    || typeToConvert == typeof(global::Ideogram.SoleSwapQuality)

                    || typeToConvert == typeof(global::Ideogram.SoleSwapQuality?)

                    || typeToConvert == typeof(global::Ideogram.SwapProductMode)

                    || typeToConvert == typeof(global::Ideogram.SwapProductMode?)

                    || typeToConvert == typeof(global::Ideogram.SwapProductQuality)

                    || typeToConvert == typeof(global::Ideogram.SwapProductQuality?)

                    || typeToConvert == typeof(global::Ideogram.SkechersStyleEditRequestAspectRatio)

                    || typeToConvert == typeof(global::Ideogram.SkechersStyleEditRequestAspectRatio?)

                    || typeToConvert == typeof(global::Ideogram.SkechersStyleEditRequestBaseGenerationSize)

                    || typeToConvert == typeof(global::Ideogram.SkechersStyleEditRequestBaseGenerationSize?)

                    || typeToConvert == typeof(global::Ideogram.SkechersStyleEditQuality)

                    || typeToConvert == typeof(global::Ideogram.SkechersStyleEditQuality?)

                    || typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestLogoStyle)

                    || typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestLogoStyle?)

                    || typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestSourceMode)

                    || typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestSourceMode?)

                    || typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestDesignVariant)

                    || typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestDesignVariant?)

                    || typeToConvert == typeof(global::Ideogram.SwanSLogoQuality)

                    || typeToConvert == typeof(global::Ideogram.SwanSLogoQuality?)

                    || typeToConvert == typeof(global::Ideogram.SwanSLogoInstallRequestLogoStyle)

                    || typeToConvert == typeof(global::Ideogram.SwanSLogoInstallRequestLogoStyle?)

                    || typeToConvert == typeof(global::Ideogram.ModelSwapQuality)

                    || typeToConvert == typeof(global::Ideogram.ModelSwapQuality?)

                    || typeToConvert == typeof(global::Ideogram.MaterialSwapQuality)

                    || typeToConvert == typeof(global::Ideogram.MaterialSwapQuality?)

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

                if (typeToConvert == typeof(global::Ideogram.ReplaceBackgroundQuality))
                {
                    return new global::Ideogram.JsonConverters.ReplaceBackgroundQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ReplaceBackgroundQuality?))
                {
                    return new global::Ideogram.JsonConverters.ReplaceBackgroundQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ReplaceBackgroundIdeogramV3RequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.ReplaceBackgroundIdeogramV3RequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ReplaceBackgroundIdeogramV3RequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.ReplaceBackgroundIdeogramV3RequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LookbookRequestCategory))
                {
                    return new global::Ideogram.JsonConverters.LookbookRequestCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LookbookRequestCategory?))
                {
                    return new global::Ideogram.JsonConverters.LookbookRequestCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelPoseVariantsQuality))
                {
                    return new global::Ideogram.JsonConverters.ModelPoseVariantsQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelPoseVariantsQuality?))
                {
                    return new global::Ideogram.JsonConverters.ModelPoseVariantsQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PackshotView))
                {
                    return new global::Ideogram.JsonConverters.PackshotViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PackshotView?))
                {
                    return new global::Ideogram.JsonConverters.PackshotViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PackshotsQuality))
                {
                    return new global::Ideogram.JsonConverters.PackshotsQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PackshotsQuality?))
                {
                    return new global::Ideogram.JsonConverters.PackshotsQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GhostMannequinRequestView))
                {
                    return new global::Ideogram.JsonConverters.GhostMannequinRequestViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GhostMannequinRequestView?))
                {
                    return new global::Ideogram.JsonConverters.GhostMannequinRequestViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GhostMannequinQuality))
                {
                    return new global::Ideogram.JsonConverters.GhostMannequinQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GhostMannequinQuality?))
                {
                    return new global::Ideogram.JsonConverters.GhostMannequinQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PreciseMaskedEditModel))
                {
                    return new global::Ideogram.JsonConverters.PreciseMaskedEditModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PreciseMaskedEditModel?))
                {
                    return new global::Ideogram.JsonConverters.PreciseMaskedEditModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PreciseMaskedEditQuality))
                {
                    return new global::Ideogram.JsonConverters.PreciseMaskedEditQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PreciseMaskedEditQuality?))
                {
                    return new global::Ideogram.JsonConverters.PreciseMaskedEditQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ColorwaysQuality))
                {
                    return new global::Ideogram.JsonConverters.ColorwaysQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ColorwaysQuality?))
                {
                    return new global::Ideogram.JsonConverters.ColorwaysQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdLocalizerRequestLanguage))
                {
                    return new global::Ideogram.JsonConverters.AdLocalizerRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdLocalizerRequestLanguage?))
                {
                    return new global::Ideogram.JsonConverters.AdLocalizerRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdLocalizerQuality))
                {
                    return new global::Ideogram.JsonConverters.AdLocalizerQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdLocalizerQuality?))
                {
                    return new global::Ideogram.JsonConverters.AdLocalizerQualityNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.AdResizerQuality))
                {
                    return new global::Ideogram.JsonConverters.AdResizerQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdResizerQuality?))
                {
                    return new global::Ideogram.JsonConverters.AdResizerQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdVariationsRequestVariationType))
                {
                    return new global::Ideogram.JsonConverters.AdVariationsRequestVariationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdVariationsRequestVariationType?))
                {
                    return new global::Ideogram.JsonConverters.AdVariationsRequestVariationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdVariationsQuality))
                {
                    return new global::Ideogram.JsonConverters.AdVariationsQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AdVariationsQuality?))
                {
                    return new global::Ideogram.JsonConverters.AdVariationsQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SketchToRenderQuality))
                {
                    return new global::Ideogram.JsonConverters.SketchToRenderQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SketchToRenderQuality?))
                {
                    return new global::Ideogram.JsonConverters.SketchToRenderQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SoleSwapRequestBaseGenerationSize))
                {
                    return new global::Ideogram.JsonConverters.SoleSwapRequestBaseGenerationSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SoleSwapRequestBaseGenerationSize?))
                {
                    return new global::Ideogram.JsonConverters.SoleSwapRequestBaseGenerationSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SoleSwapQuality))
                {
                    return new global::Ideogram.JsonConverters.SoleSwapQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SoleSwapQuality?))
                {
                    return new global::Ideogram.JsonConverters.SoleSwapQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwapProductMode))
                {
                    return new global::Ideogram.JsonConverters.SwapProductModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwapProductMode?))
                {
                    return new global::Ideogram.JsonConverters.SwapProductModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwapProductQuality))
                {
                    return new global::Ideogram.JsonConverters.SwapProductQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwapProductQuality?))
                {
                    return new global::Ideogram.JsonConverters.SwapProductQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SkechersStyleEditRequestAspectRatio))
                {
                    return new global::Ideogram.JsonConverters.SkechersStyleEditRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SkechersStyleEditRequestAspectRatio?))
                {
                    return new global::Ideogram.JsonConverters.SkechersStyleEditRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SkechersStyleEditRequestBaseGenerationSize))
                {
                    return new global::Ideogram.JsonConverters.SkechersStyleEditRequestBaseGenerationSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SkechersStyleEditRequestBaseGenerationSize?))
                {
                    return new global::Ideogram.JsonConverters.SkechersStyleEditRequestBaseGenerationSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SkechersStyleEditQuality))
                {
                    return new global::Ideogram.JsonConverters.SkechersStyleEditQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SkechersStyleEditQuality?))
                {
                    return new global::Ideogram.JsonConverters.SkechersStyleEditQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestLogoStyle))
                {
                    return new global::Ideogram.JsonConverters.SwanSLogoDesignRequestLogoStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestLogoStyle?))
                {
                    return new global::Ideogram.JsonConverters.SwanSLogoDesignRequestLogoStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestSourceMode))
                {
                    return new global::Ideogram.JsonConverters.SwanSLogoDesignRequestSourceModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestSourceMode?))
                {
                    return new global::Ideogram.JsonConverters.SwanSLogoDesignRequestSourceModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestDesignVariant))
                {
                    return new global::Ideogram.JsonConverters.SwanSLogoDesignRequestDesignVariantJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwanSLogoDesignRequestDesignVariant?))
                {
                    return new global::Ideogram.JsonConverters.SwanSLogoDesignRequestDesignVariantNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwanSLogoQuality))
                {
                    return new global::Ideogram.JsonConverters.SwanSLogoQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwanSLogoQuality?))
                {
                    return new global::Ideogram.JsonConverters.SwanSLogoQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwanSLogoInstallRequestLogoStyle))
                {
                    return new global::Ideogram.JsonConverters.SwanSLogoInstallRequestLogoStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SwanSLogoInstallRequestLogoStyle?))
                {
                    return new global::Ideogram.JsonConverters.SwanSLogoInstallRequestLogoStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelSwapQuality))
                {
                    return new global::Ideogram.JsonConverters.ModelSwapQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelSwapQuality?))
                {
                    return new global::Ideogram.JsonConverters.ModelSwapQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MaterialSwapQuality))
                {
                    return new global::Ideogram.JsonConverters.MaterialSwapQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MaterialSwapQuality?))
                {
                    return new global::Ideogram.JsonConverters.MaterialSwapQualityNullableJsonConverter();
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
                    0 => new EditWorkflowSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}