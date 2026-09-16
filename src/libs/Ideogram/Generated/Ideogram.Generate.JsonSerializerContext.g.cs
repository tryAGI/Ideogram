
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4JsonPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4), TypeInfoPropertyName = "ResolutionV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RenderingSpeed), TypeInfoPropertyName = "RenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OutputResolution), TypeInfoPropertyName = "OutputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RenderingSpeedV4), TypeInfoPropertyName = "RenderingSpeedV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateTransparentImageRequestV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV4), TypeInfoPropertyName = "AspectRatioV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestV4Fp8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestV4CfgDistilled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestPImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptOption), TypeInfoPropertyName = "MagicPromptOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PImageResolution), TypeInfoPropertyName = "PImageResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestPImageIdeogram))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Quality), TypeInfoPropertyName = "Quality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3), TypeInfoPropertyName = "AspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestV4Stable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestV4StableVersion), TypeInfoPropertyName = "GenerateImageRequestV4StableVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestZImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestFlux2Klein))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestFlux2KleinBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestErnie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestV4Im2Im))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4ImageToImage), TypeInfoPropertyName = "ResolutionV4ImageToImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageRequestV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateDesignRequestV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4Layout), TypeInfoPropertyName = "ResolutionV4Layout2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateDesignRequestV4InspirationReferenceModel), TypeInfoPropertyName = "GenerateDesignRequestV4InspirationReferenceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateDesignRequestV4ArtifactGenerationModel), TypeInfoPropertyName = "GenerateDesignRequestV4ArtifactGenerationModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateDesignRequestV4Layout2imageVariant), TypeInfoPropertyName = "GenerateDesignRequestV4Layout2imageVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateDesignRequestV4ResponseType), TypeInfoPropertyName = "GenerateDesignRequestV4ResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelEnum), TypeInfoPropertyName = "ModelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleType), TypeInfoPropertyName = "StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV3), TypeInfoPropertyName = "ResolutionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithPresetNameOrMembers), TypeInfoPropertyName = "ColorPaletteWithPresetNameOrMembers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV3), TypeInfoPropertyName = "StyleTypeV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StylePresetV3), TypeInfoPropertyName = "StylePresetV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateGraphicRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateDesignRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizeDesignRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateTransparentImageRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleFactor), TypeInfoPropertyName = "UpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V1EditImagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TransparencyOption), TypeInfoPropertyName = "TransparencyOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioEditLite), TypeInfoPropertyName = "AspectRatioEditLite2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V1EditLiteImagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TryOnRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveBackgroundRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.RemoveBackgroundImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveBackgroundImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveObjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SnapMaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.RemoveObjectImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveObjectImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InitialImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Resolution), TypeInfoPropertyName = "Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleInitialImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatio), TypeInfoPropertyName = "AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptVersionEnum), TypeInfoPropertyName = "MagicPromptVersionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObjectV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObjectV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V1EditImagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V1EditImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V1EditImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV4ResponseType), TypeInfoPropertyName = "ImageGenerationResponseV4ResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObjectV4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObjectV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AsyncImageGenerationResponseV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseStatus), TypeInfoPropertyName = "GenerationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseResponseType), TypeInfoPropertyName = "GenerationResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.GenerationResponseDataInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInner), TypeInfoPropertyName = "GenerationResponseDataInner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageObjectWithoutPromptOrSeed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType), TypeInfoPropertyName = "ImageObjectWithoutPromptOrSeedObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObjectObjectType), TypeInfoPropertyName = "ImageGenerationObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV4ImageToImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType), TypeInfoPropertyName = "ImageGenerationResponseV4ImageToImageResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObjectV4ImageToImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObjectV4ImageToImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV4Layout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV4LayoutResponseType), TypeInfoPropertyName = "ImageGenerationResponseV4LayoutResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObjectV4Layout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObjectV4Layout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayeredImageGenerationObjectV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.TextContainerV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextContainerV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ImageLayerV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageLayerV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayeredImageGenerationResponseV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayeredImageGenerationResponseV3ResponseType), TypeInfoPropertyName = "LayeredImageGenerationResponseV3ResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.LayeredImageGenerationObjectV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageSafetyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextSpanV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.TextSpanV3FontFxItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextSpanV3FontFxItem), TypeInfoPropertyName = "TextSpanV3FontFxItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3Alignment), TypeInfoPropertyName = "TextItemV3Alignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3StyleClass), TypeInfoPropertyName = "TextItemV3StyleClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3GlyphType), TypeInfoPropertyName = "TextItemV3GlyphType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3TextTransform), TypeInfoPropertyName = "TextItemV3TextTransform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3VerticalAlignment), TypeInfoPropertyName = "TextItemV3VerticalAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.LayeredAssetTextShadow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayeredAssetTextShadow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.TextSpanV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.TextItemV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizeLogosRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizeLogosResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizeTextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizeTextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.VideoObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoObjectObjectType), TypeInfoPropertyName = "VideoObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextToVideoRequestSeedDance2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance2AspectRatio), TypeInfoPropertyName = "SeedDance2AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance2Resolution), TypeInfoPropertyName = "SeedDance2Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageSafetyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason), TypeInfoPropertyName = "GenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageToVideoRequestSeedDance2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObjectObjectType), TypeInfoPropertyName = "LayerizedImageObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResizeAdImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResizeAdImageRequestResolution), TypeInfoPropertyName = "ResizeAdImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResizeAdImageQuality), TypeInfoPropertyName = "ResizeAdImageQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4StyleDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4CompositionalDeconstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V4PromptElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElement), TypeInfoPropertyName = "V4PromptElement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4ObjPromptElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4TextPromptElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElementDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElementDiscriminatorType), TypeInfoPropertyName = "V4PromptElementDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4ObjPromptElementType), TypeInfoPropertyName = "V4ObjPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4TextPromptElementType), TypeInfoPropertyName = "V4TextPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithPresetName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPalettePresetName), TypeInfoPropertyName = "ColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockAlignment), TypeInfoPropertyName = "DetectedTextBlockAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlockFormattingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockFormattingItem), TypeInfoPropertyName = "DetectedTextBlockFormattingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockRole), TypeInfoPropertyName = "DetectedTextBlockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostGenerateDesignV4200Response), TypeInfoPropertyName = "PostGenerateDesignV4200Response2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostGenerateDesignV4200ResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType), TypeInfoPropertyName = "PostGenerateDesignV4200ResponseDiscriminatorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerDiscriminatorObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4?), TypeInfoPropertyName = "NullableResolutionV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RenderingSpeed?), TypeInfoPropertyName = "NullableRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OutputResolution?), TypeInfoPropertyName = "NullableOutputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RenderingSpeedV4?), TypeInfoPropertyName = "NullableRenderingSpeedV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV4?), TypeInfoPropertyName = "NullableAspectRatioV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptOption?), TypeInfoPropertyName = "NullableMagicPromptOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PImageResolution?), TypeInfoPropertyName = "NullablePImageResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Quality?), TypeInfoPropertyName = "NullableQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3?), TypeInfoPropertyName = "NullableAspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestV4StableVersion?), TypeInfoPropertyName = "NullableGenerateImageRequestV4StableVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4ImageToImage?), TypeInfoPropertyName = "NullableResolutionV4ImageToImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4Layout?), TypeInfoPropertyName = "NullableResolutionV4Layout2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateDesignRequestV4InspirationReferenceModel?), TypeInfoPropertyName = "NullableGenerateDesignRequestV4InspirationReferenceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateDesignRequestV4ArtifactGenerationModel?), TypeInfoPropertyName = "NullableGenerateDesignRequestV4ArtifactGenerationModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateDesignRequestV4Layout2imageVariant?), TypeInfoPropertyName = "NullableGenerateDesignRequestV4Layout2imageVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateDesignRequestV4ResponseType?), TypeInfoPropertyName = "NullableGenerateDesignRequestV4ResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelEnum?), TypeInfoPropertyName = "NullableModelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleType?), TypeInfoPropertyName = "NullableStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV3?), TypeInfoPropertyName = "NullableResolutionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithPresetNameOrMembers?), TypeInfoPropertyName = "NullableColorPaletteWithPresetNameOrMembers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV3?), TypeInfoPropertyName = "NullableStyleTypeV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StylePresetV3?), TypeInfoPropertyName = "NullableStylePresetV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleFactor?), TypeInfoPropertyName = "NullableUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TransparencyOption?), TypeInfoPropertyName = "NullableTransparencyOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioEditLite?), TypeInfoPropertyName = "NullableAspectRatioEditLite2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Resolution?), TypeInfoPropertyName = "NullableResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatio?), TypeInfoPropertyName = "NullableAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptVersionEnum?), TypeInfoPropertyName = "NullableMagicPromptVersionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV4ResponseType?), TypeInfoPropertyName = "NullableImageGenerationResponseV4ResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseStatus?), TypeInfoPropertyName = "NullableGenerationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseResponseType?), TypeInfoPropertyName = "NullableGenerationResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInner?), TypeInfoPropertyName = "NullableGenerationResponseDataInner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType?), TypeInfoPropertyName = "NullableImageObjectWithoutPromptOrSeedObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObjectObjectType?), TypeInfoPropertyName = "NullableImageGenerationObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType?), TypeInfoPropertyName = "NullableImageGenerationResponseV4ImageToImageResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV4LayoutResponseType?), TypeInfoPropertyName = "NullableImageGenerationResponseV4LayoutResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayeredImageGenerationResponseV3ResponseType?), TypeInfoPropertyName = "NullableLayeredImageGenerationResponseV3ResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextSpanV3FontFxItem?), TypeInfoPropertyName = "NullableTextSpanV3FontFxItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3Alignment?), TypeInfoPropertyName = "NullableTextItemV3Alignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3StyleClass?), TypeInfoPropertyName = "NullableTextItemV3StyleClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3GlyphType?), TypeInfoPropertyName = "NullableTextItemV3GlyphType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3TextTransform?), TypeInfoPropertyName = "NullableTextItemV3TextTransform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3VerticalAlignment?), TypeInfoPropertyName = "NullableTextItemV3VerticalAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoObjectObjectType?), TypeInfoPropertyName = "NullableVideoObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance2AspectRatio?), TypeInfoPropertyName = "NullableSeedDance2AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance2Resolution?), TypeInfoPropertyName = "NullableSeedDance2Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason?), TypeInfoPropertyName = "NullableGenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObjectObjectType?), TypeInfoPropertyName = "NullableLayerizedImageObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResizeAdImageRequestResolution?), TypeInfoPropertyName = "NullableResizeAdImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResizeAdImageQuality?), TypeInfoPropertyName = "NullableResizeAdImageQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElement?), TypeInfoPropertyName = "NullableV4PromptElement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElementDiscriminatorType?), TypeInfoPropertyName = "NullableV4PromptElementDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4ObjPromptElementType?), TypeInfoPropertyName = "NullableV4ObjPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4TextPromptElementType?), TypeInfoPropertyName = "NullableV4TextPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPalettePresetName?), TypeInfoPropertyName = "NullableColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockAlignment?), TypeInfoPropertyName = "NullableDetectedTextBlockAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockFormattingItem?), TypeInfoPropertyName = "NullableDetectedTextBlockFormattingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockRole?), TypeInfoPropertyName = "NullableDetectedTextBlockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType?), TypeInfoPropertyName = "NullableAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostGenerateDesignV4200Response?), TypeInfoPropertyName = "NullablePostGenerateDesignV4200Response2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType?), TypeInfoPropertyName = "NullablePostGenerateDesignV4200ResponseDiscriminatorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType?), TypeInfoPropertyName = "NullableGenerationResponseDataInnerDiscriminatorObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.RemoveBackgroundImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.RemoveObjectImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ImageGenerationObjectV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V1EditImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ImageGenerationObjectV4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.GenerationResponseDataInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ImageGenerationObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ImageGenerationObjectV4ImageToImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ImageGenerationObjectV4Layout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextContainerV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ImageLayerV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LayeredImageGenerationObjectV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextSpanV3FontFxItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LayeredAssetTextShadow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextSpanV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextItemV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DetectedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.VideoObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V4PromptElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DetectedTextBlockFormattingItem>))]
    internal sealed partial class GenerateSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GenerateSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GenerateSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Ideogram.JsonConverters.V4PromptElementJsonConverter());
            options.Converters.Add(new global::Ideogram.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter());
            options.Converters.Add(new global::Ideogram.JsonConverters.PostGenerateDesignV4200ResponseJsonConverter());
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
                    typeToConvert == typeof(global::Ideogram.OutputResolution)

                    || typeToConvert == typeof(global::Ideogram.OutputResolution?)

                    || typeToConvert == typeof(global::Ideogram.RenderingSpeedV4)

                    || typeToConvert == typeof(global::Ideogram.RenderingSpeedV4?)

                    || typeToConvert == typeof(global::Ideogram.PImageResolution)

                    || typeToConvert == typeof(global::Ideogram.PImageResolution?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageRequestV4StableVersion)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageRequestV4StableVersion?)

                    || typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4InspirationReferenceModel)

                    || typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4InspirationReferenceModel?)

                    || typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4ArtifactGenerationModel)

                    || typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4ArtifactGenerationModel?)

                    || typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4Layout2imageVariant)

                    || typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4Layout2imageVariant?)

                    || typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4ResponseType)

                    || typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4ResponseType?)

                    || typeToConvert == typeof(global::Ideogram.TransparencyOption)

                    || typeToConvert == typeof(global::Ideogram.TransparencyOption?)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioEditLite)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioEditLite?)

                    || typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4ResponseType)

                    || typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4ResponseType?)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseStatus)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseStatus?)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseResponseType)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseResponseType?)

                    || typeToConvert == typeof(global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType)

                    || typeToConvert == typeof(global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType?)

                    || typeToConvert == typeof(global::Ideogram.ImageGenerationObjectObjectType)

                    || typeToConvert == typeof(global::Ideogram.ImageGenerationObjectObjectType?)

                    || typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType)

                    || typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType?)

                    || typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4LayoutResponseType)

                    || typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4LayoutResponseType?)

                    || typeToConvert == typeof(global::Ideogram.LayeredImageGenerationResponseV3ResponseType)

                    || typeToConvert == typeof(global::Ideogram.LayeredImageGenerationResponseV3ResponseType?)

                    || typeToConvert == typeof(global::Ideogram.ModelEnum)

                    || typeToConvert == typeof(global::Ideogram.ModelEnum?)

                    || typeToConvert == typeof(global::Ideogram.TextSpanV3FontFxItem)

                    || typeToConvert == typeof(global::Ideogram.TextSpanV3FontFxItem?)

                    || typeToConvert == typeof(global::Ideogram.TextItemV3Alignment)

                    || typeToConvert == typeof(global::Ideogram.TextItemV3Alignment?)

                    || typeToConvert == typeof(global::Ideogram.TextItemV3StyleClass)

                    || typeToConvert == typeof(global::Ideogram.TextItemV3StyleClass?)

                    || typeToConvert == typeof(global::Ideogram.TextItemV3GlyphType)

                    || typeToConvert == typeof(global::Ideogram.TextItemV3GlyphType?)

                    || typeToConvert == typeof(global::Ideogram.TextItemV3TextTransform)

                    || typeToConvert == typeof(global::Ideogram.TextItemV3TextTransform?)

                    || typeToConvert == typeof(global::Ideogram.TextItemV3VerticalAlignment)

                    || typeToConvert == typeof(global::Ideogram.TextItemV3VerticalAlignment?)

                    || typeToConvert == typeof(global::Ideogram.VideoObjectObjectType)

                    || typeToConvert == typeof(global::Ideogram.VideoObjectObjectType?)

                    || typeToConvert == typeof(global::Ideogram.GenerationRejectReason)

                    || typeToConvert == typeof(global::Ideogram.GenerationRejectReason?)

                    || typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType)

                    || typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType?)

                    || typeToConvert == typeof(global::Ideogram.ResizeAdImageRequestResolution)

                    || typeToConvert == typeof(global::Ideogram.ResizeAdImageRequestResolution?)

                    || typeToConvert == typeof(global::Ideogram.ResizeAdImageQuality)

                    || typeToConvert == typeof(global::Ideogram.ResizeAdImageQuality?)

                    || typeToConvert == typeof(global::Ideogram.V4PromptElementDiscriminatorType)

                    || typeToConvert == typeof(global::Ideogram.V4PromptElementDiscriminatorType?)

                    || typeToConvert == typeof(global::Ideogram.V4ObjPromptElementType)

                    || typeToConvert == typeof(global::Ideogram.V4ObjPromptElementType?)

                    || typeToConvert == typeof(global::Ideogram.V4TextPromptElementType)

                    || typeToConvert == typeof(global::Ideogram.V4TextPromptElementType?)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV4)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV4?)

                    || typeToConvert == typeof(global::Ideogram.RenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.RenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV4)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV4?)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptOption)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptOption?)

                    || typeToConvert == typeof(global::Ideogram.Quality)

                    || typeToConvert == typeof(global::Ideogram.Quality?)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV3)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV3?)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV4ImageToImage)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV4ImageToImage?)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV4Layout)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV4Layout?)

                    || typeToConvert == typeof(global::Ideogram.StyleType)

                    || typeToConvert == typeof(global::Ideogram.StyleType?)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV3)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV3?)

                    || typeToConvert == typeof(global::Ideogram.ColorPalettePresetName)

                    || typeToConvert == typeof(global::Ideogram.ColorPalettePresetName?)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV3)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV3?)

                    || typeToConvert == typeof(global::Ideogram.StylePresetV3)

                    || typeToConvert == typeof(global::Ideogram.StylePresetV3?)

                    || typeToConvert == typeof(global::Ideogram.UpscaleFactor)

                    || typeToConvert == typeof(global::Ideogram.UpscaleFactor?)

                    || typeToConvert == typeof(global::Ideogram.Resolution)

                    || typeToConvert == typeof(global::Ideogram.Resolution?)

                    || typeToConvert == typeof(global::Ideogram.AspectRatio)

                    || typeToConvert == typeof(global::Ideogram.AspectRatio?)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptVersionEnum)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptVersionEnum?)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockAlignment)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockAlignment?)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockFormattingItem)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockFormattingItem?)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockRole)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockRole?)

                    || typeToConvert == typeof(global::Ideogram.SeedDance2AspectRatio)

                    || typeToConvert == typeof(global::Ideogram.SeedDance2AspectRatio?)

                    || typeToConvert == typeof(global::Ideogram.SeedDance2Resolution)

                    || typeToConvert == typeof(global::Ideogram.SeedDance2Resolution?)

                    || typeToConvert == typeof(global::Ideogram.AssetType)

                    || typeToConvert == typeof(global::Ideogram.AssetType?)

                    || typeToConvert == typeof(global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType)

                    || typeToConvert == typeof(global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType?)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Ideogram.OutputResolution))
                {
                    return new global::Ideogram.JsonConverters.OutputResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.OutputResolution?))
                {
                    return new global::Ideogram.JsonConverters.OutputResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.RenderingSpeedV4))
                {
                    return new global::Ideogram.JsonConverters.RenderingSpeedV4JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.RenderingSpeedV4?))
                {
                    return new global::Ideogram.JsonConverters.RenderingSpeedV4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PImageResolution))
                {
                    return new global::Ideogram.JsonConverters.PImageResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PImageResolution?))
                {
                    return new global::Ideogram.JsonConverters.PImageResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageRequestV4StableVersion))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageRequestV4StableVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageRequestV4StableVersion?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageRequestV4StableVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4InspirationReferenceModel))
                {
                    return new global::Ideogram.JsonConverters.GenerateDesignRequestV4InspirationReferenceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4InspirationReferenceModel?))
                {
                    return new global::Ideogram.JsonConverters.GenerateDesignRequestV4InspirationReferenceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4ArtifactGenerationModel))
                {
                    return new global::Ideogram.JsonConverters.GenerateDesignRequestV4ArtifactGenerationModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4ArtifactGenerationModel?))
                {
                    return new global::Ideogram.JsonConverters.GenerateDesignRequestV4ArtifactGenerationModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4Layout2imageVariant))
                {
                    return new global::Ideogram.JsonConverters.GenerateDesignRequestV4Layout2imageVariantJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4Layout2imageVariant?))
                {
                    return new global::Ideogram.JsonConverters.GenerateDesignRequestV4Layout2imageVariantNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4ResponseType))
                {
                    return new global::Ideogram.JsonConverters.GenerateDesignRequestV4ResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateDesignRequestV4ResponseType?))
                {
                    return new global::Ideogram.JsonConverters.GenerateDesignRequestV4ResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TransparencyOption))
                {
                    return new global::Ideogram.JsonConverters.TransparencyOptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TransparencyOption?))
                {
                    return new global::Ideogram.JsonConverters.TransparencyOptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioEditLite))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioEditLiteJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioEditLite?))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioEditLiteNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4ResponseType))
                {
                    return new global::Ideogram.JsonConverters.ImageGenerationResponseV4ResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4ResponseType?))
                {
                    return new global::Ideogram.JsonConverters.ImageGenerationResponseV4ResponseTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType))
                {
                    return new global::Ideogram.JsonConverters.ImageGenerationResponseV4ImageToImageResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType?))
                {
                    return new global::Ideogram.JsonConverters.ImageGenerationResponseV4ImageToImageResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4LayoutResponseType))
                {
                    return new global::Ideogram.JsonConverters.ImageGenerationResponseV4LayoutResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ImageGenerationResponseV4LayoutResponseType?))
                {
                    return new global::Ideogram.JsonConverters.ImageGenerationResponseV4LayoutResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LayeredImageGenerationResponseV3ResponseType))
                {
                    return new global::Ideogram.JsonConverters.LayeredImageGenerationResponseV3ResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LayeredImageGenerationResponseV3ResponseType?))
                {
                    return new global::Ideogram.JsonConverters.LayeredImageGenerationResponseV3ResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelEnum))
                {
                    return new global::Ideogram.JsonConverters.ModelEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelEnum?))
                {
                    return new global::Ideogram.JsonConverters.ModelEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextSpanV3FontFxItem))
                {
                    return new global::Ideogram.JsonConverters.TextSpanV3FontFxItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextSpanV3FontFxItem?))
                {
                    return new global::Ideogram.JsonConverters.TextSpanV3FontFxItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextItemV3Alignment))
                {
                    return new global::Ideogram.JsonConverters.TextItemV3AlignmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextItemV3Alignment?))
                {
                    return new global::Ideogram.JsonConverters.TextItemV3AlignmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextItemV3StyleClass))
                {
                    return new global::Ideogram.JsonConverters.TextItemV3StyleClassJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextItemV3StyleClass?))
                {
                    return new global::Ideogram.JsonConverters.TextItemV3StyleClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextItemV3GlyphType))
                {
                    return new global::Ideogram.JsonConverters.TextItemV3GlyphTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextItemV3GlyphType?))
                {
                    return new global::Ideogram.JsonConverters.TextItemV3GlyphTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextItemV3TextTransform))
                {
                    return new global::Ideogram.JsonConverters.TextItemV3TextTransformJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextItemV3TextTransform?))
                {
                    return new global::Ideogram.JsonConverters.TextItemV3TextTransformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextItemV3VerticalAlignment))
                {
                    return new global::Ideogram.JsonConverters.TextItemV3VerticalAlignmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TextItemV3VerticalAlignment?))
                {
                    return new global::Ideogram.JsonConverters.TextItemV3VerticalAlignmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.VideoObjectObjectType))
                {
                    return new global::Ideogram.JsonConverters.VideoObjectObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.VideoObjectObjectType?))
                {
                    return new global::Ideogram.JsonConverters.VideoObjectObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationRejectReason))
                {
                    return new global::Ideogram.JsonConverters.GenerationRejectReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationRejectReason?))
                {
                    return new global::Ideogram.JsonConverters.GenerationRejectReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType))
                {
                    return new global::Ideogram.JsonConverters.LayerizedImageObjectObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType?))
                {
                    return new global::Ideogram.JsonConverters.LayerizedImageObjectObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResizeAdImageRequestResolution))
                {
                    return new global::Ideogram.JsonConverters.ResizeAdImageRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResizeAdImageRequestResolution?))
                {
                    return new global::Ideogram.JsonConverters.ResizeAdImageRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResizeAdImageQuality))
                {
                    return new global::Ideogram.JsonConverters.ResizeAdImageQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResizeAdImageQuality?))
                {
                    return new global::Ideogram.JsonConverters.ResizeAdImageQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V4PromptElementDiscriminatorType))
                {
                    return new global::Ideogram.JsonConverters.V4PromptElementDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V4PromptElementDiscriminatorType?))
                {
                    return new global::Ideogram.JsonConverters.V4PromptElementDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V4ObjPromptElementType))
                {
                    return new global::Ideogram.JsonConverters.V4ObjPromptElementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V4ObjPromptElementType?))
                {
                    return new global::Ideogram.JsonConverters.V4ObjPromptElementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V4TextPromptElementType))
                {
                    return new global::Ideogram.JsonConverters.V4TextPromptElementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V4TextPromptElementType?))
                {
                    return new global::Ideogram.JsonConverters.V4TextPromptElementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV4))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV4JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV4?))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.RenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.RenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.RenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.RenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV4))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV4JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV4?))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptOption))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptOption?))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptOptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.Quality))
                {
                    return new global::Ideogram.JsonConverters.QualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.Quality?))
                {
                    return new global::Ideogram.JsonConverters.QualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV3))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV3?))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV4ImageToImage))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV4ImageToImageJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV4ImageToImage?))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV4ImageToImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV4Layout))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV4LayoutJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV4Layout?))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV4LayoutNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleType))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleType?))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV3))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV3?))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ColorPalettePresetName))
                {
                    return new global::Ideogram.JsonConverters.ColorPalettePresetNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ColorPalettePresetName?))
                {
                    return new global::Ideogram.JsonConverters.ColorPalettePresetNameNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.UpscaleFactor))
                {
                    return new global::Ideogram.JsonConverters.UpscaleFactorJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.UpscaleFactor?))
                {
                    return new global::Ideogram.JsonConverters.UpscaleFactorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.Resolution))
                {
                    return new global::Ideogram.JsonConverters.ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.Resolution?))
                {
                    return new global::Ideogram.JsonConverters.ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatio))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatio?))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptVersionEnum))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptVersionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptVersionEnum?))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptVersionEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.SeedDance2AspectRatio))
                {
                    return new global::Ideogram.JsonConverters.SeedDance2AspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SeedDance2AspectRatio?))
                {
                    return new global::Ideogram.JsonConverters.SeedDance2AspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SeedDance2Resolution))
                {
                    return new global::Ideogram.JsonConverters.SeedDance2ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SeedDance2Resolution?))
                {
                    return new global::Ideogram.JsonConverters.SeedDance2ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType?))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType))
                {
                    return new global::Ideogram.JsonConverters.PostGenerateDesignV4200ResponseDiscriminatorResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType?))
                {
                    return new global::Ideogram.JsonConverters.PostGenerateDesignV4200ResponseDiscriminatorResponseTypeNullableJsonConverter();
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
                    0 => new GenerateSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}