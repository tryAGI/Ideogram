#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct LayerizeTextLayerShape : global::System.IEquatable<LayerizeTextLayerShape>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.LayerizeTextLayerShapeDiscriminatorType? Type { get; }

        /// <summary>
        /// LayerizeTextArc variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant1? Arc { get; init; }
#else
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant1? Arc { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Arc))]
#endif
        public bool IsArc => Arc != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArc(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.LayerizeTextLayerShapeVariant1? value)
        {
            value = Arc;
            return IsArc;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant1 PickArc() => Arc is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Arc' but the value was {ToString()}.");

        /// <summary>
        /// LayerizeTextPath variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant2? Path { get; init; }
#else
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant2? Path { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Path))]
#endif
        public bool IsPath => Path != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPath(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.LayerizeTextLayerShapeVariant2? value)
        {
            value = Path;
            return IsPath;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant2 PickPath() => Path is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Path' but the value was {ToString()}.");

        /// <summary>
        /// LayerizeTextEnvelope variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant3? Envelope { get; init; }
#else
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant3? Envelope { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Envelope))]
#endif
        public bool IsEnvelope => Envelope != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnvelope(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.LayerizeTextLayerShapeVariant3? value)
        {
            value = Envelope;
            return IsEnvelope;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant3 PickEnvelope() => Envelope is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Envelope' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LayerizeTextLayerShape(global::Ideogram.V2.LayerizeTextLayerShapeVariant1 value) => new LayerizeTextLayerShape((global::Ideogram.V2.LayerizeTextLayerShapeVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.LayerizeTextLayerShapeVariant1?(LayerizeTextLayerShape @this) => @this.Arc;

        /// <summary>
        ///
        /// </summary>
        public LayerizeTextLayerShape(global::Ideogram.V2.LayerizeTextLayerShapeVariant1? value)
        {
            Arc = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LayerizeTextLayerShape FromArc(global::Ideogram.V2.LayerizeTextLayerShapeVariant1? value) => new LayerizeTextLayerShape(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LayerizeTextLayerShape(global::Ideogram.V2.LayerizeTextLayerShapeVariant2 value) => new LayerizeTextLayerShape((global::Ideogram.V2.LayerizeTextLayerShapeVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.LayerizeTextLayerShapeVariant2?(LayerizeTextLayerShape @this) => @this.Path;

        /// <summary>
        ///
        /// </summary>
        public LayerizeTextLayerShape(global::Ideogram.V2.LayerizeTextLayerShapeVariant2? value)
        {
            Path = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LayerizeTextLayerShape FromPath(global::Ideogram.V2.LayerizeTextLayerShapeVariant2? value) => new LayerizeTextLayerShape(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LayerizeTextLayerShape(global::Ideogram.V2.LayerizeTextLayerShapeVariant3 value) => new LayerizeTextLayerShape((global::Ideogram.V2.LayerizeTextLayerShapeVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.LayerizeTextLayerShapeVariant3?(LayerizeTextLayerShape @this) => @this.Envelope;

        /// <summary>
        ///
        /// </summary>
        public LayerizeTextLayerShape(global::Ideogram.V2.LayerizeTextLayerShapeVariant3? value)
        {
            Envelope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LayerizeTextLayerShape FromEnvelope(global::Ideogram.V2.LayerizeTextLayerShapeVariant3? value) => new LayerizeTextLayerShape(value);

        /// <summary>
        ///
        /// </summary>
        public LayerizeTextLayerShape(
            global::Ideogram.V2.LayerizeTextLayerShapeDiscriminatorType? type,
            global::Ideogram.V2.LayerizeTextLayerShapeVariant1? arc,
            global::Ideogram.V2.LayerizeTextLayerShapeVariant2? path,
            global::Ideogram.V2.LayerizeTextLayerShapeVariant3? envelope
            )
        {
            Type = type;

            Arc = arc;
            Path = path;
            Envelope = envelope;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Envelope as object ??
            Path as object ??
            Arc as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Arc?.ToString() ??
            Path?.ToString() ??
            Envelope?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsArc && !IsPath && !IsEnvelope || !IsArc && IsPath && !IsEnvelope || !IsArc && !IsPath && IsEnvelope;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Ideogram.V2.LayerizeTextLayerShapeVariant1, TResult>? arc = null,
            global::System.Func<global::Ideogram.V2.LayerizeTextLayerShapeVariant2, TResult>? path = null,
            global::System.Func<global::Ideogram.V2.LayerizeTextLayerShapeVariant3, TResult>? envelope = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Arc is { } __value0 && arc != null)
            {
                return arc(__value0);
            }
            else if (Path is { } __value1 && path != null)
            {
                return path(__value1);
            }
            else if (Envelope is { } __value2 && envelope != null)
            {
                return envelope(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Ideogram.V2.LayerizeTextLayerShapeVariant1>? arc = null,

            global::System.Action<global::Ideogram.V2.LayerizeTextLayerShapeVariant2>? path = null,

            global::System.Action<global::Ideogram.V2.LayerizeTextLayerShapeVariant3>? envelope = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Arc is { } __value0)
            {
                arc?.Invoke(__value0);
            }
            else if (Path is { } __value1)
            {
                path?.Invoke(__value1);
            }
            else if (Envelope is { } __value2)
            {
                envelope?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Ideogram.V2.LayerizeTextLayerShapeVariant1>? arc = null,
            global::System.Action<global::Ideogram.V2.LayerizeTextLayerShapeVariant2>? path = null,
            global::System.Action<global::Ideogram.V2.LayerizeTextLayerShapeVariant3>? envelope = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Arc is { } __value0)
            {
                arc?.Invoke(__value0);
            }
            else if (Path is { } __value1)
            {
                path?.Invoke(__value1);
            }
            else if (Envelope is { } __value2)
            {
                envelope?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Arc,
                typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant1),
                Path,
                typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant2),
                Envelope,
                typeof(global::Ideogram.V2.LayerizeTextLayerShapeVariant3),
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
        public bool Equals(LayerizeTextLayerShape other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.LayerizeTextLayerShapeVariant1?>.Default.Equals(Arc, other.Arc) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.LayerizeTextLayerShapeVariant2?>.Default.Equals(Path, other.Path) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.LayerizeTextLayerShapeVariant3?>.Default.Equals(Envelope, other.Envelope)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LayerizeTextLayerShape obj1, LayerizeTextLayerShape obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LayerizeTextLayerShape>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LayerizeTextLayerShape obj1, LayerizeTextLayerShape obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LayerizeTextLayerShape o && Equals(o);
        }
    }
}
