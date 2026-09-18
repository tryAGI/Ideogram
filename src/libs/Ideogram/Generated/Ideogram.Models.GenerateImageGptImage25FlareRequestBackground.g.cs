
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output background. `transparent` returns images with an alpha channel, `opaque` forces a solid background, and `auto` lets the model decide from the prompt.<br/>
    /// Default Value: auto
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
                GenerateImageGptImage25FlareRequestBackground.Auto => "auto",
                GenerateImageGptImage25FlareRequestBackground.Opaque => "opaque",
                GenerateImageGptImage25FlareRequestBackground.Transparent => "transparent",
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
                "auto" => GenerateImageGptImage25FlareRequestBackground.Auto,
                "opaque" => GenerateImageGptImage25FlareRequestBackground.Opaque,
                "transparent" => GenerateImageGptImage25FlareRequestBackground.Transparent,
                _ => null,
            };
        }
    }
}