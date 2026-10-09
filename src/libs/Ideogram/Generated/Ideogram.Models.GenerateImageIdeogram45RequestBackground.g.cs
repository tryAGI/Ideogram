
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output background. `transparent` returns images with an alpha channel, `opaque` returns a solid one, and `auto` decides for you.<br/>
    /// Default Value: auto
    /// </summary>
    public enum GenerateImageIdeogram45RequestBackground
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
    public static class GenerateImageIdeogram45RequestBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogram45RequestBackground value)
        {
            return value switch
            {
                GenerateImageIdeogram45RequestBackground.Auto => "auto",
                GenerateImageIdeogram45RequestBackground.Opaque => "opaque",
                GenerateImageIdeogram45RequestBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogram45RequestBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GenerateImageIdeogram45RequestBackground.Auto,
                "opaque" => GenerateImageIdeogram45RequestBackground.Opaque,
                "transparent" => GenerateImageIdeogram45RequestBackground.Transparent,
                _ => null,
            };
        }
    }
}