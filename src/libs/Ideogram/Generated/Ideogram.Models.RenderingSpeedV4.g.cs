
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. Defaults to DEFAULT.<br/>
    /// Default Value: DEFAULT
    /// </summary>
    public enum RenderingSpeedV4
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
    public static class RenderingSpeedV4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenderingSpeedV4 value)
        {
            return value switch
            {
                RenderingSpeedV4.Default => "DEFAULT",
                RenderingSpeedV4.Quality => "QUALITY",
                RenderingSpeedV4.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenderingSpeedV4? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => RenderingSpeedV4.Default,
                "QUALITY" => RenderingSpeedV4.Quality,
                "TURBO" => RenderingSpeedV4.Turbo,
                _ => null,
            };
        }
    }
}