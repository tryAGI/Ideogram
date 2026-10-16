#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GenerationResponseDataInner : global::System.IEquatable<GenerationResponseDataInner>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorObjectType? ObjectType { get; }

        /// <summary>
        /// An image result that does not expose its prompt or seed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.GenerationResponseDataInnerVariant1? ImageWithoutPromptOrSeed { get; init; }
#else
        public global::Ideogram.V2.GenerationResponseDataInnerVariant1? ImageWithoutPromptOrSeed { get; }
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
            out global::Ideogram.V2.GenerationResponseDataInnerVariant1? value)
        {
            value = ImageWithoutPromptOrSeed;
            return IsImageWithoutPromptOrSeed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.GenerationResponseDataInnerVariant1 PickImageWithoutPromptOrSeed() => ImageWithoutPromptOrSeed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageWithoutPromptOrSeed' but the value was {ToString()}.");

        /// <summary>
        /// SvgGenerationObject variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.GenerationResponseDataInnerVariant2? SvgGeneration { get; init; }
#else
        public global::Ideogram.V2.GenerationResponseDataInnerVariant2? SvgGeneration { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SvgGeneration))]
#endif
        public bool IsSvgGeneration => SvgGeneration != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSvgGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.GenerationResponseDataInnerVariant2? value)
        {
            value = SvgGeneration;
            return IsSvgGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.GenerationResponseDataInnerVariant2 PickSvgGeneration() => SvgGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SvgGeneration' but the value was {ToString()}.");

        /// <summary>
        /// A single generated image. Model-agnostic shape returned by the generation polling endpoint.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.GenerationResponseDataInnerVariant3? ImageGeneration { get; init; }
#else
        public global::Ideogram.V2.GenerationResponseDataInnerVariant3? ImageGeneration { get; }
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
            out global::Ideogram.V2.GenerationResponseDataInnerVariant3? value)
        {
            value = ImageGeneration;
            return IsImageGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.GenerationResponseDataInnerVariant3 PickImageGeneration() => ImageGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGeneration' but the value was {ToString()}.");

        /// <summary>
        /// A single generated video returned by the generation polling endpoint.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.GenerationResponseDataInnerVariant4? VideoGeneration { get; init; }
#else
        public global::Ideogram.V2.GenerationResponseDataInnerVariant4? VideoGeneration { get; }
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
            out global::Ideogram.V2.GenerationResponseDataInnerVariant4? value)
        {
            value = VideoGeneration;
            return IsVideoGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.GenerationResponseDataInnerVariant4 PickVideoGeneration() => VideoGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoGeneration' but the value was {ToString()}.");

        /// <summary>
        /// One layerized design. Image links are available for a limited period<br/>
        /// of time; if you would like to keep an image, you must download it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.GenerationResponseDataInnerVariant5? LayerizedImage { get; init; }
#else
        public global::Ideogram.V2.GenerationResponseDataInnerVariant5? LayerizedImage { get; }
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
            out global::Ideogram.V2.GenerationResponseDataInnerVariant5? value)
        {
            value = LayerizedImage;
            return IsLayerizedImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.GenerationResponseDataInnerVariant5 PickLayerizedImage() => LayerizedImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LayerizedImage' but the value was {ToString()}.");

        /// <summary>
        /// One layerized design. Links are available for a limited period of time;<br/>
        /// if you would like to keep a file, you must download it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.GenerationResponseDataInnerVariant6? LayerizedDesignGeneration { get; init; }
#else
        public global::Ideogram.V2.GenerationResponseDataInnerVariant6? LayerizedDesignGeneration { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LayerizedDesignGeneration))]
