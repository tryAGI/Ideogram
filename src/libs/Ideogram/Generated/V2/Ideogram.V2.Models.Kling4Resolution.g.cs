
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The resolution tier of the generated video.<br/>
    /// Default Value: 1080p
    /// </summary>
    public enum Kling4Resolution
    {
        /// <summary>
        ///
        /// </summary>
        x1080p,
        /// <summary>
        ///
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Kling4ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Kling4Resolution value)
        {
            return value switch
            {
                Kling4Resolution.x1080p => "1080p",
                Kling4Resolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Kling4Resolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Kling4Resolution.x1080p,
                "720p" => Kling4Resolution.x720p,
                _ => null,
            };
        }
    }
}