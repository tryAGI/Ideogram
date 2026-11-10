
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeTextSpanFormattingItems
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
    public static class LayerizeTextSpanFormattingItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextSpanFormattingItems value)
        {
            return value switch
            {
                LayerizeTextSpanFormattingItems.AllCaps => "all_caps",
                LayerizeTextSpanFormattingItems.Bold => "bold",
                LayerizeTextSpanFormattingItems.Italic => "italic",
                LayerizeTextSpanFormattingItems.SmallCaps => "small_caps",
                LayerizeTextSpanFormattingItems.Strikethrough => "strikethrough",
                LayerizeTextSpanFormattingItems.Subscript => "subscript",
                LayerizeTextSpanFormattingItems.Superscript => "superscript",
                LayerizeTextSpanFormattingItems.Underline => "underline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextSpanFormattingItems? ToEnum(string value)
        {
            return value switch
            {
                "all_caps" => LayerizeTextSpanFormattingItems.AllCaps,
                "bold" => LayerizeTextSpanFormattingItems.Bold,
                "italic" => LayerizeTextSpanFormattingItems.Italic,
                "small_caps" => LayerizeTextSpanFormattingItems.SmallCaps,
                "strikethrough" => LayerizeTextSpanFormattingItems.Strikethrough,
                "subscript" => LayerizeTextSpanFormattingItems.Subscript,
                "superscript" => LayerizeTextSpanFormattingItems.Superscript,
                "underline" => LayerizeTextSpanFormattingItems.Underline,
                _ => null,
            };
        }
    }
}