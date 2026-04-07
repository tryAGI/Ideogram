
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public enum DetectedTextBlockFormattingItem
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
    public static class DetectedTextBlockFormattingItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectedTextBlockFormattingItem value)
        {
            return value switch
            {
                DetectedTextBlockFormattingItem.AllCaps => "all_caps",
                DetectedTextBlockFormattingItem.Bold => "bold",
                DetectedTextBlockFormattingItem.Italic => "italic",
                DetectedTextBlockFormattingItem.SmallCaps => "small_caps",
                DetectedTextBlockFormattingItem.Strikethrough => "strikethrough",
                DetectedTextBlockFormattingItem.Subscript => "subscript",
                DetectedTextBlockFormattingItem.Superscript => "superscript",
                DetectedTextBlockFormattingItem.Underline => "underline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectedTextBlockFormattingItem? ToEnum(string value)
        {
            return value switch
            {
                "all_caps" => DetectedTextBlockFormattingItem.AllCaps,
                "bold" => DetectedTextBlockFormattingItem.Bold,
                "italic" => DetectedTextBlockFormattingItem.Italic,
                "small_caps" => DetectedTextBlockFormattingItem.SmallCaps,
                "strikethrough" => DetectedTextBlockFormattingItem.Strikethrough,
                "subscript" => DetectedTextBlockFormattingItem.Subscript,
                "superscript" => DetectedTextBlockFormattingItem.Superscript,
                "underline" => DetectedTextBlockFormattingItem.Underline,
                _ => null,
            };
        }
    }
}