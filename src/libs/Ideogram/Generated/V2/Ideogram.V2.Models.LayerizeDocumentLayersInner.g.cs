#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct LayerizeDocumentLayersInner : global::System.IEquatable<LayerizeDocumentLayersInner>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorType? Type { get; }

        /// <summary>
        /// LayerizeImageLayer variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1? Image { get; init; }
#else
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1? Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1 PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// LayerizeTextLayer variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2? Text { get; init; }
#else
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2 PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// LayerizeContainerLayer variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3? Container { get; init; }
#else
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3? Container { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Container))]
#endif
        public bool IsContainer => Container != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContainer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3? value)
        {
            value = Container;
            return IsContainer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3 PickContainer() => Container is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Container' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LayerizeDocumentLayersInner(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1 value) => new LayerizeDocumentLayersInner((global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1?(LayerizeDocumentLayersInner @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public LayerizeDocumentLayersInner(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LayerizeDocumentLayersInner FromImage(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1? value) => new LayerizeDocumentLayersInner(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LayerizeDocumentLayersInner(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2 value) => new LayerizeDocumentLayersInner((global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2?(LayerizeDocumentLayersInner @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public LayerizeDocumentLayersInner(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LayerizeDocumentLayersInner FromText(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2? value) => new LayerizeDocumentLayersInner(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LayerizeDocumentLayersInner(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3 value) => new LayerizeDocumentLayersInner((global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3?(LayerizeDocumentLayersInner @this) => @this.Container;

        /// <summary>
        ///
        /// </summary>
        public LayerizeDocumentLayersInner(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3? value)
        {
            Container = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LayerizeDocumentLayersInner FromContainer(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3? value) => new LayerizeDocumentLayersInner(value);

        /// <summary>
        ///
        /// </summary>
        public LayerizeDocumentLayersInner(
            global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorType? type,
            global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1? image,
            global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2? text,
            global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3? container
            )
        {
            Type = type;

            Image = image;
            Text = text;
            Container = container;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Container as object ??
            Text as object ??
            Image as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Image?.ToString() ??
            Text?.ToString() ??
            Container?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsImage && !IsText && !IsContainer || !IsImage && IsText && !IsContainer || !IsImage && !IsText && IsContainer;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1, TResult>? image = null,
            global::System.Func<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2, TResult>? text = null,
            global::System.Func<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3, TResult>? container = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Image is { } __value0 && image != null)
            {
                return image(__value0);
            }
            else if (Text is { } __value1 && text != null)
            {
                return text(__value1);
            }
            else if (Container is { } __value2 && container != null)
            {
                return container(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1>? image = null,

            global::System.Action<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2>? text = null,

            global::System.Action<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3>? container = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Image is { } __value0)
            {
                image?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
            else if (Container is { } __value2)
            {
                container?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1>? image = null,
            global::System.Action<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2>? text = null,
            global::System.Action<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3>? container = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Image is { } __value0)
            {
                image?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
            else if (Container is { } __value2)
            {
                container?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Image,
                typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1),
                Text,
                typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2),
                Container,
                typeof(global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3),
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
        public bool Equals(LayerizeDocumentLayersInner other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3?>.Default.Equals(Container, other.Container)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LayerizeDocumentLayersInner obj1, LayerizeDocumentLayersInner obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LayerizeDocumentLayersInner>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LayerizeDocumentLayersInner obj1, LayerizeDocumentLayersInner obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LayerizeDocumentLayersInner o && Equals(o);
        }
    }
}
