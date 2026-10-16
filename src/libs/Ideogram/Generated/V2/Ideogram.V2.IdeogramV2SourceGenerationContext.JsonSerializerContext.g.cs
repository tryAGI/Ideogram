
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Ideogram.V2.JsonConverters.V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationKindJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationKindNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationRejectReasonJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationRejectReasonNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationErrorResponseTaskCompletionSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationErrorResponseTaskCompletionSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.MagicPromptModeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.MagicPromptModeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaBackgroundJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaBackgroundNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.ResolutionV4JsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.ResolutionV4NullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV4RequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV4RequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV4CustomModelRequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV4CustomModelRequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramV4AspectRatioJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramV4AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV4TransparentRequestOutputResolutionJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV4TransparentRequestOutputResolutionNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV4TransparentRequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV4TransparentRequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.ResolutionV3JsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.ResolutionV3NullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramV3AspectRatioJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramV3AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramColorPalettePresetNameJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramColorPalettePresetNameNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramV3StyleTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramV3StyleTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramV3StylePresetJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramV3StylePresetNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV3TransparentRequestUpscaleFactorJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV3TransparentRequestUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV3TransparentRequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV3TransparentRequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV2ARequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV2ARequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramV2StyleTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramV2StyleTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV2RequestRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV2RequestRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackgroundJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackgroundNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackgroundJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackgroundNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.NanoBanana2AspectRatioJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.NanoBanana2AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.NanoBanana21AspectRatioJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.NanoBanana21AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.NanoBananaProAspectRatioJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.NanoBananaProAspectRatioNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImagePImageIdeogramRequestResolutionJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerateImagePImageIdeogramRequestResolutionNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AspectRatioV3JsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AspectRatioV3NullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.NanoBanana2ReframeAspectRatioJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.NanoBanana2ReframeAspectRatioNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetectionJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetectionNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrengthJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrengthNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.ReplaceBackgroundQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.ReplaceBackgroundQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V4ObjPromptElementTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V4ObjPromptElementTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V4TextPromptElementTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V4TextPromptElementTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V4PromptElementDiscriminatorTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V4PromptElementDiscriminatorTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.DetectedTextBlockAlignmentJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.DetectedTextBlockAlignmentNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.DetectedTextBlockFormattingItemsJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.DetectedTextBlockFormattingItemsNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.DetectedTextBlockRoleJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.DetectedTextBlockRoleNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.KlingV3ShotTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.KlingV3ShotTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.KlingV3AspectRatioJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.KlingV3AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.MinimaxH3ResolutionJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.MinimaxH3ResolutionNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.MinimaxH3AspectRatioJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.MinimaxH3AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.MinimaxH3PromptExpansionModeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.MinimaxH3PromptExpansionModeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.SeedDance25ResolutionJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.SeedDance25ResolutionNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.SeedDance2AspectRatioJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.SeedDance2AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.SeedDance2ResolutionJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.SeedDance2ResolutionNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguageJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguageNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AdLocalizerQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AdLocalizerQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolutionJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolutionNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatformJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatformNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AdResizerQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AdResizerQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AdVariationsQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AdVariationsQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.ColorwaysQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.ColorwaysQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AssetTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AssetTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaViewJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaViewNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GhostMannequinQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GhostMannequinQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.MaterialSwapQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.MaterialSwapQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.ModelPoseVariantsQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.ModelPoseVariantsQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.SketchToRenderQualityJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.SketchToRenderQualityNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseStatusJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseStatusNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseResponseTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseResponseTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.LayerizedTextBlockAlignmentJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.LayerizedTextBlockAlignmentNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.LayerizedTextBlockFormattingItemsJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.LayerizedTextBlockFormattingItemsNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.LayerizedTextBlockRoleJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.LayerizedTextBlockRoleNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant1ObjectTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant1ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant2ObjectTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant2ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant3ObjectTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant3ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant4ObjectTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant4ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant5ObjectTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant5ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant6ObjectTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant6ObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerDiscriminatorObjectTypeJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerDiscriminatorObjectTypeNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AccountApiKeyStatusJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AccountApiKeyStatusNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AccountInvoiceStatusJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AccountInvoiceStatusNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2AccountUsageGetParametersBucketWidthJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2AccountUsageGetParametersBucketWidthNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2AccountUsageGetParametersSourcesSchemaItemsJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V2AccountUsageGetParametersSourcesSchemaItemsNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AccountUsageLineItemSourceJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.AccountUsageLineItemSourceNullableJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.IdeogramColorPaletteJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.V4PromptElementJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerJsonConverter),

            typeof(global::Ideogram.V2.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.IdeogramV2SourceGenerationContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality), TypeInfoPropertyName = "V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationKind), TypeInfoPropertyName = "GenerationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GeneratedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.PreciseEditImageIdeogram45Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.GeneratedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationRejectReason), TypeInfoPropertyName = "GenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationErrorResponseTaskCompletionSpeed), TypeInfoPropertyName = "GenerationErrorResponseTaskCompletionSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.MagicPromptMode), TypeInfoPropertyName = "MagicPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageV2AutoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaBackground), TypeInfoPropertyName = "V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality), TypeInfoPropertyName = "V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogram45Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ResolutionV4), TypeInfoPropertyName = "ResolutionV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV4RequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV4RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV4CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV4CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV4CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.IdeogramV4AspectRatio), TypeInfoPropertyName = "IdeogramV4AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV4TransparentRequestOutputResolution), TypeInfoPropertyName = "GenerateImageIdeogramV4TransparentRequestOutputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV4TransparentRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV4TransparentRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV4TransparentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV4TransparentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ResolutionV3), TypeInfoPropertyName = "ResolutionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.IdeogramV3AspectRatio), TypeInfoPropertyName = "IdeogramV3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageGenerateIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.IdeogramColorPalettePresetName), TypeInfoPropertyName = "IdeogramColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.IdeogramColorPaletteWithPresetName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ColorPaletteMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ColorPaletteWithMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.IdeogramColorPalette), TypeInfoPropertyName = "IdeogramColorPalette2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.IdeogramV3StyleType), TypeInfoPropertyName = "IdeogramV3StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.IdeogramV3StylePreset), TypeInfoPropertyName = "IdeogramV3StylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType), TypeInfoPropertyName = "V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV3CharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV3CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV3TransparentRequestUpscaleFactor), TypeInfoPropertyName = "GenerateImageIdeogramV3TransparentRequestUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV3TransparentRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV3TransparentRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV3TransparentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV3TransparentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV2ARequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV2ARequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.IdeogramV2StyleType), TypeInfoPropertyName = "IdeogramV2StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV2ARequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV2AResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV2RequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV2RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageIdeogramV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground), TypeInfoPropertyName = "V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality), TypeInfoPropertyName = "V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageGptImage25FlareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground), TypeInfoPropertyName = "V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality), TypeInfoPropertyName = "V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageGptImage25SunburstResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageGptImage2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.NanoBanana2AspectRatio), TypeInfoPropertyName = "NanoBanana2AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageNanoBanana2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.NanoBanana21AspectRatio), TypeInfoPropertyName = "NanoBanana21AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageGenerateNanoBanana21PostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageNanoBanana21Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.NanoBananaProAspectRatio), TypeInfoPropertyName = "NanoBananaProAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageNanoBananaProResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationQuality), TypeInfoPropertyName = "GenerationQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImagePImageIdeogramRequestResolution), TypeInfoPropertyName = "GenerateImagePImageIdeogramRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AspectRatioV3), TypeInfoPropertyName = "AspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImagePImageIdeogramRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImagePImageIdeogramResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageZImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateImageZImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ToolRemixResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageRemixIdeogram4PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.RemixedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.RemixImageIdeogramV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.RemixedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.RemixImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType), TypeInfoPropertyName = "V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.RemixImageIdeogramV3CharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.RemixImageIdeogramV3CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.InpaintedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.InpaintImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.InpaintedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType), TypeInfoPropertyName = "V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.InpaintImageIdeogramV3CharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.InpaintImageIdeogramV3CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ReframeImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.NanoBanana2ReframeAspectRatio), TypeInfoPropertyName = "NanoBanana2ReframeAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ReframeImageNanoBanana2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.UpscaleImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.UpscaleToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.UpscaleImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier), TypeInfoPropertyName = "V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.UpscaleImageNanoBananaProResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.UpscaleImageTopazBloom2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection), TypeInfoPropertyName = "V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.UpscaleImageTopazRedefineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection), TypeInfoPropertyName = "V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.UpscaleImageTopazStandardV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection), TypeInfoPropertyName = "V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.UpscaleImageTopazTextRefineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor), TypeInfoPropertyName = "V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength), TypeInfoPropertyName = "V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.UpscaleImageTopazWonder35Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed), TypeInfoPropertyName = "V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ReplaceBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ReplaceBackgroundQuality), TypeInfoPropertyName = "ReplaceBackgroundQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.BackgroundRemovedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.RemoveBackgroundV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.BackgroundRemovedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.RemoveObjectFromV2AssetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V4StyleDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V4ObjPromptElementType), TypeInfoPropertyName = "V4ObjPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V4TextPromptElementType), TypeInfoPropertyName = "V4TextPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V4PromptElement), TypeInfoPropertyName = "V4PromptElement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V4PromptElementVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V4PromptElementVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V4PromptElementDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V4PromptElementDiscriminatorType), TypeInfoPropertyName = "V4PromptElementDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V4CompositionalDeconstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.V4PromptElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V4JsonPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.DescribeImageIdeogramV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImageSafetyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GeneratedDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.DescribeImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.GeneratedDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.DetectedTextBlockAlignment), TypeInfoPropertyName = "DetectedTextBlockAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.DetectedTextBlockFormattingItems), TypeInfoPropertyName = "DetectedTextBlockFormattingItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.DetectedTextBlockRole), TypeInfoPropertyName = "DetectedTextBlockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.DetectedTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.DetectedTextBlockFormattingItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.LayerizedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.DetectedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.LayerizeDesignIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.KlingV3ShotType), TypeInfoPropertyName = "KlingV3ShotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateVideoKlingV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.KlingV3AspectRatio), TypeInfoPropertyName = "KlingV3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateVideoKlingV3StandardTextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.MinimaxH3Resolution), TypeInfoPropertyName = "MinimaxH3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateVideoMinimaxH3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.MinimaxH3AspectRatio), TypeInfoPropertyName = "MinimaxH3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.MinimaxH3PromptExpansionMode), TypeInfoPropertyName = "MinimaxH3PromptExpansionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateVideoMinimaxH3TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.SeedDance25Resolution), TypeInfoPropertyName = "SeedDance25Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateVideoSeedDance25Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.SeedDance2AspectRatio), TypeInfoPropertyName = "SeedDance2AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateVideoSeedDance25TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.SeedDance2Resolution), TypeInfoPropertyName = "SeedDance2Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateVideoSeedDance2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerateVideoSeedDance2TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage), TypeInfoPropertyName = "V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AdLocalizerQuality), TypeInfoPropertyName = "AdLocalizerQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AdLocalizerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution), TypeInfoPropertyName = "V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform), TypeInfoPropertyName = "V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AdResizerQuality), TypeInfoPropertyName = "AdResizerQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AdResizerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType), TypeInfoPropertyName = "V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AdVariationsQuality), TypeInfoPropertyName = "AdVariationsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AdVariationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ColorwaysQuality), TypeInfoPropertyName = "ColorwaysQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ColorwaysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView), TypeInfoPropertyName = "V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GhostMannequinQuality), TypeInfoPropertyName = "GhostMannequinQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GhostMannequinResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.MaterialSwapQuality), TypeInfoPropertyName = "MaterialSwapQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.MaterialSwapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ModelPoseVariantsQuality), TypeInfoPropertyName = "ModelPoseVariantsQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ModelPoseVariantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.SketchToRenderQuality), TypeInfoPropertyName = "SketchToRenderQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.SketchToRenderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseStatus), TypeInfoPropertyName = "GenerationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseResponseType), TypeInfoPropertyName = "GenerationResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeType), TypeInfoPropertyName = "GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.LayerizedTextBlockAlignment), TypeInfoPropertyName = "LayerizedTextBlockAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.LayerizedTextBlockFormattingItems), TypeInfoPropertyName = "LayerizedTextBlockFormattingItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.LayerizedTextBlockRole), TypeInfoPropertyName = "LayerizedTextBlockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.TextColorSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.LayerizedTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizedTextBlockFormattingItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.TextColorSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInner), TypeInfoPropertyName = "GenerationResponseDataInner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant1ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant1ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant2ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant2ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant3ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant3ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant4ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant4ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant5ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant5ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant6ObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerVariant6ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerDiscriminatorObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.GenerationResponseDataInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AccountApiKeyStatus), TypeInfoPropertyName = "AccountApiKeyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AccountApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ListAccountApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.AccountApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AccountInvoiceStatus), TypeInfoPropertyName = "AccountInvoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AccountUsageApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AccountInvoiceLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AccountInvoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.AccountInvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ListAccountInvoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.AccountInvoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2AccountUsageGetParametersBucketWidth), TypeInfoPropertyName = "V2AccountUsageGetParametersBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.V2AccountUsageGetParametersSourcesSchemaItems), TypeInfoPropertyName = "V2AccountUsageGetParametersSourcesSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AccountUsageLineItemSource), TypeInfoPropertyName = "AccountUsageLineItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AccountUsageBilledUnits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AccountUsageLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AccountUsageBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.AccountUsageLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.GetAccountUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.AccountUsageBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesPreciseEditPostPreciseEditImageV2Ideogram45Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AutoModelPostGenerateImageV2AutoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesGeneratePostGenerateImageV2Ideogram45Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesGeneratePostGenerateImageV2IdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesGeneratePostGenerateImageV2IdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesGeneratePostGenerateImageV2IdeogramV3CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesGeneratePostGenerateImageV2GptImage25FlareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesGeneratePostGenerateImageV2GptImage25SunburstRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesGeneratePostGenerateImageV2GptImage2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesGeneratePostGenerateImageV2NanoBanana2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesGeneratePostGenerateImageV2NanoBanana21Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesGeneratePostGenerateImageV2NanoBananaProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.AutoModelPostToolRemixRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesRemixPostRemixImageV2IdeogramV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesRemixPostRemixImageV2IdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesRemixPostRemixImageV2IdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesRemixPostRemixImageV2IdeogramV3CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesInpaintPostInpaintImageV2IdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesInpaintPostInpaintImageV2IdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesInpaintPostInpaintImageV2IdeogramV3CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ReframeIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ReframeNanoBanana2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ToolsPostUpscaleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesUpscalePostUpscaleImageNanoBananaProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesUpscalePostUpscaleImageTopazBloom2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesUpscalePostUpscaleImageTopazRedefineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesUpscalePostUpscaleImageTopazStandardV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesUpscalePostUpscaleImageTopazTextRefineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImagesUpscalePostUpscaleImageTopazWonder35Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ToolReplaceBackgroundIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ToolReplaceBackgroundRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ToolRemoveBackgroundRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ObjectRemovalPostRemoveObjectFromV2AssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImageDescribePostDescribeImageIdeogramV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ImageDescribePostDescribeImageIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.DesignPostLayerizeDesignIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.VideoGeneratePostGenerateVideoKlingV3StandardImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.VideoGeneratePostGenerateVideoMinimaxH3ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.VideoEditPostEditVideoMinimaxH3ReferenceToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.VideoGeneratePostGenerateVideoSeedDance25ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.VideoGeneratePostGenerateVideoSeedDance25ReferenceToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.VideoGeneratePostGenerateVideoSeedDance2ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.VideoGeneratePostGenerateVideoSeedDance2ReferenceToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.EditWorkflowPostAdLocalizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.EditWorkflowPostAdResizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.EditWorkflowPostAdVariationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.EditWorkflowPostColorwaysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.EditWorkflowPostGhostMannequinRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.EditWorkflowPostMaterialSwapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.EditWorkflowPostModelPoseVariantsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.EditWorkflowPostSketchToRenderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V2.ToolReplaceBackgroundIdeogram45Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V2.V2AccountUsageGetParametersSourcesSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.GeneratedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.RemixedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.InpaintedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.UpscaleImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.BackgroundRemovedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.V4PromptElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.GeneratedDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.DetectedTextBlockFormattingItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.DetectedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.LayerizedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.LayerizedTextBlockFormattingItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.TextColorSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.LayerizedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.GenerationResponseDataInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.AccountApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.AccountInvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.AccountInvoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.AccountUsageLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.AccountUsageBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V2.V2AccountUsageGetParametersSourcesSchemaItems>))]
    public sealed partial class IdeogramV2SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}