using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
    /// </summary>
    public readonly partial struct ColorPaletteWithPresetNameOrMembers : global::System.IEquatable<ColorPaletteWithPresetNameOrMembers>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.ColorPaletteWithPresetName?  { get; init; }
#else
        public global::Ideogram.ColorPaletteWithPresetName?  { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof())]
#endif
        public bool Is =>  != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColorPaletteWithPresetNameOrMembers(global::Ideogram.ColorPaletteWithPresetName value) => new ColorPaletteWithPresetNameOrMembers(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Ideogram.ColorPaletteWithPresetName?(ColorPaletteWithPresetNameOrMembers @this) => @this.;

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(global::Ideogram.ColorPaletteWithPresetName? value)
        {
             = value;
        }

        /// <summary>
        /// A color palette represented only via its members
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.ColorPaletteWithMembers?  { get; init; }
#else
        public global::Ideogram.ColorPaletteWithMembers?  { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof())]
#endif
        public bool Is =>  != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColorPaletteWithPresetNameOrMembers(global::Ideogram.ColorPaletteWithMembers value) => new ColorPaletteWithPresetNameOrMembers(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Ideogram.ColorPaletteWithMembers?(ColorPaletteWithPresetNameOrMembers @this) => @this.;

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(global::Ideogram.ColorPaletteWithMembers? value)
        {
             = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(
            global::Ideogram.ColorPaletteWithPresetName? ,
            global::Ideogram.ColorPaletteWithMembers? 
            )
        {
             = ;
             = ;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
             as object ??
             as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return Is && !Is || !Is && Is;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ,
                typeof(global::Ideogram.ColorPaletteWithPresetName),
                ,
                typeof(global::Ideogram.ColorPaletteWithMembers),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ColorPaletteWithPresetNameOrMembers other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.ColorPaletteWithPresetName?>.Default.Equals(, other.) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.ColorPaletteWithMembers?>.Default.Equals(, other.) 
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
