
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeFontStyle
    {
        /// <summary>
        ///
        /// </summary>
        Italic,
        /// <summary>
        ///
        /// </summary>
        Normal,
        /// <summary>
        ///
        /// </summary>
        Oblique,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeFontStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeFontStyle value)
        {
            return value switch
            {
                LayerizeFontStyle.Italic => "italic",
                LayerizeFontStyle.Normal => "normal",
                LayerizeFontStyle.Oblique => "oblique",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeFontStyle? ToEnum(string value)
        {
            return value switch
            {
                "italic" => LayerizeFontStyle.Italic,
                "normal" => LayerizeFontStyle.Normal,
                "oblique" => LayerizeFontStyle.Oblique,
                _ => null,
            };
        }
    }
}