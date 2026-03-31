
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The type of list marker glyph, if any. Null for non-list items.<br/>
    /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum TextItemV3GlyphType
    {
        /// <summary>
        /// 
        /// </summary>
        Bullet,
        /// <summary>
        /// 
        /// </summary>
        Icon,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextItemV3GlyphTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextItemV3GlyphType value)
        {
            return value switch
            {
                TextItemV3GlyphType.Bullet => "bullet",
                TextItemV3GlyphType.Icon => "icon",
                TextItemV3GlyphType.Number => "number",
                TextItemV3GlyphType.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextItemV3GlyphType? ToEnum(string value)
        {
            return value switch
            {
                "bullet" => TextItemV3GlyphType.Bullet,
                "icon" => TextItemV3GlyphType.Icon,
                "number" => TextItemV3GlyphType.Number,
                "other" => TextItemV3GlyphType.Other,
                _ => null,
            };
        }
    }
}