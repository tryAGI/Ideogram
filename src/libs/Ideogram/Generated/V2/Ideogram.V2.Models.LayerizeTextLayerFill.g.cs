#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct LayerizeTextLayerFill : global::System.IEquatable<LayerizeTextLayerFill>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.LayerizeTextLayerFillDiscriminatorType? Type { get; }

        /// <summary>
        /// LayerizeSolidFill variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.LayerizeTextLayerFillVariant1? Solid { get; init; }
#else
        public global::Ideogram.V2.LayerizeTextLayerFillVariant1? Solid { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Solid))]
#endif
        public bool IsSolid => Solid != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSolid(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.LayerizeTextLayerFillVariant1? value)
        {
            value = Solid;
            return IsSolid;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.LayerizeTextLayerFillVariant1 PickSolid() => Solid is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Solid' but the value was {ToString()}.");

        /// <summary>
        /// LayerizeGradientFill variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.LayerizeTextLayerFillVariant2? Gradient { get; init; }
#else
        public global::Ideogram.V2.LayerizeTextLayerFillVariant2? Gradient { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gradient))]
#endif
        public bool IsGradient => Gradient != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGradient(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.LayerizeTextLayerFillVariant2? value)
        {
            value = Gradient;
            return IsGradient;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.LayerizeTextLayerFillVariant2 PickGradient() => Gradient is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gradient' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LayerizeTextLayerFill(global::Ideogram.V2.LayerizeTextLayerFillVariant1 value) => new LayerizeTextLayerFill((global::Ideogram.V2.LayerizeTextLayerFillVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.LayerizeTextLayerFillVariant1?(LayerizeTextLayerFill @this) => @this.Solid;

        /// <summary>
        ///
        /// </summary>
        public LayerizeTextLayerFill(global::Ideogram.V2.LayerizeTextLayerFillVariant1? value)
        {
            Solid = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LayerizeTextLayerFill FromSolid(global::Ideogram.V2.LayerizeTextLayerFillVariant1? value) => new LayerizeTextLayerFill(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LayerizeTextLayerFill(global::Ideogram.V2.LayerizeTextLayerFillVariant2 value) => new LayerizeTextLayerFill((global::Ideogram.V2.LayerizeTextLayerFillVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.LayerizeTextLayerFillVariant2?(LayerizeTextLayerFill @this) => @this.Gradient;

        /// <summary>
        ///
        /// </summary>
        public LayerizeTextLayerFill(global::Ideogram.V2.LayerizeTextLayerFillVariant2? value)
        {
            Gradient = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LayerizeTextLayerFill FromGradient(global::Ideogram.V2.LayerizeTextLayerFillVariant2? value) => new LayerizeTextLayerFill(value);

        /// <summary>
        ///
        /// </summary>
        public LayerizeTextLayerFill(
            global::Ideogram.V2.LayerizeTextLayerFillDiscriminatorType? type,
            global::Ideogram.V2.LayerizeTextLayerFillVariant1? solid,
            global::Ideogram.V2.LayerizeTextLayerFillVariant2? gradient
            )
        {
            Type = type;

            Solid = solid;
            Gradient = gradient;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Gradient as object ??
            Solid as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Solid?.ToString() ??
            Gradient?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSolid && !IsGradient || !IsSolid && IsGradient;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Ideogram.V2.LayerizeTextLayerFillVariant1, TResult>? solid = null,
            global::System.Func<global::Ideogram.V2.LayerizeTextLayerFillVariant2, TResult>? gradient = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Solid is { } __value0 && solid != null)
            {
                return solid(__value0);
            }
            else if (Gradient is { } __value1 && gradient != null)
            {
                return gradient(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Ideogram.V2.LayerizeTextLayerFillVariant1>? solid = null,

            global::System.Action<global::Ideogram.V2.LayerizeTextLayerFillVariant2>? gradient = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Solid is { } __value0)
            {
                solid?.Invoke(__value0);
            }
            else if (Gradient is { } __value1)
            {
                gradient?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Ideogram.V2.LayerizeTextLayerFillVariant1>? solid = null,
            global::System.Action<global::Ideogram.V2.LayerizeTextLayerFillVariant2>? gradient = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Solid is { } __value0)
            {
                solid?.Invoke(__value0);
            }
            else if (Gradient is { } __value1)
            {
                gradient?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Solid,
                typeof(global::Ideogram.V2.LayerizeTextLayerFillVariant1),
                Gradient,
                typeof(global::Ideogram.V2.LayerizeTextLayerFillVariant2),
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
        public bool Equals(LayerizeTextLayerFill other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.LayerizeTextLayerFillVariant1?>.Default.Equals(Solid, other.Solid) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.LayerizeTextLayerFillVariant2?>.Default.Equals(Gradient, other.Gradient)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LayerizeTextLayerFill obj1, LayerizeTextLayerFill obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LayerizeTextLayerFill>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LayerizeTextLayerFill obj1, LayerizeTextLayerFill obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LayerizeTextLayerFill o && Equals(o);
        }
    }
}
