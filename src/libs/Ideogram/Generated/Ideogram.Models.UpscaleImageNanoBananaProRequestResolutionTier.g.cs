
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier. The model sizes its output by tier at the source image's aspect ratio; exact pixel dimensions cannot be requested. Rejected when the source is already at or above the requested tier. Defaults to "2K".<br/>
    /// Default Value: 2K
    /// </summary>
    public enum UpscaleImageNanoBananaProRequestResolutionTier
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
    public static class UpscaleImageNanoBananaProRequestResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleImageNanoBananaProRequestResolutionTier value)
        {
            return value switch
            {
                UpscaleImageNanoBananaProRequestResolutionTier.x1k => "1K",
                UpscaleImageNanoBananaProRequestResolutionTier.x2k => "2K",
                UpscaleImageNanoBananaProRequestResolutionTier.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleImageNanoBananaProRequestResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1K" => UpscaleImageNanoBananaProRequestResolutionTier.x1k,
                "2K" => UpscaleImageNanoBananaProRequestResolutionTier.x2k,
                "4K" => UpscaleImageNanoBananaProRequestResolutionTier.x4k,
                _ => null,
            };
        }
    }
}