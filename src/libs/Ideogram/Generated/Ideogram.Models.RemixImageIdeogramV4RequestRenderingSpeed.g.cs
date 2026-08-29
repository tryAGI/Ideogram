
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: DEFAULT
    /// </summary>
    public enum RemixImageIdeogramV4RequestRenderingSpeed
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Quality,
        /// <summary>
        ///
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemixImageIdeogramV4RequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemixImageIdeogramV4RequestRenderingSpeed value)
        {
            return value switch
            {
                RemixImageIdeogramV4RequestRenderingSpeed.Default => "DEFAULT",
                RemixImageIdeogramV4RequestRenderingSpeed.Quality => "QUALITY",
                RemixImageIdeogramV4RequestRenderingSpeed.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemixImageIdeogramV4RequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => RemixImageIdeogramV4RequestRenderingSpeed.Default,
                "QUALITY" => RemixImageIdeogramV4RequestRenderingSpeed.Quality,
                "TURBO" => RemixImageIdeogramV4RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}