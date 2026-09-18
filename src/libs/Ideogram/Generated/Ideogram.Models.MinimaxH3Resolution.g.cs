
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The resolution tier of the generated video, spelled the way MiniMax<br/>
    /// spells it. `480P` and `768P` are generated natively; `2K` and `4K` are<br/>
    /// upscaled from a `768P` result.<br/>
    /// Higher tiers cost more.<br/>
    /// Default Value: 2K
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
                MinimaxH3Resolution.x2k => "2K",
                MinimaxH3Resolution.x480p => "480P",
                MinimaxH3Resolution.x4k => "4K",
                MinimaxH3Resolution.x768p => "768P",
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
                "2K" => MinimaxH3Resolution.x2k,
                "480P" => MinimaxH3Resolution.x480p,
                "4K" => MinimaxH3Resolution.x4k,
                "768P" => MinimaxH3Resolution.x768p,
                _ => null,
            };
        }
    }
}