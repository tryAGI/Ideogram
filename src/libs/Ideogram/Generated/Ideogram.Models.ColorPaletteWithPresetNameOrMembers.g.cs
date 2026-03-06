#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members). Not supported by V_1, V_1_TURBO, V_2A and V_2A_TURBO models.
    /// </summary>
    public readonly partial struct ColorPaletteWithPresetNameOrMembers : global::System.IEquatable<ColorPaletteWithPresetNameOrMembers>
    {
        /// <summary>
        /// Example: {"name":"PASTEL"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.ColorPaletteWithPresetName? ColorPaletteWithPresetName { get; init; }
#else
        public global::Ideogram.ColorPaletteWithPresetName? ColorPaletteWithPresetName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ColorPaletteWithPresetName))]
#endif
        public bool IsColorPaletteWithPresetName => ColorPaletteWithPresetName != null;

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
        public static implicit operator ColorPaletteWithPresetNameOrMembers(global::Ideogram.ColorPaletteWithPresetName value) => new ColorPaletteWithPresetNameOrMembers((global::Ideogram.ColorPaletteWithPresetName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Ideogram.ColorPaletteWithPresetName?(ColorPaletteWithPresetNameOrMembers @this) => @this.ColorPaletteWithPresetName;

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(global::Ideogram.ColorPaletteWithPresetName? value)
        {
            ColorPaletteWithPresetName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColorPaletteWithPresetNameOrMembers(global::Ideogram.ColorPaletteWithMembers value) => new ColorPaletteWithPresetNameOrMembers((global::Ideogram.ColorPaletteWithMembers?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Ideogram.ColorPaletteWithMembers?(ColorPaletteWithPresetNameOrMembers @this) => @this.ColorPaletteWithMembers;

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(global::Ideogram.ColorPaletteWithMembers? value)
        {
            ColorPaletteWithMembers = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(
            global::Ideogram.ColorPaletteWithPresetName? colorPaletteWithPresetName,
            global::Ideogram.ColorPaletteWithMembers? colorPaletteWithMembers
            )
        {
            ColorPaletteWithPresetName = colorPaletteWithPresetName;
            ColorPaletteWithMembers = colorPaletteWithMembers;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ColorPaletteWithMembers as object ??
            ColorPaletteWithPresetName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ColorPaletteWithPresetName?.ToString() ??
            ColorPaletteWithMembers?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsColorPaletteWithPresetName && !IsColorPaletteWithMembers || !IsColorPaletteWithPresetName && IsColorPaletteWithMembers;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Ideogram.ColorPaletteWithPresetName?, TResult>? colorPaletteWithPresetName = null,
            global::System.Func<global::Ideogram.ColorPaletteWithMembers?, TResult>? colorPaletteWithMembers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsColorPaletteWithPresetName && colorPaletteWithPresetName != null)
            {
                return colorPaletteWithPresetName(ColorPaletteWithPresetName!);
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
            global::System.Action<global::Ideogram.ColorPaletteWithPresetName?>? colorPaletteWithPresetName = null,
            global::System.Action<global::Ideogram.ColorPaletteWithMembers?>? colorPaletteWithMembers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsColorPaletteWithPresetName)
            {
                colorPaletteWithPresetName?.Invoke(ColorPaletteWithPresetName!);
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
                ColorPaletteWithPresetName,
                typeof(global::Ideogram.ColorPaletteWithPresetName),
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
        public bool Equals(ColorPaletteWithPresetNameOrMembers other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.ColorPaletteWithPresetName?>.Default.Equals(ColorPaletteWithPresetName, other.ColorPaletteWithPresetName) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.ColorPaletteWithMembers?>.Default.Equals(ColorPaletteWithMembers, other.ColorPaletteWithMembers) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ColorPaletteWithPresetNameOrMembers obj1, ColorPaletteWithPresetNameOrMembers obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ColorPaletteWithPresetNameOrMembers>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ColorPaletteWithPresetNameOrMembers obj1, ColorPaletteWithPresetNameOrMembers obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ColorPaletteWithPresetNameOrMembers o && Equals(o);
        }
    }
}
