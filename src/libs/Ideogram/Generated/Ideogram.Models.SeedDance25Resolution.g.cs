
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The resolution tier of the generated video.<br/>
    /// Default Value: 720p
    /// </summary>
    public enum SeedDance25Resolution
    {
        /// <summary>
        ///
        /// </summary>
        x1080p,
        /// <summary>
        ///
        /// </summary>
        x480p,
        /// <summary>
        ///
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SeedDance25ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeedDance25Resolution value)
        {
            return value switch
            {
                SeedDance25Resolution.x1080p => "1080p",
                SeedDance25Resolution.x480p => "480p",
                SeedDance25Resolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeedDance25Resolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => SeedDance25Resolution.x1080p,
                "480p" => SeedDance25Resolution.x480p,
                "720p" => SeedDance25Resolution.x720p,
                _ => null,
            };
        }
    }
}