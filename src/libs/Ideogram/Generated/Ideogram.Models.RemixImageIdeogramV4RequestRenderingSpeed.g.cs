
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
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
                RemixImageIdeogramV4RequestRenderingSpeed.Default => "default",
                RemixImageIdeogramV4RequestRenderingSpeed.Quality => "quality",
                RemixImageIdeogramV4RequestRenderingSpeed.Turbo => "turbo",
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
                "default" => RemixImageIdeogramV4RequestRenderingSpeed.Default,
                "quality" => RemixImageIdeogramV4RequestRenderingSpeed.Quality,
                "turbo" => RemixImageIdeogramV4RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}