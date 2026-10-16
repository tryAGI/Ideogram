
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Ideogram.JsonConverters.V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationKindJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationKindNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationRejectReasonJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationRejectReasonNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationErrorResponseTaskCompletionSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationErrorResponseTaskCompletionSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.MagicPromptModeJsonConverter),

            typeof(global::Ideogram.JsonConverters.MagicPromptModeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaBackgroundJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaBackgroundNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ResolutionV4JsonConverter),

            typeof(global::Ideogram.JsonConverters.ResolutionV4NullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV4RequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV4RequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV4CustomModelRequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV4CustomModelRequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramV4AspectRatioJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramV4AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV4TransparentRequestOutputResolutionJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV4TransparentRequestOutputResolutionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV4TransparentRequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV4TransparentRequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ResolutionV3JsonConverter),

            typeof(global::Ideogram.JsonConverters.ResolutionV3NullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramV3AspectRatioJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramV3AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramColorPalettePresetNameJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramColorPalettePresetNameNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramV3StyleTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramV3StyleTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramV3StylePresetJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramV3StylePresetNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV3TransparentRequestUpscaleFactorJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV3TransparentRequestUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV3TransparentRequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV3TransparentRequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV2ARequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV2ARequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramV2StyleTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramV2StyleTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV2RequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImageIdeogramV2RequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackgroundJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackgroundNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackgroundJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackgroundNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.NanoBanana2AspectRatioJsonConverter),

            typeof(global::Ideogram.JsonConverters.NanoBanana2AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.NanoBanana21AspectRatioJsonConverter),

            typeof(global::Ideogram.JsonConverters.NanoBanana21AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.NanoBananaProAspectRatioJsonConverter),

            typeof(global::Ideogram.JsonConverters.NanoBananaProAspectRatioNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImagePImageIdeogramRequestResolutionJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerateImagePImageIdeogramRequestResolutionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.AspectRatioV3JsonConverter),

            typeof(global::Ideogram.JsonConverters.AspectRatioV3NullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.NanoBanana2ReframeAspectRatioJsonConverter),

            typeof(global::Ideogram.JsonConverters.NanoBanana2ReframeAspectRatioNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetectionJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetectionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrengthJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrengthNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ReplaceBackgroundQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.ReplaceBackgroundQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V4ObjPromptElementTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.V4ObjPromptElementTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V4TextPromptElementTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.V4TextPromptElementTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V4PromptElementDiscriminatorTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.V4PromptElementDiscriminatorTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.DetectedTextBlockAlignmentJsonConverter),

            typeof(global::Ideogram.JsonConverters.DetectedTextBlockAlignmentNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.DetectedTextBlockFormattingItemsJsonConverter),

            typeof(global::Ideogram.JsonConverters.DetectedTextBlockFormattingItemsNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.DetectedTextBlockRoleJsonConverter),

            typeof(global::Ideogram.JsonConverters.DetectedTextBlockRoleNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.KlingV3ShotTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.KlingV3ShotTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.KlingV3AspectRatioJsonConverter),

            typeof(global::Ideogram.JsonConverters.KlingV3AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.MinimaxH3ResolutionJsonConverter),

            typeof(global::Ideogram.JsonConverters.MinimaxH3ResolutionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.MinimaxH3AspectRatioJsonConverter),

            typeof(global::Ideogram.JsonConverters.MinimaxH3AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.MinimaxH3PromptExpansionModeJsonConverter),

            typeof(global::Ideogram.JsonConverters.MinimaxH3PromptExpansionModeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.SeedDance25ResolutionJsonConverter),

            typeof(global::Ideogram.JsonConverters.SeedDance25ResolutionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.SeedDance2AspectRatioJsonConverter),

            typeof(global::Ideogram.JsonConverters.SeedDance2AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.SeedDance2ResolutionJsonConverter),

            typeof(global::Ideogram.JsonConverters.SeedDance2ResolutionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguageJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguageNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.AdLocalizerQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.AdLocalizerQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolutionJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolutionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatformJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatformNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.AdResizerQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.AdResizerQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.AdVariationsQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.AdVariationsQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ColorwaysQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.ColorwaysQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.AssetTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.AssetTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaViewJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaViewNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GhostMannequinQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.GhostMannequinQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.MaterialSwapQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.MaterialSwapQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ModelPoseVariantsQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.ModelPoseVariantsQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.SketchToRenderQualityJsonConverter),

            typeof(global::Ideogram.JsonConverters.SketchToRenderQualityNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseStatusJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseStatusNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseResponseTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseResponseTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.LayerizedTextBlockAlignmentJsonConverter),

            typeof(global::Ideogram.JsonConverters.LayerizedTextBlockAlignmentNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.LayerizedTextBlockFormattingItemsJsonConverter),

            typeof(global::Ideogram.JsonConverters.LayerizedTextBlockFormattingItemsNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.LayerizedTextBlockRoleJsonConverter),

            typeof(global::Ideogram.JsonConverters.LayerizedTextBlockRoleNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant1ObjectTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant1ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant2ObjectTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant2ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant3ObjectTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant3ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant4ObjectTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant4ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant5ObjectTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant5ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant6ObjectTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant6ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerDiscriminatorObjectTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerDiscriminatorObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.AccountApiKeyStatusJsonConverter),

            typeof(global::Ideogram.JsonConverters.AccountApiKeyStatusNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.AccountInvoiceStatusJsonConverter),

            typeof(global::Ideogram.JsonConverters.AccountInvoiceStatusNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2AccountUsageGetParametersBucketWidthJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2AccountUsageGetParametersBucketWidthNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2AccountUsageGetParametersSourcesSchemaItemsJsonConverter),

            typeof(global::Ideogram.JsonConverters.V2AccountUsageGetParametersSourcesSchemaItemsNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.AccountUsageLineItemSourceJsonConverter),

            typeof(global::Ideogram.JsonConverters.AccountUsageLineItemSourceNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.IdeogramColorPaletteJsonConverter),

            typeof(global::Ideogram.JsonConverters.V4PromptElementJsonConverter),

            typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerJsonConverter),

            typeof(global::Ideogram.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality), TypeInfoPropertyName = "V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationKind), TypeInfoPropertyName = "GenerationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GeneratedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseEditImageIdeogram45Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.GeneratedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason), TypeInfoPropertyName = "GenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponseTaskCompletionSpeed), TypeInfoPropertyName = "GenerationErrorResponseTaskCompletionSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptMode), TypeInfoPropertyName = "MagicPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageV2AutoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaBackground), TypeInfoPropertyName = "V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality), TypeInfoPropertyName = "V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogram45Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4), TypeInfoPropertyName = "ResolutionV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV4RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV4CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV4AspectRatio), TypeInfoPropertyName = "IdeogramV4AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution), TypeInfoPropertyName = "GenerateImageIdeogramV4TransparentRequestOutputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV4TransparentRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV3), TypeInfoPropertyName = "ResolutionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV3AspectRatio), TypeInfoPropertyName = "IdeogramV3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageGenerateIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPalettePresetName), TypeInfoPropertyName = "IdeogramColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPaletteWithPresetName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPalette), TypeInfoPropertyName = "IdeogramColorPalette2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV3StyleType), TypeInfoPropertyName = "IdeogramV3StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV3StylePreset), TypeInfoPropertyName = "IdeogramV3StylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType), TypeInfoPropertyName = "V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor), TypeInfoPropertyName = "GenerateImageIdeogramV3TransparentRequestUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV3TransparentRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV2ARequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV2StyleType), TypeInfoPropertyName = "IdeogramV2StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2ARequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2AResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV2RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground), TypeInfoPropertyName = "V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality), TypeInfoPropertyName = "V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25FlareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground), TypeInfoPropertyName = "V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality), TypeInfoPropertyName = "V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25SunburstResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.NanoBanana2AspectRatio), TypeInfoPropertyName = "NanoBanana2AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageNanoBanana2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.NanoBanana21AspectRatio), TypeInfoPropertyName = "NanoBanana21AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageNanoBanana21Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.NanoBananaProAspectRatio), TypeInfoPropertyName = "NanoBananaProAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageNanoBananaProResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationQuality), TypeInfoPropertyName = "GenerationQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImagePImageIdeogramRequestResolution), TypeInfoPropertyName = "GenerateImagePImageIdeogramRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3), TypeInfoPropertyName = "AspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImagePImageIdeogramRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImagePImageIdeogramResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageZImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageZImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolRemixResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.InpaintedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType), TypeInfoPropertyName = "V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.NanoBanana2ReframeAspectRatio), TypeInfoPropertyName = "NanoBanana2ReframeAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageNanoBanana2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleToolResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundQuality), TypeInfoPropertyName = "ReplaceBackgroundQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.BackgroundRemovedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveBackgroundV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.BackgroundRemovedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveObjectFromV2AssetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4StyleDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4ObjPromptElementType), TypeInfoPropertyName = "V4ObjPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4TextPromptElementType), TypeInfoPropertyName = "V4TextPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElement), TypeInfoPropertyName = "V4PromptElement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElementVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElementVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElementDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElementDiscriminatorType), TypeInfoPropertyName = "V4PromptElementDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4CompositionalDeconstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V4PromptElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4JsonPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DescribeImageIdeogramV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageSafetyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GeneratedDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DescribeImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.GeneratedDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockAlignment), TypeInfoPropertyName = "DetectedTextBlockAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockFormattingItems), TypeInfoPropertyName = "DetectedTextBlockFormattingItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockRole), TypeInfoPropertyName = "DetectedTextBlockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlockFormattingItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizeDesignIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.LayerizedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.KlingV3ShotType), TypeInfoPropertyName = "KlingV3ShotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoKlingV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.KlingV3AspectRatio), TypeInfoPropertyName = "KlingV3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoKlingV3StandardTextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3Resolution), TypeInfoPropertyName = "MinimaxH3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoMinimaxH3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3AspectRatio), TypeInfoPropertyName = "MinimaxH3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3PromptExpansionMode), TypeInfoPropertyName = "MinimaxH3PromptExpansionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoMinimaxH3TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance25Resolution), TypeInfoPropertyName = "SeedDance25Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance25Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance2AspectRatio), TypeInfoPropertyName = "SeedDance2AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance25TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance2Resolution), TypeInfoPropertyName = "SeedDance2Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance2TextToVideoRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseStatus), TypeInfoPropertyName = "GenerationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseResponseType), TypeInfoPropertyName = "GenerationResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeType), TypeInfoPropertyName = "GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedTextBlockAlignment), TypeInfoPropertyName = "LayerizedTextBlockAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedTextBlockFormattingItems), TypeInfoPropertyName = "LayerizedTextBlockFormattingItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedTextBlockRole), TypeInfoPropertyName = "LayerizedTextBlockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextColorSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.LayerizedTextBlockFormattingItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.TextColorSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInner), TypeInfoPropertyName = "GenerationResponseDataInner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant1ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant1ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant2ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant2ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant3ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant3ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant4ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant4ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant5ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant5ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerVariant6ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant6ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.LayerizedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerDiscriminatorObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.GenerationResponseDataInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountApiKeyStatus), TypeInfoPropertyName = "AccountApiKeyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListAccountApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AccountApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountInvoiceStatus), TypeInfoPropertyName = "AccountInvoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountUsageApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountInvoiceLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountInvoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AccountInvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListAccountInvoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AccountInvoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2AccountUsageGetParametersBucketWidth), TypeInfoPropertyName = "V2AccountUsageGetParametersBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2AccountUsageGetParametersSourcesSchemaItems), TypeInfoPropertyName = "V2AccountUsageGetParametersSourcesSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountUsageLineItemSource), TypeInfoPropertyName = "AccountUsageLineItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountUsageBilledUnits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountUsageLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountUsageBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AccountUsageLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetAccountUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AccountUsageBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesPreciseEditPostPreciseEditImageV2Ideogram45Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AutoModelPostGenerateImageV2AutoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesGeneratePostGenerateImageV2Ideogram45Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesGeneratePostGenerateImageV2IdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesGeneratePostGenerateImageV2IdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesGeneratePostGenerateImageV2IdeogramV3CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesGeneratePostGenerateImageV2GptImage25FlareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesGeneratePostGenerateImageV2GptImage25SunburstRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesGeneratePostGenerateImageV2GptImage2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesGeneratePostGenerateImageV2NanoBanana2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesGeneratePostGenerateImageV2NanoBanana21Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesGeneratePostGenerateImageV2NanoBananaProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AutoModelPostToolRemixRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesRemixPostRemixImageV2IdeogramV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesRemixPostRemixImageV2IdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesRemixPostRemixImageV2IdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesRemixPostRemixImageV2IdeogramV3CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesInpaintPostInpaintImageV2IdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesInpaintPostInpaintImageV2IdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesInpaintPostInpaintImageV2IdeogramV3CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeNanoBanana2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolsPostUpscaleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageNanoBananaProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageTopazBloom2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageTopazRedefineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageTopazStandardV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageTopazTextRefineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImagesUpscalePostUpscaleImageTopazWonder35Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolReplaceBackgroundIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolReplaceBackgroundRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolRemoveBackgroundRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ObjectRemovalPostRemoveObjectFromV2AssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageDescribePostDescribeImageIdeogramV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageDescribePostDescribeImageIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DesignPostLayerizeDesignIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoGeneratePostGenerateVideoKlingV3StandardImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoGeneratePostGenerateVideoMinimaxH3ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoEditPostEditVideoMinimaxH3ReferenceToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoGeneratePostGenerateVideoSeedDance25ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoGeneratePostGenerateVideoSeedDance25ReferenceToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoGeneratePostGenerateVideoSeedDance2ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoGeneratePostGenerateVideoSeedDance2ReferenceToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostAdLocalizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostAdResizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostAdVariationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostColorwaysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostGhostMannequinRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostMaterialSwapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostModelPoseVariantsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditWorkflowPostSketchToRenderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolReplaceBackgroundIdeogram45Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2AccountUsageGetParametersSourcesSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.GeneratedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.RemixedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.InpaintedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.UpscaleImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.BackgroundRemovedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V4PromptElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.GeneratedDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DetectedTextBlockFormattingItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DetectedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LayerizedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LayerizedTextBlockFormattingItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextColorSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LayerizedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.GenerationResponseDataInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AccountApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AccountInvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AccountInvoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AccountUsageLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AccountUsageBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2AccountUsageGetParametersSourcesSchemaItems>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}