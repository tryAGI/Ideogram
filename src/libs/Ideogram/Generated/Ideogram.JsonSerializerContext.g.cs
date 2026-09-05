
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4JsonPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DescribeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.Description>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Description))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DescribeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DescribeModelVersion), TypeInfoPropertyName = "DescribeModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DescribeRequestV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DescribeResponseV4))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalTestingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalTestingNestedObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalTestingNestedObjectRequiredFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.InternalTestingNestedObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalTestingEnumField), TypeInfoPropertyName = "InternalTestingEnumField2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.MagicPromptRequestMessagesInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptRequestMessagesInner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SamplingRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalBatchResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalBatchResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.InternalBatchResultsResponseResultsInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalBatchResultsResponseResultsInner))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance2TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance2ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance25Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance25TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance25Resolution), TypeInfoPropertyName = "SeedDance25Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance25ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoMinimaxH3TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3AspectRatio), TypeInfoPropertyName = "MinimaxH3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3Resolution), TypeInfoPropertyName = "MinimaxH3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoMinimaxH3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoMinimaxH3ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoKlingV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoKlingV3StandardTextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.KlingV3AspectRatio), TypeInfoPropertyName = "KlingV3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.KlingV3ShotType), TypeInfoPropertyName = "KlingV3ShotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoKlingV3StandardImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditVideoSeedDance2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditVideoMinimaxH3ReferenceToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3PromptExpansionMode), TypeInfoPropertyName = "MinimaxH3PromptExpansionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveObjectFromV2AssetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveObjectFromV2AssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveBackgroundV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.BackgroundRemovedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.BackgroundRemovedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveBackgroundV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveBackgroundV2AssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GptImage2Quality), TypeInfoPropertyName = "GptImage2Quality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageGptImage2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.EditImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageGptImage2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageTopazTextRefineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.UpscaleImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageTopazTextRefineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageTopazTextRefineRequestUpscaleFactor), TypeInfoPropertyName = "UpscaleImageTopazTextRefineRequestUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookRequestCategory), TypeInfoPropertyName = "LookbookRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelPoseVariantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelPoseVariantsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotView), TypeInfoPropertyName = "PackshotView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PreciseMaskedEditRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleToolRequestUpscaleFactor), TypeInfoPropertyName = "UpscaleToolRequestUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizeDesignIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.LayerizedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObjectObjectType), TypeInfoPropertyName = "LayerizedImageObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizeDesignIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageGemini31FlashResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageGemini31FlashRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageGemini30ProResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageGemini30ProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageGemini30ProRequestResolutionTier), TypeInfoPropertyName = "EditImageGemini30ProRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageIdeogram45Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageIdeogram45Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageIdeogram45RequestRenderingSpeed), TypeInfoPropertyName = "EditImageIdeogram45RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.GeneratedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GeneratedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV3CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV4RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV4CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.RemixedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageIdeogramV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageIdeogramV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed), TypeInfoPropertyName = "RemixImageIdeogramV4RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution), TypeInfoPropertyName = "GenerateImageIdeogramV4TransparentRequestOutputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV4TransparentRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImagePImageIdeogramResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImagePImageIdeogramRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImagePImageIdeogramRequestResolution), TypeInfoPropertyName = "GenerateImagePImageIdeogramRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageZImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageZImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogram45Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogram45Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogram45RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGemini31FlashResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGemini31FlashRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGemini30ProResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGemini30ProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGemini30ProRequestResolutionTier), TypeInfoPropertyName = "GenerateImageGemini30ProRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV2RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV2), TypeInfoPropertyName = "StyleTypeV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2AResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2ARequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV2ARequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.InpaintedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3RequestRenderingSpeed), TypeInfoPropertyName = "InpaintImageIdeogramV3RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed), TypeInfoPropertyName = "InpaintImageIdeogramV3CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed), TypeInfoPropertyName = "ReframeImageIdeogramV3RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageGemini31FlashImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageGemini31FlashImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV3CharacterRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType), TypeInfoPropertyName = "GenerateImageIdeogramV3CharacterRequestStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed), TypeInfoPropertyName = "InpaintImageIdeogramV3CharacterRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType), TypeInfoPropertyName = "InpaintImageIdeogramV3CharacterRequestStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolTextToImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolTextToImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolTextToImageRequestResolutionTier), TypeInfoPropertyName = "ToolTextToImageRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolImageToImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolImageToImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolImageToImageRequestResolutionTier), TypeInfoPropertyName = "ToolImageToImageRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResizeAdImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResizeAdImageRequestResolution), TypeInfoPropertyName = "ResizeAdImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResizeAdImageQuality), TypeInfoPropertyName = "ResizeAdImageQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.WebhookSigningJwks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.WebhookSigningJwk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.WebhookSigningJwk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ProvenanceVerifyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ProvenanceVerifyResponseValidationState), TypeInfoPropertyName = "ProvenanceVerifyResponseValidationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ProvenanceVerifyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ManageApiSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MetronomeLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RechargeSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Price))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RechargeSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiSubscriptionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ManageApiCreditSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.CreditGrant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CreditGrant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiReactivateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.RedactedApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RedactedApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CreateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiKeyStatus), TypeInfoPropertyName = "ApiKeyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PatchApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ManageApiStripeSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ManageApiPaymentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetApiTermsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiTerms))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiTermsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostAddCreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostAddCreditsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostAddCreditsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetUserCreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SpendCommitInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.SpendCommitInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SpendCommitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetUsageInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.UsageSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UsageSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ToolUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolType), TypeInfoPropertyName = "ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelVersion), TypeInfoPropertyName = "ModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SegmentBy), TypeInfoPropertyName = "SegmentBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UsageSource), TypeInfoPropertyName = "UsageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetApiProfilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ApiProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileType), TypeInfoPropertyName = "ApiProfileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileRole), TypeInfoPropertyName = "ApiProfileRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ApiProfileApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpdateOrganizationApiPropertiesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpdateOrganizationApiPropertiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetApiOrganizationUserSuggestionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ApiOrganizationUserSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiOrganizationUserSuggestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetOrganizationMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.OrganizationMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OrganizationMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CreateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetApiKeysV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OrganizationMemberOperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.OrganizationMemberOperationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OrganizationMemberOperationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AddOrganizationMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.LiteOrganizationMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LiteOrganizationMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveOrganizationMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PromoteOrganizationAdminsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DemoteOrganizationAdminsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CancelOrganizationInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResendOrganizationInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListOrganizationInvoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.Invoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Invoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InvoiceStatus), TypeInfoPropertyName = "InvoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.InvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InvoiceLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetOrganizationBillingPortalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListDatasetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CreateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DatasetFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DatasetFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UploadDatasetAssetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DatasetUploadSucceededAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DatasetUploadSucceededAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DatasetUploadFailedAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DatasetUploadFailedAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DatasetAssetFailureReason), TypeInfoPropertyName = "DatasetAssetFailureReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UploadDatasetAssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainDatasetModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainDatasetModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.CustomModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CustomModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelStatus), TypeInfoPropertyName = "ModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.TrainingRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainingRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainingRunStatus), TypeInfoPropertyName = "TrainingRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainModelV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainModelV3AdvancedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainModelV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainModelV4AdvancedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PublishMiniAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PublishMiniAppRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PublishMiniAppRequestEmbed), TypeInfoPropertyName = "PublishMiniAppRequestEmbed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MiniAppArtwork))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PublishMiniAppPreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PublishMiniAppPreviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PublishMiniAppPreviewRequestEmbed), TypeInfoPropertyName = "PublishMiniAppPreviewRequestEmbed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UnpublishMiniAppPreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetStaleMiniAppPreviewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.MiniAppMarketingProjectionEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MiniAppMarketingProjectionEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MiniAppMarketingProjectionEntryEmbed), TypeInfoPropertyName = "MiniAppMarketingProjectionEntryEmbed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.IntegrationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IntegrationType), TypeInfoPropertyName = "IntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IntegrationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IntegrationErrorResponseError), TypeInfoPropertyName = "IntegrationErrorResponseError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IntegrationAssetSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.IntegrationAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IntegrationAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IntegrationAssetDelivery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IntegrationAssetSearchRequest))]
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
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostInternalTesting200Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType), TypeInfoPropertyName = "GenerationResponseDataInnerDiscriminatorObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole), TypeInfoPropertyName = "MagicPromptRequestMessagesInnerRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DatasetCoverAssetIdentifier), TypeInfoPropertyName = "DatasetCoverAssetIdentifier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ToolType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListCustomModelsScope), TypeInfoPropertyName = "ListCustomModelsScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ModelStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DescribeModelVersion?), TypeInfoPropertyName = "NullableDescribeModelVersion2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalTestingEnumField?), TypeInfoPropertyName = "NullableInternalTestingEnumField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Resolution?), TypeInfoPropertyName = "NullableResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatio?), TypeInfoPropertyName = "NullableAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptVersionEnum?), TypeInfoPropertyName = "NullableMagicPromptVersionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV4ResponseType?), TypeInfoPropertyName = "NullableImageGenerationResponseV4ResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseStatus?), TypeInfoPropertyName = "NullableGenerationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseResponseType?), TypeInfoPropertyName = "NullableGenerationResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance25Resolution?), TypeInfoPropertyName = "NullableSeedDance25Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3AspectRatio?), TypeInfoPropertyName = "NullableMinimaxH3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3Resolution?), TypeInfoPropertyName = "NullableMinimaxH3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.KlingV3AspectRatio?), TypeInfoPropertyName = "NullableKlingV3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.KlingV3ShotType?), TypeInfoPropertyName = "NullableKlingV3ShotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3PromptExpansionMode?), TypeInfoPropertyName = "NullableMinimaxH3PromptExpansionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GptImage2Quality?), TypeInfoPropertyName = "NullableGptImage2Quality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageTopazTextRefineRequestUpscaleFactor?), TypeInfoPropertyName = "NullableUpscaleImageTopazTextRefineRequestUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LookbookRequestCategory?), TypeInfoPropertyName = "NullableLookbookRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PackshotView?), TypeInfoPropertyName = "NullablePackshotView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequestResolution?), TypeInfoPropertyName = "NullableAdResizerRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdResizerRequestPlatform?), TypeInfoPropertyName = "NullableAdResizerRequestPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AdVariationsRequestVariationType?), TypeInfoPropertyName = "NullableAdVariationsRequestVariationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleToolRequestUpscaleFactor?), TypeInfoPropertyName = "NullableUpscaleToolRequestUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObjectObjectType?), TypeInfoPropertyName = "NullableLayerizedImageObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageGemini30ProRequestResolutionTier?), TypeInfoPropertyName = "NullableEditImageGemini30ProRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageIdeogram45RequestRenderingSpeed?), TypeInfoPropertyName = "NullableEditImageIdeogram45RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed?), TypeInfoPropertyName = "NullableRemixImageIdeogramV4RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4TransparentRequestOutputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4TransparentRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImagePImageIdeogramRequestResolution?), TypeInfoPropertyName = "NullableGenerateImagePImageIdeogramRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogram45RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGemini30ProRequestResolutionTier?), TypeInfoPropertyName = "NullableGenerateImageGemini30ProRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV2RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV2?), TypeInfoPropertyName = "NullableStyleTypeV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV2ARequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3RequestRenderingSpeed?), TypeInfoPropertyName = "NullableInpaintImageIdeogramV3RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed?), TypeInfoPropertyName = "NullableInpaintImageIdeogramV3CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed?), TypeInfoPropertyName = "NullableReframeImageIdeogramV3RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3CharacterRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3CharacterRequestStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed?), TypeInfoPropertyName = "NullableInpaintImageIdeogramV3CharacterRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType?), TypeInfoPropertyName = "NullableInpaintImageIdeogramV3CharacterRequestStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolTextToImageRequestResolutionTier?), TypeInfoPropertyName = "NullableToolTextToImageRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolImageToImageRequestResolutionTier?), TypeInfoPropertyName = "NullableToolImageToImageRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResizeAdImageRequestResolution?), TypeInfoPropertyName = "NullableResizeAdImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResizeAdImageQuality?), TypeInfoPropertyName = "NullableResizeAdImageQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ProvenanceVerifyResponseValidationState?), TypeInfoPropertyName = "NullableProvenanceVerifyResponseValidationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiKeyStatus?), TypeInfoPropertyName = "NullableApiKeyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolType?), TypeInfoPropertyName = "NullableToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelVersion?), TypeInfoPropertyName = "NullableModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SegmentBy?), TypeInfoPropertyName = "NullableSegmentBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UsageSource?), TypeInfoPropertyName = "NullableUsageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileType?), TypeInfoPropertyName = "NullableApiProfileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileRole?), TypeInfoPropertyName = "NullableApiProfileRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InvoiceStatus?), TypeInfoPropertyName = "NullableInvoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DatasetAssetFailureReason?), TypeInfoPropertyName = "NullableDatasetAssetFailureReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelStatus?), TypeInfoPropertyName = "NullableModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainingRunStatus?), TypeInfoPropertyName = "NullableTrainingRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PublishMiniAppRequestEmbed?), TypeInfoPropertyName = "NullablePublishMiniAppRequestEmbed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PublishMiniAppPreviewRequestEmbed?), TypeInfoPropertyName = "NullablePublishMiniAppPreviewRequestEmbed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MiniAppMarketingProjectionEntryEmbed?), TypeInfoPropertyName = "NullableMiniAppMarketingProjectionEntryEmbed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IntegrationType?), TypeInfoPropertyName = "NullableIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IntegrationErrorResponseError?), TypeInfoPropertyName = "NullableIntegrationErrorResponseError2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole?), TypeInfoPropertyName = "NullableMagicPromptRequestMessagesInnerRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DatasetCoverAssetIdentifier?), TypeInfoPropertyName = "NullableDatasetCoverAssetIdentifier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListCustomModelsScope?), TypeInfoPropertyName = "NullableListCustomModelsScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.Description>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.RemoveBackgroundImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.RemoveObjectImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.InternalTestingNestedObject>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.MagicPromptRequestMessagesInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextSpanV3FontFxItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LayeredAssetTextShadow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextSpanV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextItemV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DetectedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.InternalBatchResultsResponseResultsInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.VideoObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AssetIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.BackgroundRemovedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.EditImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.UpscaleImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LayerizedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.GeneratedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.RemixedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.InpaintedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.WebhookSigningJwk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.CreditGrant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.RedactedApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.SpendCommitInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.UsageSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ToolUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ApiProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ApiProfileApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ApiOrganizationUserSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.OrganizationMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.OrganizationMemberOperationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LiteOrganizationMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.Invoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.InvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DatasetFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DatasetUploadSucceededAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DatasetUploadFailedAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.CustomModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TrainingRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.MiniAppMarketingProjectionEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.IntegrationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.IntegrationAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V4PromptElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DetectedTextBlockFormattingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ToolType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ModelStatus>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Ideogram.JsonConverters.V4PromptElementJsonConverter());
            options.Converters.Add(new global::Ideogram.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter());
            options.Converters.Add(new global::Ideogram.JsonConverters.PostGenerateDesignV4200ResponseJsonConverter());
            options.Converters.Add(new global::Ideogram.JsonConverters.GenerationResponseDataInnerJsonConverter());
            options.Converters.Add(new global::Ideogram.JsonConverters.DatasetCoverAssetIdentifierJsonConverter());
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

                    || typeToConvert == typeof(global::Ideogram.InternalTestingEnumField)

                    || typeToConvert == typeof(global::Ideogram.InternalTestingEnumField?)

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

                    || typeToConvert == typeof(global::Ideogram.SeedDance25Resolution)

                    || typeToConvert == typeof(global::Ideogram.SeedDance25Resolution?)

                    || typeToConvert == typeof(global::Ideogram.UpscaleImageTopazTextRefineRequestUpscaleFactor)

                    || typeToConvert == typeof(global::Ideogram.UpscaleImageTopazTextRefineRequestUpscaleFactor?)

                    || typeToConvert == typeof(global::Ideogram.LookbookRequestCategory)

                    || typeToConvert == typeof(global::Ideogram.LookbookRequestCategory?)

                    || typeToConvert == typeof(global::Ideogram.PackshotView)

                    || typeToConvert == typeof(global::Ideogram.PackshotView?)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestResolution)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestResolution?)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestPlatform)

                    || typeToConvert == typeof(global::Ideogram.AdResizerRequestPlatform?)

                    || typeToConvert == typeof(global::Ideogram.AdVariationsRequestVariationType)

                    || typeToConvert == typeof(global::Ideogram.AdVariationsRequestVariationType?)

                    || typeToConvert == typeof(global::Ideogram.UpscaleToolRequestUpscaleFactor)

                    || typeToConvert == typeof(global::Ideogram.UpscaleToolRequestUpscaleFactor?)

                    || typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType)

                    || typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType?)

                    || typeToConvert == typeof(global::Ideogram.EditImageGemini30ProRequestResolutionTier)

                    || typeToConvert == typeof(global::Ideogram.EditImageGemini30ProRequestResolutionTier?)

                    || typeToConvert == typeof(global::Ideogram.EditImageIdeogram45RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.EditImageIdeogram45RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImagePImageIdeogramRequestResolution)

                    || typeToConvert == typeof(global::Ideogram.GenerateImagePImageIdeogramRequestResolution?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageGemini30ProRequestResolutionTier)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageGemini30ProRequestResolutionTier?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType?)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType)

                    || typeToConvert == typeof(global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType?)

                    || typeToConvert == typeof(global::Ideogram.ToolTextToImageRequestResolutionTier)

                    || typeToConvert == typeof(global::Ideogram.ToolTextToImageRequestResolutionTier?)

                    || typeToConvert == typeof(global::Ideogram.ToolImageToImageRequestResolutionTier)

                    || typeToConvert == typeof(global::Ideogram.ToolImageToImageRequestResolutionTier?)

                    || typeToConvert == typeof(global::Ideogram.ResizeAdImageRequestResolution)

                    || typeToConvert == typeof(global::Ideogram.ResizeAdImageRequestResolution?)

                    || typeToConvert == typeof(global::Ideogram.ResizeAdImageQuality)

                    || typeToConvert == typeof(global::Ideogram.ResizeAdImageQuality?)

                    || typeToConvert == typeof(global::Ideogram.ProvenanceVerifyResponseValidationState)

                    || typeToConvert == typeof(global::Ideogram.ProvenanceVerifyResponseValidationState?)

                    || typeToConvert == typeof(global::Ideogram.ApiKeyStatus)

                    || typeToConvert == typeof(global::Ideogram.ApiKeyStatus?)

                    || typeToConvert == typeof(global::Ideogram.ToolType)

                    || typeToConvert == typeof(global::Ideogram.ToolType?)

                    || typeToConvert == typeof(global::Ideogram.SegmentBy)

                    || typeToConvert == typeof(global::Ideogram.SegmentBy?)

                    || typeToConvert == typeof(global::Ideogram.UsageSource)

                    || typeToConvert == typeof(global::Ideogram.UsageSource?)

                    || typeToConvert == typeof(global::Ideogram.ModelVersion)

                    || typeToConvert == typeof(global::Ideogram.ModelVersion?)

                    || typeToConvert == typeof(global::Ideogram.ApiProfileType)

                    || typeToConvert == typeof(global::Ideogram.ApiProfileType?)

                    || typeToConvert == typeof(global::Ideogram.ApiProfileRole)

                    || typeToConvert == typeof(global::Ideogram.ApiProfileRole?)

                    || typeToConvert == typeof(global::Ideogram.InvoiceStatus)

                    || typeToConvert == typeof(global::Ideogram.InvoiceStatus?)

                    || typeToConvert == typeof(global::Ideogram.DatasetAssetFailureReason)

                    || typeToConvert == typeof(global::Ideogram.DatasetAssetFailureReason?)

                    || typeToConvert == typeof(global::Ideogram.ModelStatus)

                    || typeToConvert == typeof(global::Ideogram.ModelStatus?)

                    || typeToConvert == typeof(global::Ideogram.TrainingRunStatus)

                    || typeToConvert == typeof(global::Ideogram.TrainingRunStatus?)

                    || typeToConvert == typeof(global::Ideogram.PublishMiniAppRequestEmbed)

                    || typeToConvert == typeof(global::Ideogram.PublishMiniAppRequestEmbed?)

                    || typeToConvert == typeof(global::Ideogram.PublishMiniAppPreviewRequestEmbed)

                    || typeToConvert == typeof(global::Ideogram.PublishMiniAppPreviewRequestEmbed?)

                    || typeToConvert == typeof(global::Ideogram.MiniAppMarketingProjectionEntryEmbed)

                    || typeToConvert == typeof(global::Ideogram.MiniAppMarketingProjectionEntryEmbed?)

                    || typeToConvert == typeof(global::Ideogram.IntegrationType)

                    || typeToConvert == typeof(global::Ideogram.IntegrationType?)

                    || typeToConvert == typeof(global::Ideogram.IntegrationErrorResponseError)

                    || typeToConvert == typeof(global::Ideogram.IntegrationErrorResponseError?)

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

                    || typeToConvert == typeof(global::Ideogram.DescribeModelVersion)

                    || typeToConvert == typeof(global::Ideogram.DescribeModelVersion?)

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

                    || typeToConvert == typeof(global::Ideogram.MinimaxH3AspectRatio)

                    || typeToConvert == typeof(global::Ideogram.MinimaxH3AspectRatio?)

                    || typeToConvert == typeof(global::Ideogram.MinimaxH3Resolution)

                    || typeToConvert == typeof(global::Ideogram.MinimaxH3Resolution?)

                    || typeToConvert == typeof(global::Ideogram.KlingV3AspectRatio)

                    || typeToConvert == typeof(global::Ideogram.KlingV3AspectRatio?)

                    || typeToConvert == typeof(global::Ideogram.KlingV3ShotType)

                    || typeToConvert == typeof(global::Ideogram.KlingV3ShotType?)

                    || typeToConvert == typeof(global::Ideogram.MinimaxH3PromptExpansionMode)

                    || typeToConvert == typeof(global::Ideogram.MinimaxH3PromptExpansionMode?)

                    || typeToConvert == typeof(global::Ideogram.GptImage2Quality)

                    || typeToConvert == typeof(global::Ideogram.GptImage2Quality?)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV2)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV2?)

                    || typeToConvert == typeof(global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType)

                    || typeToConvert == typeof(global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType?)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType)

                    || typeToConvert == typeof(global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType?)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole?)

                    || typeToConvert == typeof(global::Ideogram.ListCustomModelsScope)

                    || typeToConvert == typeof(global::Ideogram.ListCustomModelsScope?);
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

                if (typeToConvert == typeof(global::Ideogram.InternalTestingEnumField))
                {
                    return new global::Ideogram.JsonConverters.InternalTestingEnumFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InternalTestingEnumField?))
                {
                    return new global::Ideogram.JsonConverters.InternalTestingEnumFieldNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.SeedDance25Resolution))
                {
                    return new global::Ideogram.JsonConverters.SeedDance25ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SeedDance25Resolution?))
                {
                    return new global::Ideogram.JsonConverters.SeedDance25ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.UpscaleImageTopazTextRefineRequestUpscaleFactor))
                {
                    return new global::Ideogram.JsonConverters.UpscaleImageTopazTextRefineRequestUpscaleFactorJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.UpscaleImageTopazTextRefineRequestUpscaleFactor?))
                {
                    return new global::Ideogram.JsonConverters.UpscaleImageTopazTextRefineRequestUpscaleFactorNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.UpscaleToolRequestUpscaleFactor))
                {
                    return new global::Ideogram.JsonConverters.UpscaleToolRequestUpscaleFactorJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.UpscaleToolRequestUpscaleFactor?))
                {
                    return new global::Ideogram.JsonConverters.UpscaleToolRequestUpscaleFactorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType))
                {
                    return new global::Ideogram.JsonConverters.LayerizedImageObjectObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType?))
                {
                    return new global::Ideogram.JsonConverters.LayerizedImageObjectObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.EditImageGemini30ProRequestResolutionTier))
                {
                    return new global::Ideogram.JsonConverters.EditImageGemini30ProRequestResolutionTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.EditImageGemini30ProRequestResolutionTier?))
                {
                    return new global::Ideogram.JsonConverters.EditImageGemini30ProRequestResolutionTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.EditImageIdeogram45RequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.EditImageIdeogram45RequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.EditImageIdeogram45RequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.EditImageIdeogram45RequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3CustomModelRequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3CustomModelRequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV4RequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV4RequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV4CustomModelRequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV4CustomModelRequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.RemixImageIdeogramV4RequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.RemixImageIdeogramV4RequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV4TransparentRequestOutputResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV4TransparentRequestOutputResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV4TransparentRequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV4TransparentRequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImagePImageIdeogramRequestResolution))
                {
                    return new global::Ideogram.JsonConverters.GenerateImagePImageIdeogramRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImagePImageIdeogramRequestResolution?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImagePImageIdeogramRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogram45RequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogram45RequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageGemini30ProRequestResolutionTier))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageGemini30ProRequestResolutionTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageGemini30ProRequestResolutionTier?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageGemini30ProRequestResolutionTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV2RequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV2RequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV2ARequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV2ARequestRenderingSpeedNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.ReframeImageIdeogramV3RequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.ReframeImageIdeogramV3RequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3CharacterRequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3CharacterRequestRenderingSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3CharacterRequestStyleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3CharacterRequestStyleTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.ToolTextToImageRequestResolutionTier))
                {
                    return new global::Ideogram.JsonConverters.ToolTextToImageRequestResolutionTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolTextToImageRequestResolutionTier?))
                {
                    return new global::Ideogram.JsonConverters.ToolTextToImageRequestResolutionTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolImageToImageRequestResolutionTier))
                {
                    return new global::Ideogram.JsonConverters.ToolImageToImageRequestResolutionTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolImageToImageRequestResolutionTier?))
                {
                    return new global::Ideogram.JsonConverters.ToolImageToImageRequestResolutionTierNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.ProvenanceVerifyResponseValidationState))
                {
                    return new global::Ideogram.JsonConverters.ProvenanceVerifyResponseValidationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ProvenanceVerifyResponseValidationState?))
                {
                    return new global::Ideogram.JsonConverters.ProvenanceVerifyResponseValidationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiKeyStatus))
                {
                    return new global::Ideogram.JsonConverters.ApiKeyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiKeyStatus?))
                {
                    return new global::Ideogram.JsonConverters.ApiKeyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolType))
                {
                    return new global::Ideogram.JsonConverters.ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolType?))
                {
                    return new global::Ideogram.JsonConverters.ToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SegmentBy))
                {
                    return new global::Ideogram.JsonConverters.SegmentByJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SegmentBy?))
                {
                    return new global::Ideogram.JsonConverters.SegmentByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.UsageSource))
                {
                    return new global::Ideogram.JsonConverters.UsageSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.UsageSource?))
                {
                    return new global::Ideogram.JsonConverters.UsageSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelVersion))
                {
                    return new global::Ideogram.JsonConverters.ModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelVersion?))
                {
                    return new global::Ideogram.JsonConverters.ModelVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiProfileType))
                {
                    return new global::Ideogram.JsonConverters.ApiProfileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiProfileType?))
                {
                    return new global::Ideogram.JsonConverters.ApiProfileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiProfileRole))
                {
                    return new global::Ideogram.JsonConverters.ApiProfileRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiProfileRole?))
                {
                    return new global::Ideogram.JsonConverters.ApiProfileRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InvoiceStatus))
                {
                    return new global::Ideogram.JsonConverters.InvoiceStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InvoiceStatus?))
                {
                    return new global::Ideogram.JsonConverters.InvoiceStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DatasetAssetFailureReason))
                {
                    return new global::Ideogram.JsonConverters.DatasetAssetFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DatasetAssetFailureReason?))
                {
                    return new global::Ideogram.JsonConverters.DatasetAssetFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelStatus))
                {
                    return new global::Ideogram.JsonConverters.ModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelStatus?))
                {
                    return new global::Ideogram.JsonConverters.ModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TrainingRunStatus))
                {
                    return new global::Ideogram.JsonConverters.TrainingRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.TrainingRunStatus?))
                {
                    return new global::Ideogram.JsonConverters.TrainingRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PublishMiniAppRequestEmbed))
                {
                    return new global::Ideogram.JsonConverters.PublishMiniAppRequestEmbedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PublishMiniAppRequestEmbed?))
                {
                    return new global::Ideogram.JsonConverters.PublishMiniAppRequestEmbedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PublishMiniAppPreviewRequestEmbed))
                {
                    return new global::Ideogram.JsonConverters.PublishMiniAppPreviewRequestEmbedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.PublishMiniAppPreviewRequestEmbed?))
                {
                    return new global::Ideogram.JsonConverters.PublishMiniAppPreviewRequestEmbedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MiniAppMarketingProjectionEntryEmbed))
                {
                    return new global::Ideogram.JsonConverters.MiniAppMarketingProjectionEntryEmbedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MiniAppMarketingProjectionEntryEmbed?))
                {
                    return new global::Ideogram.JsonConverters.MiniAppMarketingProjectionEntryEmbedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IntegrationType))
                {
                    return new global::Ideogram.JsonConverters.IntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IntegrationType?))
                {
                    return new global::Ideogram.JsonConverters.IntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IntegrationErrorResponseError))
                {
                    return new global::Ideogram.JsonConverters.IntegrationErrorResponseErrorJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IntegrationErrorResponseError?))
                {
                    return new global::Ideogram.JsonConverters.IntegrationErrorResponseErrorNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.DescribeModelVersion))
                {
                    return new global::Ideogram.JsonConverters.DescribeModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DescribeModelVersion?))
                {
                    return new global::Ideogram.JsonConverters.DescribeModelVersionNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.MinimaxH3AspectRatio))
                {
                    return new global::Ideogram.JsonConverters.MinimaxH3AspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MinimaxH3AspectRatio?))
                {
                    return new global::Ideogram.JsonConverters.MinimaxH3AspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MinimaxH3Resolution))
                {
                    return new global::Ideogram.JsonConverters.MinimaxH3ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MinimaxH3Resolution?))
                {
                    return new global::Ideogram.JsonConverters.MinimaxH3ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.KlingV3AspectRatio))
                {
                    return new global::Ideogram.JsonConverters.KlingV3AspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.KlingV3AspectRatio?))
                {
                    return new global::Ideogram.JsonConverters.KlingV3AspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.KlingV3ShotType))
                {
                    return new global::Ideogram.JsonConverters.KlingV3ShotTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.KlingV3ShotType?))
                {
                    return new global::Ideogram.JsonConverters.KlingV3ShotTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MinimaxH3PromptExpansionMode))
                {
                    return new global::Ideogram.JsonConverters.MinimaxH3PromptExpansionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MinimaxH3PromptExpansionMode?))
                {
                    return new global::Ideogram.JsonConverters.MinimaxH3PromptExpansionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GptImage2Quality))
                {
                    return new global::Ideogram.JsonConverters.GptImage2QualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GptImage2Quality?))
                {
                    return new global::Ideogram.JsonConverters.GptImage2QualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleTypeV2))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeV2JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleTypeV2?))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeV2NullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptRequestMessagesInnerRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole?))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptRequestMessagesInnerRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ListCustomModelsScope))
                {
                    return new global::Ideogram.JsonConverters.ListCustomModelsScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ListCustomModelsScope?))
                {
                    return new global::Ideogram.JsonConverters.ListCustomModelsScopeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}