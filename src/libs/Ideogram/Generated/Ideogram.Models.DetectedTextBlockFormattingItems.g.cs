
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum DetectedTextBlockFormattingItems
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
    public static class DetectedTextBlockFormattingItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectedTextBlockFormattingItems value)
        {
            return value switch
            {
                DetectedTextBlockFormattingItems.AllCaps => "all_caps",
                DetectedTextBlockFormattingItems.Bold => "bold",
                DetectedTextBlockFormattingItems.Italic => "italic",
                DetectedTextBlockFormattingItems.SmallCaps => "small_caps",
                DetectedTextBlockFormattingItems.Strikethrough => "strikethrough",
                DetectedTextBlockFormattingItems.Subscript => "subscript",
                DetectedTextBlockFormattingItems.Superscript => "superscript",
                DetectedTextBlockFormattingItems.Underline => "underline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectedTextBlockFormattingItems? ToEnum(string value)
        {
            return value switch
            {
                "all_caps" => DetectedTextBlockFormattingItems.AllCaps,
                "bold" => DetectedTextBlockFormattingItems.Bold,
                "italic" => DetectedTextBlockFormattingItems.Italic,
                "small_caps" => DetectedTextBlockFormattingItems.SmallCaps,
                "strikethrough" => DetectedTextBlockFormattingItems.Strikethrough,
                "subscript" => DetectedTextBlockFormattingItems.Subscript,
                "superscript" => DetectedTextBlockFormattingItems.Superscript,
                "underline" => DetectedTextBlockFormattingItems.Underline,
                _ => null,
            };
        }
    }
}