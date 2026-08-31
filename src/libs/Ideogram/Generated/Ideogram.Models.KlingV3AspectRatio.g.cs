
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The aspect ratio of the generated video.<br/>
    /// Default Value: 16x9
    /// </summary>
    public enum KlingV3AspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16x9,
        /// <summary>
        ///
        /// </summary>
        x1x1,
        /// <summary>
        ///
        /// </summary>
        x9x16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KlingV3AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KlingV3AspectRatio value)
        {
            return value switch
            {
                KlingV3AspectRatio.x16x9 => "16x9",
                KlingV3AspectRatio.x1x1 => "1x1",
                KlingV3AspectRatio.x9x16 => "9x16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KlingV3AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16x9" => KlingV3AspectRatio.x16x9,
                "1x1" => KlingV3AspectRatio.x1x1,
                "9x16" => KlingV3AspectRatio.x9x16,
                _ => null,
            };
        }
    }
}