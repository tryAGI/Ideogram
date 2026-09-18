
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
    /// </summary>
    public enum RemixImageIdeogramV3RequestRenderingSpeed
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
    public static class RemixImageIdeogramV3RequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemixImageIdeogramV3RequestRenderingSpeed value)
        {
            return value switch
            {
                RemixImageIdeogramV3RequestRenderingSpeed.Default => "default",
                RemixImageIdeogramV3RequestRenderingSpeed.Quality => "quality",
                RemixImageIdeogramV3RequestRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemixImageIdeogramV3RequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => RemixImageIdeogramV3RequestRenderingSpeed.Default,
                "quality" => RemixImageIdeogramV3RequestRenderingSpeed.Quality,
                "turbo" => RemixImageIdeogramV3RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}