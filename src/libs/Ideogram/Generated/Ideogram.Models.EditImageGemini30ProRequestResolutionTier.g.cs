
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier. The model sizes its output by tier and aspect ratio; exact pixel dimensions cannot be requested. Defaults to "1K".<br/>
    /// Default Value: 1K
    /// </summary>
    public enum EditImageGemini30ProRequestResolutionTier
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
    public static class EditImageGemini30ProRequestResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGemini30ProRequestResolutionTier value)
        {
            return value switch
            {
                EditImageGemini30ProRequestResolutionTier.x1k => "1K",
                EditImageGemini30ProRequestResolutionTier.x2k => "2K",
                EditImageGemini30ProRequestResolutionTier.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGemini30ProRequestResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1K" => EditImageGemini30ProRequestResolutionTier.x1k,
                "2K" => EditImageGemini30ProRequestResolutionTier.x2k,
                "4K" => EditImageGemini30ProRequestResolutionTier.x4k,
                _ => null,
            };
        }
    }
}