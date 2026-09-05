#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GenerationResponseDataInner : global::System.IEquatable<GenerationResponseDataInner>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType? ObjectType { get; }

        /// <summary>
        /// An image result that does not expose its prompt or seed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.ImageObjectWithoutPromptOrSeed? ImageWithoutPromptOrSeed { get; init; }
#else
        public global::Ideogram.ImageObjectWithoutPromptOrSeed? ImageWithoutPromptOrSeed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageWithoutPromptOrSeed))]
#endif
        public bool IsImageWithoutPromptOrSeed => ImageWithoutPromptOrSeed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageWithoutPromptOrSeed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.ImageObjectWithoutPromptOrSeed? value)
        {
            value = ImageWithoutPromptOrSeed;
            return IsImageWithoutPromptOrSeed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.ImageObjectWithoutPromptOrSeed PickImageWithoutPromptOrSeed() => IsImageWithoutPromptOrSeed
            ? ImageWithoutPromptOrSeed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageWithoutPromptOrSeed' but the value was {ToString()}.");

        /// <summary>
        /// A single generated image. Model-agnostic shape returned by the generation polling endpoint.<br/>
        /// Example: {"seed":12345,"object_type":"image.generation","prompt":"prompt","resolution":"2048x2048","url":"https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804\u0026sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89","is_image_safe":true}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.ImageGenerationObject? ImageGeneration { get; init; }
#else
        public global::Ideogram.ImageGenerationObject? ImageGeneration { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGeneration))]
#endif
        public bool IsImageGeneration => ImageGeneration != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.ImageGenerationObject? value)
        {
            value = ImageGeneration;
            return IsImageGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.ImageGenerationObject PickImageGeneration() => IsImageGeneration
            ? ImageGeneration!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGeneration' but the value was {ToString()}.");

        /// <summary>
        /// A single generated video returned by the generation polling endpoint.<br/>
        /// Example: {"duration":5,"aspect_ratio":969,"object_type":"video.generation","prompt":"prompt","resolution":"720p","url":"https://ideogram.ai/assets/video/lossless/response/xtdZiqPwRxqY1Y7NExFmzB.mp4?exp=1743867804\u0026sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.VideoObject? VideoGeneration { get; init; }
#else
        public global::Ideogram.VideoObject? VideoGeneration { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoGeneration))]
#endif
        public bool IsVideoGeneration => VideoGeneration != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideoGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.VideoObject? value)
        {
            value = VideoGeneration;
            return IsVideoGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.VideoObject PickVideoGeneration() => IsVideoGeneration
            ? VideoGeneration!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoGeneration' but the value was {ToString()}.");

        /// <summary>
        /// One layerized design. Image links are available for a limited period<br/>
        /// of time; if you would like to keep an image, you must download it.<br/>
        /// Example: {"seed":12345,"object_type":"layerized_image","resolution":"1024x1024","url":"https://openapi-generator.tech","base_image_url":"https://openapi-generator.tech","is_image_safe":true,"text_blocks":[{"role":"heading","color":"#212121","font_alternatives":["font_alternatives","font_alternatives"],"font_size":2,"font_name":"font_name","line_height":7.0614014,"x":0,"width":1,"y":6,"angle":5.637377,"text":"Hello World","alignment":"left","formatting":["bold","bold"],"height":5},{"role":"heading","color":"#212121","font_alternatives":["font_alternatives","font_alternatives"],"font_size":2,"font_name":"font_name","line_height":7.0614014,"x":0,"width":1,"y":6,"angle":5.637377,"text":"Hello World","alignment":"left","formatting":["bold","bold"],"height":5}]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.LayerizedImageObject? LayerizedImage { get; init; }
#else
        public global::Ideogram.LayerizedImageObject? LayerizedImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LayerizedImage))]
