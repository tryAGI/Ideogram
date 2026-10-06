#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct LayerizedTextBlock : global::System.IEquatable<LayerizedTextBlock>
    {
        /// <summary>
        /// A single detected text region with its position, content, font information, and styling.<br/>
        /// Example: {"role":"heading","color":"#212121","font_alternatives":["font_alternatives","font_alternatives"],"font_size":2,"font_name":"font_name","line_height":7.0614014,"x":0,"width":1,"y":6,"angle":5.637377,"text":"Hello World","alignment":"left","formatting":["bold","bold"],"height":5}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.DetectedTextBlock? DetectedTextBlock { get; init; }
#else
        public global::Ideogram.DetectedTextBlock? DetectedTextBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetectedTextBlock))]
#endif
        public bool IsDetectedTextBlock => DetectedTextBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDetectedTextBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.DetectedTextBlock? value)
        {
            value = DetectedTextBlock;
            return IsDetectedTextBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.DetectedTextBlock PickDetectedTextBlock() => DetectedTextBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DetectedTextBlock' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.LayerizedTextBlockVariant2? LayerizedTextBlockVariant2 { get; init; }
#else
        public global::Ideogram.LayerizedTextBlockVariant2? LayerizedTextBlockVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LayerizedTextBlockVariant2))]
#endif
        public bool IsLayerizedTextBlockVariant2 => LayerizedTextBlockVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLayerizedTextBlockVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.LayerizedTextBlockVariant2? value)
        {
            value = LayerizedTextBlockVariant2;
            return IsLayerizedTextBlockVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.LayerizedTextBlockVariant2 PickLayerizedTextBlockVariant2() => LayerizedTextBlockVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LayerizedTextBlockVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LayerizedTextBlock(global::Ideogram.DetectedTextBlock value) => new LayerizedTextBlock((global::Ideogram.DetectedTextBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.DetectedTextBlock?(LayerizedTextBlock @this) => @this.DetectedTextBlock;

        /// <summary>
        ///
        /// </summary>
        public LayerizedTextBlock(global::Ideogram.DetectedTextBlock? value)
        {
            DetectedTextBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LayerizedTextBlock FromDetectedTextBlock(global::Ideogram.DetectedTextBlock? value) => new LayerizedTextBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LayerizedTextBlock(global::Ideogram.LayerizedTextBlockVariant2 value) => new LayerizedTextBlock((global::Ideogram.LayerizedTextBlockVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.LayerizedTextBlockVariant2?(LayerizedTextBlock @this) => @this.LayerizedTextBlockVariant2;

        /// <summary>
        ///
        /// </summary>
        public LayerizedTextBlock(global::Ideogram.LayerizedTextBlockVariant2? value)
        {
            LayerizedTextBlockVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LayerizedTextBlock FromLayerizedTextBlockVariant2(global::Ideogram.LayerizedTextBlockVariant2? value) => new LayerizedTextBlock(value);

        /// <summary>
        ///
        /// </summary>
        public LayerizedTextBlock(
            global::Ideogram.DetectedTextBlock? detectedTextBlock,
            global::Ideogram.LayerizedTextBlockVariant2? layerizedTextBlockVariant2
            )
        {
            DetectedTextBlock = detectedTextBlock;
            LayerizedTextBlockVariant2 = layerizedTextBlockVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            LayerizedTextBlockVariant2 as object ??
            DetectedTextBlock as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DetectedTextBlock?.ToString() ??
            LayerizedTextBlockVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDetectedTextBlock && IsLayerizedTextBlockVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Ideogram.DetectedTextBlock, TResult>? detectedTextBlock = null,
            global::System.Func<global::Ideogram.LayerizedTextBlockVariant2, TResult>? layerizedTextBlockVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DetectedTextBlock is { } __value0 && detectedTextBlock != null)
            {
                return detectedTextBlock(__value0);
            }
            else if (LayerizedTextBlockVariant2 is { } __value1 && layerizedTextBlockVariant2 != null)
            {
                return layerizedTextBlockVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Ideogram.DetectedTextBlock>? detectedTextBlock = null,

            global::System.Action<global::Ideogram.LayerizedTextBlockVariant2>? layerizedTextBlockVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DetectedTextBlock is { } __value0)
            {
                detectedTextBlock?.Invoke(__value0);
            }
            else if (LayerizedTextBlockVariant2 is { } __value1)
            {
                layerizedTextBlockVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Ideogram.DetectedTextBlock>? detectedTextBlock = null,
            global::System.Action<global::Ideogram.LayerizedTextBlockVariant2>? layerizedTextBlockVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DetectedTextBlock is { } __value0)
            {
                detectedTextBlock?.Invoke(__value0);
            }
            else if (LayerizedTextBlockVariant2 is { } __value1)
            {
                layerizedTextBlockVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DetectedTextBlock,
                typeof(global::Ideogram.DetectedTextBlock),
                LayerizedTextBlockVariant2,
                typeof(global::Ideogram.LayerizedTextBlockVariant2),
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
        public bool Equals(LayerizedTextBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.DetectedTextBlock?>.Default.Equals(DetectedTextBlock, other.DetectedTextBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.LayerizedTextBlockVariant2?>.Default.Equals(LayerizedTextBlockVariant2, other.LayerizedTextBlockVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LayerizedTextBlock obj1, LayerizedTextBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LayerizedTextBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LayerizedTextBlock obj1, LayerizedTextBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LayerizedTextBlock o && Equals(o);
        }
    }
}
