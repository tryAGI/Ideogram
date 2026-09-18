
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output background. `transparent` returns images with an alpha channel, `opaque` forces a solid background, and `auto` lets the model decide from the prompt.<br/>
    /// Default Value: auto
    /// </summary>
    public enum GenerateImageGptImage25SunburstRequestBackground
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Opaque,
        /// <summary>
        ///
        /// </summary>
        Transparent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateImageGptImage25SunburstRequestBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageGptImage25SunburstRequestBackground value)
        {
            return value switch
            {
                GenerateImageGptImage25SunburstRequestBackground.Auto => "auto",
                GenerateImageGptImage25SunburstRequestBackground.Opaque => "opaque",
                GenerateImageGptImage25SunburstRequestBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageGptImage25SunburstRequestBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GenerateImageGptImage25SunburstRequestBackground.Auto,
                "opaque" => GenerateImageGptImage25SunburstRequestBackground.Opaque,
                "transparent" => GenerateImageGptImage25SunburstRequestBackground.Transparent,
                _ => null,
            };
        }
    }
}