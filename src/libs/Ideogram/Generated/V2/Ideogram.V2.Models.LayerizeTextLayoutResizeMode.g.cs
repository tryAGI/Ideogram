
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeTextLayoutResizeMode
    {
        /// <summary>
        ///
        /// </summary>
        AutoHeight,
        /// <summary>
        ///
        /// </summary>
        AutoWidth,
        /// <summary>
        ///
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeTextLayoutResizeModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextLayoutResizeMode value)
        {
            return value switch
            {
                LayerizeTextLayoutResizeMode.AutoHeight => "auto_height",
                LayerizeTextLayoutResizeMode.AutoWidth => "auto_width",
                LayerizeTextLayoutResizeMode.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextLayoutResizeMode? ToEnum(string value)
        {
            return value switch
            {
                "auto_height" => LayerizeTextLayoutResizeMode.AutoHeight,
                "auto_width" => LayerizeTextLayoutResizeMode.AutoWidth,
                "fixed" => LayerizeTextLayoutResizeMode.Fixed,
                _ => null,
            };
        }
    }
}