#endif
        public bool IsLayerizedImage => LayerizedImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLayerizedImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.LayerizedImageObject? value)
        {
            value = LayerizedImage;
            return IsLayerizedImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.LayerizedImageObject PickLayerizedImage() => IsLayerizedImage
            ? LayerizedImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LayerizedImage' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerationResponseDataInner(global::Ideogram.ImageObjectWithoutPromptOrSeed value) => new GenerationResponseDataInner((global::Ideogram.ImageObjectWithoutPromptOrSeed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.ImageObjectWithoutPromptOrSeed?(GenerationResponseDataInner @this) => @this.ImageWithoutPromptOrSeed;

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(global::Ideogram.ImageObjectWithoutPromptOrSeed? value)
        {
            ImageWithoutPromptOrSeed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataInner FromImageWithoutPromptOrSeed(global::Ideogram.ImageObjectWithoutPromptOrSeed? value) => new GenerationResponseDataInner(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerationResponseDataInner(global::Ideogram.ImageGenerationObject value) => new GenerationResponseDataInner((global::Ideogram.ImageGenerationObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.ImageGenerationObject?(GenerationResponseDataInner @this) => @this.ImageGeneration;

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(global::Ideogram.ImageGenerationObject? value)
        {
            ImageGeneration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataInner FromImageGeneration(global::Ideogram.ImageGenerationObject? value) => new GenerationResponseDataInner(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerationResponseDataInner(global::Ideogram.VideoObject value) => new GenerationResponseDataInner((global::Ideogram.VideoObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.VideoObject?(GenerationResponseDataInner @this) => @this.VideoGeneration;

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(global::Ideogram.VideoObject? value)
        {
            VideoGeneration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataInner FromVideoGeneration(global::Ideogram.VideoObject? value) => new GenerationResponseDataInner(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerationResponseDataInner(global::Ideogram.LayerizedImageObject value) => new GenerationResponseDataInner((global::Ideogram.LayerizedImageObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.LayerizedImageObject?(GenerationResponseDataInner @this) => @this.LayerizedImage;

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(global::Ideogram.LayerizedImageObject? value)
        {
            LayerizedImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataInner FromLayerizedImage(global::Ideogram.LayerizedImageObject? value) => new GenerationResponseDataInner(value);

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(
            global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType? objectType,
            global::Ideogram.ImageObjectWithoutPromptOrSeed? imageWithoutPromptOrSeed,
            global::Ideogram.ImageGenerationObject? imageGeneration,
            global::Ideogram.VideoObject? videoGeneration,
            global::Ideogram.LayerizedImageObject? layerizedImage
            )
        {
            ObjectType = objectType;

            ImageWithoutPromptOrSeed = imageWithoutPromptOrSeed;
            ImageGeneration = imageGeneration;
            VideoGeneration = videoGeneration;
            LayerizedImage = layerizedImage;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            LayerizedImage as object ??
            VideoGeneration as object ??
            ImageGeneration as object ??
            ImageWithoutPromptOrSeed as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ImageWithoutPromptOrSeed?.ToString() ??
            ImageGeneration?.ToString() ??
            VideoGeneration?.ToString() ??
            LayerizedImage?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsImageWithoutPromptOrSeed && !IsImageGeneration && !IsVideoGeneration && !IsLayerizedImage || !IsImageWithoutPromptOrSeed && IsImageGeneration && !IsVideoGeneration && !IsLayerizedImage || !IsImageWithoutPromptOrSeed && !IsImageGeneration && IsVideoGeneration && !IsLayerizedImage || !IsImageWithoutPromptOrSeed && !IsImageGeneration && !IsVideoGeneration && IsLayerizedImage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Ideogram.ImageObjectWithoutPromptOrSeed, TResult>? imageWithoutPromptOrSeed = null,
            global::System.Func<global::Ideogram.ImageGenerationObject, TResult>? imageGeneration = null,
            global::System.Func<global::Ideogram.VideoObject, TResult>? videoGeneration = null,
            global::System.Func<global::Ideogram.LayerizedImageObject, TResult>? layerizedImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageWithoutPromptOrSeed && imageWithoutPromptOrSeed != null)
            {
                return imageWithoutPromptOrSeed(ImageWithoutPromptOrSeed!);
            }
            else if (IsImageGeneration && imageGeneration != null)
            {
                return imageGeneration(ImageGeneration!);
            }
            else if (IsVideoGeneration && videoGeneration != null)
            {
                return videoGeneration(VideoGeneration!);
            }
            else if (IsLayerizedImage && layerizedImage != null)
            {
                return layerizedImage(LayerizedImage!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Ideogram.ImageObjectWithoutPromptOrSeed>? imageWithoutPromptOrSeed = null,

            global::System.Action<global::Ideogram.ImageGenerationObject>? imageGeneration = null,

            global::System.Action<global::Ideogram.VideoObject>? videoGeneration = null,

            global::System.Action<global::Ideogram.LayerizedImageObject>? layerizedImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageWithoutPromptOrSeed)
            {
                imageWithoutPromptOrSeed?.Invoke(ImageWithoutPromptOrSeed!);
            }
            else if (IsImageGeneration)
            {
                imageGeneration?.Invoke(ImageGeneration!);
            }
            else if (IsVideoGeneration)
            {
                videoGeneration?.Invoke(VideoGeneration!);
            }
            else if (IsLayerizedImage)
            {
                layerizedImage?.Invoke(LayerizedImage!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Ideogram.ImageObjectWithoutPromptOrSeed>? imageWithoutPromptOrSeed = null,
            global::System.Action<global::Ideogram.ImageGenerationObject>? imageGeneration = null,
            global::System.Action<global::Ideogram.VideoObject>? videoGeneration = null,
            global::System.Action<global::Ideogram.LayerizedImageObject>? layerizedImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageWithoutPromptOrSeed)
            {
                imageWithoutPromptOrSeed?.Invoke(ImageWithoutPromptOrSeed!);
            }
            else if (IsImageGeneration)
            {
                imageGeneration?.Invoke(ImageGeneration!);
            }
            else if (IsVideoGeneration)
            {
                videoGeneration?.Invoke(VideoGeneration!);
            }
            else if (IsLayerizedImage)
            {
                layerizedImage?.Invoke(LayerizedImage!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageWithoutPromptOrSeed,
                typeof(global::Ideogram.ImageObjectWithoutPromptOrSeed),
                ImageGeneration,
                typeof(global::Ideogram.ImageGenerationObject),
                VideoGeneration,
                typeof(global::Ideogram.VideoObject),
                LayerizedImage,
                typeof(global::Ideogram.LayerizedImageObject),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GenerationResponseDataInner other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.ImageObjectWithoutPromptOrSeed?>.Default.Equals(ImageWithoutPromptOrSeed, other.ImageWithoutPromptOrSeed) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.ImageGenerationObject?>.Default.Equals(ImageGeneration, other.ImageGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.VideoObject?>.Default.Equals(VideoGeneration, other.VideoGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.LayerizedImageObject?>.Default.Equals(LayerizedImage, other.LayerizedImage)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GenerationResponseDataInner obj1, GenerationResponseDataInner obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerationResponseDataInner>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GenerationResponseDataInner obj1, GenerationResponseDataInner obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerationResponseDataInner o && Equals(o);
        }
    }
}
