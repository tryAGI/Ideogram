
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The resolution tier of the generated video. `480p` and `768p` are<br/>
    /// generated natively; `2k` and `4k` are upscaled from a `768p` result.<br/>
    /// Higher tiers cost more.<br/>
    /// Default Value: 2k
    /// </summary>
    public enum MinimaxH3Resolution
    {
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x480p,
        /// <summary>
        ///
        /// </summary>
        x4k,
        /// <summary>
        ///
        /// </summary>
        x768p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MinimaxH3ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinimaxH3Resolution value)
        {
            return value switch
            {
                MinimaxH3Resolution.x2k => "2k",
                MinimaxH3Resolution.x480p => "480p",
                MinimaxH3Resolution.x4k => "4k",
                MinimaxH3Resolution.x768p => "768p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinimaxH3Resolution? ToEnum(string value)
        {
            return value switch
            {
                "2k" => MinimaxH3Resolution.x2k,
                "480p" => MinimaxH3Resolution.x480p,
                "4k" => MinimaxH3Resolution.x4k,
                "768p" => MinimaxH3Resolution.x768p,
                _ => null,
            };
        }
    }
}