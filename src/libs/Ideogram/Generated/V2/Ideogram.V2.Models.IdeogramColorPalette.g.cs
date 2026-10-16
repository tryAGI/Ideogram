#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
    /// </summary>
    public readonly partial struct IdeogramColorPalette : global::System.IEquatable<IdeogramColorPalette>
    {
        /// <summary>
        /// A color palette specified only via its name. Cannot be used in conjunction with members.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.IdeogramColorPaletteWithPresetName? IdeogramColorPaletteWithPresetName { get; init; }
#else
        public global::Ideogram.V2.IdeogramColorPaletteWithPresetName? IdeogramColorPaletteWithPresetName { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IdeogramColorPaletteWithPresetName))]
#endif
        public bool IsIdeogramColorPaletteWithPresetName => IdeogramColorPaletteWithPresetName != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIdeogramColorPaletteWithPresetName(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.IdeogramColorPaletteWithPresetName? value)
        {
            value = IdeogramColorPaletteWithPresetName;
            return IsIdeogramColorPaletteWithPresetName;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.IdeogramColorPaletteWithPresetName PickIdeogramColorPaletteWithPresetName() => IdeogramColorPaletteWithPresetName is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'IdeogramColorPaletteWithPresetName' but the value was {ToString()}.");

        /// <summary>
        /// A color palette represented only via its members. Cannot be used in conjunction with preset name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.ColorPaletteWithMembers? ColorPaletteWithMembers { get; init; }
#else
        public global::Ideogram.V2.ColorPaletteWithMembers? ColorPaletteWithMembers { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ColorPaletteWithMembers))]
#endif
        public bool IsColorPaletteWithMembers => ColorPaletteWithMembers != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickColorPaletteWithMembers(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.ColorPaletteWithMembers? value)
        {
            value = ColorPaletteWithMembers;
            return IsColorPaletteWithMembers;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.ColorPaletteWithMembers PickColorPaletteWithMembers() => ColorPaletteWithMembers is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ColorPaletteWithMembers' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IdeogramColorPalette(global::Ideogram.V2.IdeogramColorPaletteWithPresetName value) => new IdeogramColorPalette((global::Ideogram.V2.IdeogramColorPaletteWithPresetName?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.IdeogramColorPaletteWithPresetName?(IdeogramColorPalette @this) => @this.IdeogramColorPaletteWithPresetName;

        /// <summary>
        ///
        /// </summary>
        public IdeogramColorPalette(global::Ideogram.V2.IdeogramColorPaletteWithPresetName? value)
        {
            IdeogramColorPaletteWithPresetName = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IdeogramColorPalette FromIdeogramColorPaletteWithPresetName(global::Ideogram.V2.IdeogramColorPaletteWithPresetName? value) => new IdeogramColorPalette(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IdeogramColorPalette(global::Ideogram.V2.ColorPaletteWithMembers value) => new IdeogramColorPalette((global::Ideogram.V2.ColorPaletteWithMembers?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.ColorPaletteWithMembers?(IdeogramColorPalette @this) => @this.ColorPaletteWithMembers;

        /// <summary>
        ///
        /// </summary>
        public IdeogramColorPalette(global::Ideogram.V2.ColorPaletteWithMembers? value)
        {
            ColorPaletteWithMembers = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IdeogramColorPalette FromColorPaletteWithMembers(global::Ideogram.V2.ColorPaletteWithMembers? value) => new IdeogramColorPalette(value);

        /// <summary>
        ///
        /// </summary>
        public IdeogramColorPalette(
            global::Ideogram.V2.IdeogramColorPaletteWithPresetName? ideogramColorPaletteWithPresetName,
            global::Ideogram.V2.ColorPaletteWithMembers? colorPaletteWithMembers
            )
        {
            IdeogramColorPaletteWithPresetName = ideogramColorPaletteWithPresetName;
            ColorPaletteWithMembers = colorPaletteWithMembers;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ColorPaletteWithMembers as object ??
            IdeogramColorPaletteWithPresetName as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            IdeogramColorPaletteWithPresetName?.ToString() ??
            ColorPaletteWithMembers?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsIdeogramColorPaletteWithPresetName && !IsColorPaletteWithMembers || !IsIdeogramColorPaletteWithPresetName && IsColorPaletteWithMembers;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Ideogram.V2.IdeogramColorPaletteWithPresetName, TResult>? ideogramColorPaletteWithPresetName = null,
            global::System.Func<global::Ideogram.V2.ColorPaletteWithMembers, TResult>? colorPaletteWithMembers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IdeogramColorPaletteWithPresetName is { } __value0 && ideogramColorPaletteWithPresetName != null)
            {
                return ideogramColorPaletteWithPresetName(__value0);
            }
            else if (ColorPaletteWithMembers is { } __value1 && colorPaletteWithMembers != null)
            {
                return colorPaletteWithMembers(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Ideogram.V2.IdeogramColorPaletteWithPresetName>? ideogramColorPaletteWithPresetName = null,

            global::System.Action<global::Ideogram.V2.ColorPaletteWithMembers>? colorPaletteWithMembers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IdeogramColorPaletteWithPresetName is { } __value0)
            {
                ideogramColorPaletteWithPresetName?.Invoke(__value0);
            }
            else if (ColorPaletteWithMembers is { } __value1)
            {
                colorPaletteWithMembers?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Ideogram.V2.IdeogramColorPaletteWithPresetName>? ideogramColorPaletteWithPresetName = null,
            global::System.Action<global::Ideogram.V2.ColorPaletteWithMembers>? colorPaletteWithMembers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IdeogramColorPaletteWithPresetName is { } __value0)
            {
                ideogramColorPaletteWithPresetName?.Invoke(__value0);
            }
            else if (ColorPaletteWithMembers is { } __value1)
            {
                colorPaletteWithMembers?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IdeogramColorPaletteWithPresetName,
                typeof(global::Ideogram.V2.IdeogramColorPaletteWithPresetName),
                ColorPaletteWithMembers,
                typeof(global::Ideogram.V2.ColorPaletteWithMembers),
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
        public bool Equals(IdeogramColorPalette other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.IdeogramColorPaletteWithPresetName?>.Default.Equals(IdeogramColorPaletteWithPresetName, other.IdeogramColorPaletteWithPresetName) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.ColorPaletteWithMembers?>.Default.Equals(ColorPaletteWithMembers, other.ColorPaletteWithMembers)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IdeogramColorPalette obj1, IdeogramColorPalette obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IdeogramColorPalette>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IdeogramColorPalette obj1, IdeogramColorPalette obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IdeogramColorPalette o && Equals(o);
        }
    }
}
