
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output background. `TRANSPARENT` returns images with an alpha channel, `OPAQUE` forces a solid background, and `AUTO` lets the model decide from the prompt.<br/>
    /// Default Value: AUTO
    /// </summary>
    public enum GenerateImageGptImage25FlareRequestBackground
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
    public static class GenerateImageGptImage25FlareRequestBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageGptImage25FlareRequestBackground value)
        {
            return value switch
            {
                GenerateImageGptImage25FlareRequestBackground.Auto => "AUTO",
                GenerateImageGptImage25FlareRequestBackground.Opaque => "OPAQUE",
                GenerateImageGptImage25FlareRequestBackground.Transparent => "TRANSPARENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageGptImage25FlareRequestBackground? ToEnum(string value)
        {
            return value switch
            {
                "AUTO" => GenerateImageGptImage25FlareRequestBackground.Auto,
                "OPAQUE" => GenerateImageGptImage25FlareRequestBackground.Opaque,
                "TRANSPARENT" => GenerateImageGptImage25FlareRequestBackground.Transparent,
                _ => null,
            };
        }
    }
}