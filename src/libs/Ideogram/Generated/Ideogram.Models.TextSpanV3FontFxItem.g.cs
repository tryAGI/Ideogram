
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
        AllCaps,
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
        SmallCaps,
        /// <summary>
        /// 
        /// </summary>
        Strikethrough,
        /// <summary>
        /// 
        /// </summary>
        Subscript,
        /// <summary>
        /// 
        /// </summary>
        Superscript,
        /// <summary>
        /// 
        /// </summary>
        Underline,
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
                TextSpanV3FontFxItem.AllCaps => "all_caps",
                TextSpanV3FontFxItem.Bold => "bold",
                TextSpanV3FontFxItem.Italic => "italic",
                TextSpanV3FontFxItem.SmallCaps => "small_caps",
                TextSpanV3FontFxItem.Strikethrough => "strikethrough",
                TextSpanV3FontFxItem.Subscript => "subscript",
                TextSpanV3FontFxItem.Superscript => "superscript",
                TextSpanV3FontFxItem.Underline => "underline",
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
                "all_caps" => TextSpanV3FontFxItem.AllCaps,
                "bold" => TextSpanV3FontFxItem.Bold,
                "italic" => TextSpanV3FontFxItem.Italic,
                "small_caps" => TextSpanV3FontFxItem.SmallCaps,
                "strikethrough" => TextSpanV3FontFxItem.Strikethrough,
                "subscript" => TextSpanV3FontFxItem.Subscript,
                "superscript" => TextSpanV3FontFxItem.Superscript,
                "underline" => TextSpanV3FontFxItem.Underline,
                _ => null,
            };
        }
    }
}