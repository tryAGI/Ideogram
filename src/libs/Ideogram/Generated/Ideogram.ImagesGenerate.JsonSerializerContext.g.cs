
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4), TypeInfoPropertyName = "ResolutionV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3), TypeInfoPropertyName = "AspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV3), TypeInfoPropertyName = "ResolutionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason), TypeInfoPropertyName = "GenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationQuality), TypeInfoPropertyName = "GenerationQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.GeneratedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GeneratedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3RequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV3RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptMode), TypeInfoPropertyName = "MagicPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPalette), TypeInfoPropertyName = "IdeogramColorPalette2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV3StyleType), TypeInfoPropertyName = "IdeogramV3StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV3StylePreset), TypeInfoPropertyName = "IdeogramV3StylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV3CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV4RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV4CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor), TypeInfoPropertyName = "GenerateImageIdeogramV3TransparentRequestUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV3TransparentRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV4AspectRatio), TypeInfoPropertyName = "IdeogramV4AspectRatio2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageNanoBanana2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageNanoBanana2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageNanoBanana2RequestResolutionTier), TypeInfoPropertyName = "GenerateImageNanoBanana2RequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageNanoBananaProResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageNanoBananaProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageNanoBananaProRequestResolutionTier), TypeInfoPropertyName = "GenerateImageNanoBananaProRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25FlareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25FlareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25FlareRequestBackground), TypeInfoPropertyName = "GenerateImageGptImage25FlareRequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25FlareRequestQuality), TypeInfoPropertyName = "GenerateImageGptImage25FlareRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25SunburstResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25SunburstRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestBackground), TypeInfoPropertyName = "GenerateImageGptImage25SunburstRequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestQuality), TypeInfoPropertyName = "GenerateImageGptImage25SunburstRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV2RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV2StyleType), TypeInfoPropertyName = "IdeogramV2StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2AResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2ARequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV2ARequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV3CharacterRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType), TypeInfoPropertyName = "GenerateImageIdeogramV3CharacterRequestStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPaletteWithPresetName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPalettePresetName), TypeInfoPropertyName = "IdeogramColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4?), TypeInfoPropertyName = "NullableResolutionV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3?), TypeInfoPropertyName = "NullableAspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV3?), TypeInfoPropertyName = "NullableResolutionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason?), TypeInfoPropertyName = "NullableGenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationQuality?), TypeInfoPropertyName = "NullableGenerationQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3RequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptMode?), TypeInfoPropertyName = "NullableMagicPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPalette?), TypeInfoPropertyName = "NullableIdeogramColorPalette2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV3StyleType?), TypeInfoPropertyName = "NullableIdeogramV3StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV3StylePreset?), TypeInfoPropertyName = "NullableIdeogramV3StylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3TransparentRequestUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3TransparentRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV4AspectRatio?), TypeInfoPropertyName = "NullableIdeogramV4AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4TransparentRequestOutputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4TransparentRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImagePImageIdeogramRequestResolution?), TypeInfoPropertyName = "NullableGenerateImagePImageIdeogramRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogram45RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageNanoBanana2RequestResolutionTier?), TypeInfoPropertyName = "NullableGenerateImageNanoBanana2RequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageNanoBananaProRequestResolutionTier?), TypeInfoPropertyName = "NullableGenerateImageNanoBananaProRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25FlareRequestBackground?), TypeInfoPropertyName = "NullableGenerateImageGptImage25FlareRequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25FlareRequestQuality?), TypeInfoPropertyName = "NullableGenerateImageGptImage25FlareRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestBackground?), TypeInfoPropertyName = "NullableGenerateImageGptImage25SunburstRequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestQuality?), TypeInfoPropertyName = "NullableGenerateImageGptImage25SunburstRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV2RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramV2StyleType?), TypeInfoPropertyName = "NullableIdeogramV2StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV2ARequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3CharacterRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3CharacterRequestStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType?), TypeInfoPropertyName = "NullableAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.IdeogramColorPalettePresetName?), TypeInfoPropertyName = "NullableIdeogramColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AssetIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.GeneratedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ColorPaletteMember>))]
    internal sealed partial class ImagesGenerateSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesGenerateSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImagesGenerateSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImagesGenerateSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImagePImageIdeogramRequestResolution)

                    || typeToConvert == typeof(global::Ideogram.GenerateImagePImageIdeogramRequestResolution?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageNanoBanana2RequestResolutionTier)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageNanoBanana2RequestResolutionTier?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageNanoBananaProRequestResolutionTier)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageNanoBananaProRequestResolutionTier?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25FlareRequestBackground)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25FlareRequestBackground?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25FlareRequestQuality)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25FlareRequestQuality?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestBackground)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestBackground?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestQuality)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestQuality?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType?)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV4)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV4?)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV3)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV3?)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV3)

                    || typeToConvert == typeof(global::Ideogram.ResolutionV3?)

                    || typeToConvert == typeof(global::Ideogram.AssetType)

                    || typeToConvert == typeof(global::Ideogram.AssetType?)

                    || typeToConvert == typeof(global::Ideogram.GenerationQuality)

                    || typeToConvert == typeof(global::Ideogram.GenerationQuality?)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptMode)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptMode?)

                    || typeToConvert == typeof(global::Ideogram.IdeogramColorPalettePresetName)

                    || typeToConvert == typeof(global::Ideogram.IdeogramColorPalettePresetName?)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV3StyleType)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV3StyleType?)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV3StylePreset)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV3StylePreset?)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV4AspectRatio)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV4AspectRatio?)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV2StyleType)

                    || typeToConvert == typeof(global::Ideogram.IdeogramV2StyleType?);
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

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3RequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3RequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3RequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3RequestRenderingSpeedNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3TransparentRequestUpscaleFactorJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3TransparentRequestUpscaleFactorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestRenderingSpeed))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3TransparentRequestRenderingSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3TransparentRequestRenderingSpeed?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageIdeogramV3TransparentRequestRenderingSpeedNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.GenerateImageNanoBanana2RequestResolutionTier))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageNanoBanana2RequestResolutionTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageNanoBanana2RequestResolutionTier?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageNanoBanana2RequestResolutionTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageNanoBananaProRequestResolutionTier))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageNanoBananaProRequestResolutionTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageNanoBananaProRequestResolutionTier?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageNanoBananaProRequestResolutionTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25FlareRequestBackground))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageGptImage25FlareRequestBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25FlareRequestBackground?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageGptImage25FlareRequestBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25FlareRequestQuality))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageGptImage25FlareRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25FlareRequestQuality?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageGptImage25FlareRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestBackground))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageGptImage25SunburstRequestBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestBackground?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageGptImage25SunburstRequestBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestQuality))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageGptImage25SunburstRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerateImageGptImage25SunburstRequestQuality?))
                {
                    return new global::Ideogram.JsonConverters.GenerateImageGptImage25SunburstRequestQualityNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.ResolutionV4))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV4JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV4?))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV3))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV3?))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV3))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ResolutionV3?))
                {
                    return new global::Ideogram.JsonConverters.ResolutionV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType?))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationQuality))
                {
                    return new global::Ideogram.JsonConverters.GenerationQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationQuality?))
                {
                    return new global::Ideogram.JsonConverters.GenerationQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptMode))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptMode?))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Ideogram.IdeogramV4AspectRatio))
                {
                    return new global::Ideogram.JsonConverters.IdeogramV4AspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IdeogramV4AspectRatio?))
                {
                    return new global::Ideogram.JsonConverters.IdeogramV4AspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IdeogramV2StyleType))
                {
                    return new global::Ideogram.JsonConverters.IdeogramV2StyleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.IdeogramV2StyleType?))
                {
                    return new global::Ideogram.JsonConverters.IdeogramV2StyleTypeNullableJsonConverter();
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
                    0 => new ImagesGenerateSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}