
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizedTextBlockFormattingItems
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
    public static class LayerizedTextBlockFormattingItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizedTextBlockFormattingItems value)
        {
            return value switch
            {
                LayerizedTextBlockFormattingItems.AllCaps => "all_caps",
                LayerizedTextBlockFormattingItems.Bold => "bold",
                LayerizedTextBlockFormattingItems.Italic => "italic",
                LayerizedTextBlockFormattingItems.SmallCaps => "small_caps",
                LayerizedTextBlockFormattingItems.Strikethrough => "strikethrough",
                LayerizedTextBlockFormattingItems.Subscript => "subscript",
                LayerizedTextBlockFormattingItems.Superscript => "superscript",
                LayerizedTextBlockFormattingItems.Underline => "underline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizedTextBlockFormattingItems? ToEnum(string value)
        {
            return value switch
            {
                "all_caps" => LayerizedTextBlockFormattingItems.AllCaps,
                "bold" => LayerizedTextBlockFormattingItems.Bold,
                "italic" => LayerizedTextBlockFormattingItems.Italic,
                "small_caps" => LayerizedTextBlockFormattingItems.SmallCaps,
                "strikethrough" => LayerizedTextBlockFormattingItems.Strikethrough,
                "subscript" => LayerizedTextBlockFormattingItems.Subscript,
                "superscript" => LayerizedTextBlockFormattingItems.Superscript,
                "underline" => LayerizedTextBlockFormattingItems.Underline,
                _ => null,
            };
        }
    }
}