
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextSpanV3FontFxItem
    {
        /// <summary>
        /// 
        /// </summary>
        Bold,
        /// <summary>
        /// 
        /// </summary>
        Italic,
        /// <summary>
        /// 
        /// </summary>
        Underline,
        /// <summary>
        /// 
        /// </summary>
        Strikethrough,
        /// <summary>
        /// 
        /// </summary>
        AllCaps,
        /// <summary>
        /// 
        /// </summary>
        SmallCaps,
        /// <summary>
        /// 
        /// </summary>
        Superscript,
        /// <summary>
        /// 
        /// </summary>
        Subscript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextSpanV3FontFxItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextSpanV3FontFxItem value)
        {
            return value switch
            {
                TextSpanV3FontFxItem.Bold => "bold",
                TextSpanV3FontFxItem.Italic => "italic",
                TextSpanV3FontFxItem.Underline => "underline",
                TextSpanV3FontFxItem.Strikethrough => "strikethrough",
                TextSpanV3FontFxItem.AllCaps => "all_caps",
                TextSpanV3FontFxItem.SmallCaps => "small_caps",
                TextSpanV3FontFxItem.Superscript => "superscript",
                TextSpanV3FontFxItem.Subscript => "subscript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextSpanV3FontFxItem? ToEnum(string value)
        {
            return value switch
            {
                "bold" => TextSpanV3FontFxItem.Bold,
                "italic" => TextSpanV3FontFxItem.Italic,
                "underline" => TextSpanV3FontFxItem.Underline,
                "strikethrough" => TextSpanV3FontFxItem.Strikethrough,
                "all_caps" => TextSpanV3FontFxItem.AllCaps,
                "small_caps" => TextSpanV3FontFxItem.SmallCaps,
                "superscript" => TextSpanV3FontFxItem.Superscript,
                "subscript" => TextSpanV3FontFxItem.Subscript,
                _ => null,
            };
        }
    }
}