
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The resolution tier of the generated video.<br/>
    /// Default Value: 720p
    /// </summary>
    public enum SeedDance2Resolution
    {
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
    public static class SeedDance2ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeedDance2Resolution value)
        {
            return value switch
            {
                SeedDance2Resolution.x480p => "480p",
                SeedDance2Resolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeedDance2Resolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => SeedDance2Resolution.x480p,
                "720p" => SeedDance2Resolution.x720p,
                _ => null,
            };
        }
    }
}