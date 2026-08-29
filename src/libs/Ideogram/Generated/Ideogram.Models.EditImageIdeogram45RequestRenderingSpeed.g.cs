
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: DEFAULT
    /// </summary>
    public enum EditImageIdeogram45RequestRenderingSpeed
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
    public static class EditImageIdeogram45RequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageIdeogram45RequestRenderingSpeed value)
        {
            return value switch
            {
                EditImageIdeogram45RequestRenderingSpeed.Default => "DEFAULT",
                EditImageIdeogram45RequestRenderingSpeed.Quality => "QUALITY",
                EditImageIdeogram45RequestRenderingSpeed.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageIdeogram45RequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => EditImageIdeogram45RequestRenderingSpeed.Default,
                "QUALITY" => EditImageIdeogram45RequestRenderingSpeed.Quality,
                "TURBO" => EditImageIdeogram45RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}