
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output background. `TRANSPARENT` returns images with an alpha channel, `OPAQUE` forces a solid background, and `AUTO` lets the model decide from the prompt.<br/>
    /// Default Value: AUTO
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
                GenerateImageGptImage25SunburstRequestBackground.Auto => "AUTO",
                GenerateImageGptImage25SunburstRequestBackground.Opaque => "OPAQUE",
                GenerateImageGptImage25SunburstRequestBackground.Transparent => "TRANSPARENT",
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
                "AUTO" => GenerateImageGptImage25SunburstRequestBackground.Auto,
                "OPAQUE" => GenerateImageGptImage25SunburstRequestBackground.Opaque,
                "TRANSPARENT" => GenerateImageGptImage25SunburstRequestBackground.Transparent,
                _ => null,
            };
        }
    }
}