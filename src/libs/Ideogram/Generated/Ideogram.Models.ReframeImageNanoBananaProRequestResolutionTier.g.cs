
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier. The model sizes its output by tier at the requested aspect ratio; exact pixel dimensions cannot be requested.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum ReframeImageNanoBananaProRequestResolutionTier
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReframeImageNanoBananaProRequestResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReframeImageNanoBananaProRequestResolutionTier value)
        {
            return value switch
            {
                ReframeImageNanoBananaProRequestResolutionTier.x1k => "1K",
                ReframeImageNanoBananaProRequestResolutionTier.x2k => "2K",
                ReframeImageNanoBananaProRequestResolutionTier.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReframeImageNanoBananaProRequestResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1K" => ReframeImageNanoBananaProRequestResolutionTier.x1k,
                "2K" => ReframeImageNanoBananaProRequestResolutionTier.x2k,
                "4K" => ReframeImageNanoBananaProRequestResolutionTier.x4k,
                _ => null,
            };
        }
    }
}