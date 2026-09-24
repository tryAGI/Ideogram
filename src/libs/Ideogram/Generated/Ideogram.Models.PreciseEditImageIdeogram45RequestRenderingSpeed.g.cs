
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. `ultra` renders multiple candidate edits internally and returns the one that best applies the instruction; it takes longer than `quality`, is priced higher, and supports at most 4 images per request.<br/>
    /// Default Value: default
    /// </summary>
    public enum PreciseEditImageIdeogram45RequestRenderingSpeed
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
        /// <summary>
        ///
        /// </summary>
        Ultra,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreciseEditImageIdeogram45RequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreciseEditImageIdeogram45RequestRenderingSpeed value)
        {
            return value switch
            {
                PreciseEditImageIdeogram45RequestRenderingSpeed.Default => "default",
                PreciseEditImageIdeogram45RequestRenderingSpeed.Quality => "quality",
                PreciseEditImageIdeogram45RequestRenderingSpeed.Turbo => "turbo",
                PreciseEditImageIdeogram45RequestRenderingSpeed.Ultra => "ultra",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreciseEditImageIdeogram45RequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => PreciseEditImageIdeogram45RequestRenderingSpeed.Default,
                "quality" => PreciseEditImageIdeogram45RequestRenderingSpeed.Quality,
                "turbo" => PreciseEditImageIdeogram45RequestRenderingSpeed.Turbo,
                "ultra" => PreciseEditImageIdeogram45RequestRenderingSpeed.Ultra,
                _ => null,
            };
        }
    }
}