#endif
        public bool IsLayerizedDesignGeneration => LayerizedDesignGeneration != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLayerizedDesignGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.GenerationResponseDataInnerVariant6? value)
        {
            value = LayerizedDesignGeneration;
            return IsLayerizedDesignGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.GenerationResponseDataInnerVariant6 PickLayerizedDesignGeneration() => LayerizedDesignGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LayerizedDesignGeneration' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant1 value) => new GenerationResponseDataInner((global::Ideogram.V2.GenerationResponseDataInnerVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.GenerationResponseDataInnerVariant1?(GenerationResponseDataInner @this) => @this.ImageWithoutPromptOrSeed;

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant1? value)
        {
            ImageWithoutPromptOrSeed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataInner FromImageWithoutPromptOrSeed(global::Ideogram.V2.GenerationResponseDataInnerVariant1? value) => new GenerationResponseDataInner(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant2 value) => new GenerationResponseDataInner((global::Ideogram.V2.GenerationResponseDataInnerVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.GenerationResponseDataInnerVariant2?(GenerationResponseDataInner @this) => @this.SvgGeneration;

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant2? value)
        {
            SvgGeneration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataInner FromSvgGeneration(global::Ideogram.V2.GenerationResponseDataInnerVariant2? value) => new GenerationResponseDataInner(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant3 value) => new GenerationResponseDataInner((global::Ideogram.V2.GenerationResponseDataInnerVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.GenerationResponseDataInnerVariant3?(GenerationResponseDataInner @this) => @this.ImageGeneration;

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant3? value)
        {
            ImageGeneration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataInner FromImageGeneration(global::Ideogram.V2.GenerationResponseDataInnerVariant3? value) => new GenerationResponseDataInner(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant4 value) => new GenerationResponseDataInner((global::Ideogram.V2.GenerationResponseDataInnerVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.GenerationResponseDataInnerVariant4?(GenerationResponseDataInner @this) => @this.VideoGeneration;

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant4? value)
        {
            VideoGeneration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataInner FromVideoGeneration(global::Ideogram.V2.GenerationResponseDataInnerVariant4? value) => new GenerationResponseDataInner(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant5 value) => new GenerationResponseDataInner((global::Ideogram.V2.GenerationResponseDataInnerVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.GenerationResponseDataInnerVariant5?(GenerationResponseDataInner @this) => @this.LayerizedImage;

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant5? value)
        {
            LayerizedImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataInner FromLayerizedImage(global::Ideogram.V2.GenerationResponseDataInnerVariant5? value) => new GenerationResponseDataInner(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant6 value) => new GenerationResponseDataInner((global::Ideogram.V2.GenerationResponseDataInnerVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.GenerationResponseDataInnerVariant6?(GenerationResponseDataInner @this) => @this.LayerizedDesignGeneration;

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(global::Ideogram.V2.GenerationResponseDataInnerVariant6? value)
        {
            LayerizedDesignGeneration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataInner FromLayerizedDesignGeneration(global::Ideogram.V2.GenerationResponseDataInnerVariant6? value) => new GenerationResponseDataInner(value);

        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataInner(
            global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorObjectType? objectType,
            global::Ideogram.V2.GenerationResponseDataInnerVariant1? imageWithoutPromptOrSeed,
            global::Ideogram.V2.GenerationResponseDataInnerVariant2? svgGeneration,
            global::Ideogram.V2.GenerationResponseDataInnerVariant3? imageGeneration,
            global::Ideogram.V2.GenerationResponseDataInnerVariant4? videoGeneration,
            global::Ideogram.V2.GenerationResponseDataInnerVariant5? layerizedImage,
            global::Ideogram.V2.GenerationResponseDataInnerVariant6? layerizedDesignGeneration
            )
        {
            ObjectType = objectType;

            ImageWithoutPromptOrSeed = imageWithoutPromptOrSeed;
            SvgGeneration = svgGeneration;
            ImageGeneration = imageGeneration;
            VideoGeneration = videoGeneration;
            LayerizedImage = layerizedImage;
            LayerizedDesignGeneration = layerizedDesignGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            LayerizedDesignGeneration as object ??
            LayerizedImage as object ??
            VideoGeneration as object ??
            ImageGeneration as object ??
            SvgGeneration as object ??
            ImageWithoutPromptOrSeed as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ImageWithoutPromptOrSeed?.ToString() ??
            SvgGeneration?.ToString() ??
            ImageGeneration?.ToString() ??
            VideoGeneration?.ToString() ??
            LayerizedImage?.ToString() ??
            LayerizedDesignGeneration?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsImageWithoutPromptOrSeed && !IsSvgGeneration && !IsImageGeneration && !IsVideoGeneration && !IsLayerizedImage && !IsLayerizedDesignGeneration || !IsImageWithoutPromptOrSeed && IsSvgGeneration && !IsImageGeneration && !IsVideoGeneration && !IsLayerizedImage && !IsLayerizedDesignGeneration || !IsImageWithoutPromptOrSeed && !IsSvgGeneration && IsImageGeneration && !IsVideoGeneration && !IsLayerizedImage && !IsLayerizedDesignGeneration || !IsImageWithoutPromptOrSeed && !IsSvgGeneration && !IsImageGeneration && IsVideoGeneration && !IsLayerizedImage && !IsLayerizedDesignGeneration || !IsImageWithoutPromptOrSeed && !IsSvgGeneration && !IsImageGeneration && !IsVideoGeneration && IsLayerizedImage && !IsLayerizedDesignGeneration || !IsImageWithoutPromptOrSeed && !IsSvgGeneration && !IsImageGeneration && !IsVideoGeneration && !IsLayerizedImage && IsLayerizedDesignGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Ideogram.V2.GenerationResponseDataInnerVariant1, TResult>? imageWithoutPromptOrSeed = null,
            global::System.Func<global::Ideogram.V2.GenerationResponseDataInnerVariant2, TResult>? svgGeneration = null,
            global::System.Func<global::Ideogram.V2.GenerationResponseDataInnerVariant3, TResult>? imageGeneration = null,
            global::System.Func<global::Ideogram.V2.GenerationResponseDataInnerVariant4, TResult>? videoGeneration = null,
            global::System.Func<global::Ideogram.V2.GenerationResponseDataInnerVariant5, TResult>? layerizedImage = null,
            global::System.Func<global::Ideogram.V2.GenerationResponseDataInnerVariant6, TResult>? layerizedDesignGeneration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImageWithoutPromptOrSeed is { } __value0 && imageWithoutPromptOrSeed != null)
            {
                return imageWithoutPromptOrSeed(__value0);
            }
            else if (SvgGeneration is { } __value1 && svgGeneration != null)
            {
                return svgGeneration(__value1);
            }
            else if (ImageGeneration is { } __value2 && imageGeneration != null)
            {
                return imageGeneration(__value2);
            }
            else if (VideoGeneration is { } __value3 && videoGeneration != null)
            {
                return videoGeneration(__value3);
            }
            else if (LayerizedImage is { } __value4 && layerizedImage != null)
            {
                return layerizedImage(__value4);
            }
            else if (LayerizedDesignGeneration is { } __value5 && layerizedDesignGeneration != null)
            {
                return layerizedDesignGeneration(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant1>? imageWithoutPromptOrSeed = null,

            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant2>? svgGeneration = null,

            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant3>? imageGeneration = null,

            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant4>? videoGeneration = null,

            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant5>? layerizedImage = null,

            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant6>? layerizedDesignGeneration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImageWithoutPromptOrSeed is { } __value0)
            {
                imageWithoutPromptOrSeed?.Invoke(__value0);
            }
            else if (SvgGeneration is { } __value1)
            {
                svgGeneration?.Invoke(__value1);
            }
            else if (ImageGeneration is { } __value2)
            {
                imageGeneration?.Invoke(__value2);
            }
            else if (VideoGeneration is { } __value3)
            {
                videoGeneration?.Invoke(__value3);
            }
            else if (LayerizedImage is { } __value4)
            {
                layerizedImage?.Invoke(__value4);
            }
            else if (LayerizedDesignGeneration is { } __value5)
            {
                layerizedDesignGeneration?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant1>? imageWithoutPromptOrSeed = null,
            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant2>? svgGeneration = null,
            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant3>? imageGeneration = null,
            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant4>? videoGeneration = null,
            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant5>? layerizedImage = null,
            global::System.Action<global::Ideogram.V2.GenerationResponseDataInnerVariant6>? layerizedDesignGeneration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImageWithoutPromptOrSeed is { } __value0)
            {
                imageWithoutPromptOrSeed?.Invoke(__value0);
            }
            else if (SvgGeneration is { } __value1)
            {
                svgGeneration?.Invoke(__value1);
            }
            else if (ImageGeneration is { } __value2)
            {
                imageGeneration?.Invoke(__value2);
            }
            else if (VideoGeneration is { } __value3)
            {
                videoGeneration?.Invoke(__value3);
            }
            else if (LayerizedImage is { } __value4)
            {
                layerizedImage?.Invoke(__value4);
            }
            else if (LayerizedDesignGeneration is { } __value5)
            {
                layerizedDesignGeneration?.Invoke(__value5);
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
                typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant1),
                SvgGeneration,
                typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant2),
                ImageGeneration,
                typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant3),
                VideoGeneration,
                typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant4),
                LayerizedImage,
                typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant5),
                LayerizedDesignGeneration,
                typeof(global::Ideogram.V2.GenerationResponseDataInnerVariant6),
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
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.GenerationResponseDataInnerVariant1?>.Default.Equals(ImageWithoutPromptOrSeed, other.ImageWithoutPromptOrSeed) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.GenerationResponseDataInnerVariant2?>.Default.Equals(SvgGeneration, other.SvgGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.GenerationResponseDataInnerVariant3?>.Default.Equals(ImageGeneration, other.ImageGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.GenerationResponseDataInnerVariant4?>.Default.Equals(VideoGeneration, other.VideoGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.GenerationResponseDataInnerVariant5?>.Default.Equals(LayerizedImage, other.LayerizedImage) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.GenerationResponseDataInnerVariant6?>.Default.Equals(LayerizedDesignGeneration, other.LayerizedDesignGeneration)
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
