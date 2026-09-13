
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RenderingSpeed), TypeInfoPropertyName = "RenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV4), TypeInfoPropertyName = "AspectRatioV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptOption), TypeInfoPropertyName = "MagicPromptOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Quality), TypeInfoPropertyName = "Quality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3), TypeInfoPropertyName = "AspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV3), TypeInfoPropertyName = "ResolutionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithPresetNameOrMembers), TypeInfoPropertyName = "ColorPaletteWithPresetNameOrMembers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV3), TypeInfoPropertyName = "StyleTypeV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StylePresetV3), TypeInfoPropertyName = "StylePresetV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleFactor), TypeInfoPropertyName = "UpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason), TypeInfoPropertyName = "GenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed), TypeInfoPropertyName = "GenerateImageIdeogramV3CharacterRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType), TypeInfoPropertyName = "GenerateImageIdeogramV3CharacterRequestStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithPresetName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPalettePresetName), TypeInfoPropertyName = "ColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4?), TypeInfoPropertyName = "NullableResolutionV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RenderingSpeed?), TypeInfoPropertyName = "NullableRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV4?), TypeInfoPropertyName = "NullableAspectRatioV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptOption?), TypeInfoPropertyName = "NullableMagicPromptOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Quality?), TypeInfoPropertyName = "NullableQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3?), TypeInfoPropertyName = "NullableAspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV3?), TypeInfoPropertyName = "NullableResolutionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithPresetNameOrMembers?), TypeInfoPropertyName = "NullableColorPaletteWithPresetNameOrMembers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV3?), TypeInfoPropertyName = "NullableStyleTypeV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StylePresetV3?), TypeInfoPropertyName = "NullableStylePresetV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleFactor?), TypeInfoPropertyName = "NullableUpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason?), TypeInfoPropertyName = "NullableGenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4CustomModelRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4TransparentRequestOutputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV4TransparentRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImagePImageIdeogramRequestResolution?), TypeInfoPropertyName = "NullableGenerateImagePImageIdeogramRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogram45RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageGemini30ProRequestResolutionTier?), TypeInfoPropertyName = "NullableGenerateImageGemini30ProRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2RequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV2RequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV2?), TypeInfoPropertyName = "NullableStyleTypeV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV2ARequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV2ARequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3CharacterRequestRenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType?), TypeInfoPropertyName = "NullableGenerateImageIdeogramV3CharacterRequestStyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPalettePresetName?), TypeInfoPropertyName = "NullableColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType?), TypeInfoPropertyName = "NullableAssetType2")]
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
            options.Converters.Add(new global::Ideogram.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter());
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

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CustomModelRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4RequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed?)

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

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed?)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType)

                    || typeToConvert == typeof(global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType?)

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

                    || typeToConvert == typeof(global::Ideogram.AssetType)

                    || typeToConvert == typeof(global::Ideogram.AssetType?)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV2)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV2?);
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

                if (typeToConvert == typeof(global::Ideogram.AssetType))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType?))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleTypeV2))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeV2JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleTypeV2?))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeV2NullableJsonConverter();
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