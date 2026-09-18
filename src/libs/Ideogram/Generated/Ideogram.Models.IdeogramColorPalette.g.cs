#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram
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
        public global::Ideogram.IdeogramColorPaletteWithPresetName? IdeogramColorPaletteWithPresetName { get; init; }
#else
        public global::Ideogram.IdeogramColorPaletteWithPresetName? IdeogramColorPaletteWithPresetName { get; }
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
            out global::Ideogram.IdeogramColorPaletteWithPresetName? value)
        {
            value = IdeogramColorPaletteWithPresetName;
            return IsIdeogramColorPaletteWithPresetName;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.IdeogramColorPaletteWithPresetName PickIdeogramColorPaletteWithPresetName() => IsIdeogramColorPaletteWithPresetName
            ? IdeogramColorPaletteWithPresetName!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IdeogramColorPaletteWithPresetName' but the value was {ToString()}.");

        /// <summary>
        /// A color palette represented only via its members. Cannot be used in conjunction with preset name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.ColorPaletteWithMembers? ColorPaletteWithMembers { get; init; }
#else
        public global::Ideogram.ColorPaletteWithMembers? ColorPaletteWithMembers { get; }
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
            out global::Ideogram.ColorPaletteWithMembers? value)
        {
            value = ColorPaletteWithMembers;
            return IsColorPaletteWithMembers;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.ColorPaletteWithMembers PickColorPaletteWithMembers() => IsColorPaletteWithMembers
            ? ColorPaletteWithMembers!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ColorPaletteWithMembers' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IdeogramColorPalette(global::Ideogram.IdeogramColorPaletteWithPresetName value) => new IdeogramColorPalette((global::Ideogram.IdeogramColorPaletteWithPresetName?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.IdeogramColorPaletteWithPresetName?(IdeogramColorPalette @this) => @this.IdeogramColorPaletteWithPresetName;

        /// <summary>
        ///
        /// </summary>
        public IdeogramColorPalette(global::Ideogram.IdeogramColorPaletteWithPresetName? value)
        {
            IdeogramColorPaletteWithPresetName = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IdeogramColorPalette FromIdeogramColorPaletteWithPresetName(global::Ideogram.IdeogramColorPaletteWithPresetName? value) => new IdeogramColorPalette(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IdeogramColorPalette(global::Ideogram.ColorPaletteWithMembers value) => new IdeogramColorPalette((global::Ideogram.ColorPaletteWithMembers?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.ColorPaletteWithMembers?(IdeogramColorPalette @this) => @this.ColorPaletteWithMembers;

        /// <summary>
        ///
        /// </summary>
        public IdeogramColorPalette(global::Ideogram.ColorPaletteWithMembers? value)
        {
            ColorPaletteWithMembers = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IdeogramColorPalette FromColorPaletteWithMembers(global::Ideogram.ColorPaletteWithMembers? value) => new IdeogramColorPalette(value);

        /// <summary>
        ///
        /// </summary>
        public IdeogramColorPalette(
            global::Ideogram.IdeogramColorPaletteWithPresetName? ideogramColorPaletteWithPresetName,
            global::Ideogram.ColorPaletteWithMembers? colorPaletteWithMembers
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
            global::System.Func<global::Ideogram.IdeogramColorPaletteWithPresetName, TResult>? ideogramColorPaletteWithPresetName = null,
            global::System.Func<global::Ideogram.ColorPaletteWithMembers, TResult>? colorPaletteWithMembers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIdeogramColorPaletteWithPresetName && ideogramColorPaletteWithPresetName != null)
            {
                return ideogramColorPaletteWithPresetName(IdeogramColorPaletteWithPresetName!);
            }
            else if (IsColorPaletteWithMembers && colorPaletteWithMembers != null)
            {
                return colorPaletteWithMembers(ColorPaletteWithMembers!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Ideogram.IdeogramColorPaletteWithPresetName>? ideogramColorPaletteWithPresetName = null,

            global::System.Action<global::Ideogram.ColorPaletteWithMembers>? colorPaletteWithMembers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIdeogramColorPaletteWithPresetName)
            {
                ideogramColorPaletteWithPresetName?.Invoke(IdeogramColorPaletteWithPresetName!);
            }
            else if (IsColorPaletteWithMembers)
            {
                colorPaletteWithMembers?.Invoke(ColorPaletteWithMembers!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Ideogram.IdeogramColorPaletteWithPresetName>? ideogramColorPaletteWithPresetName = null,
            global::System.Action<global::Ideogram.ColorPaletteWithMembers>? colorPaletteWithMembers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIdeogramColorPaletteWithPresetName)
            {
                ideogramColorPaletteWithPresetName?.Invoke(IdeogramColorPaletteWithPresetName!);
            }
            else if (IsColorPaletteWithMembers)
            {
                colorPaletteWithMembers?.Invoke(ColorPaletteWithMembers!);
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
                typeof(global::Ideogram.IdeogramColorPaletteWithPresetName),
                ColorPaletteWithMembers,
                typeof(global::Ideogram.ColorPaletteWithMembers),
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
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.IdeogramColorPaletteWithPresetName?>.Default.Equals(IdeogramColorPaletteWithPresetName, other.IdeogramColorPaletteWithPresetName) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.ColorPaletteWithMembers?>.Default.Equals(ColorPaletteWithMembers, other.ColorPaletteWithMembers)
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
