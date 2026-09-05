
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum GenerateImageGemini30ProRequestResolutionTier
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
    public static class GenerateImageGemini30ProRequestResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageGemini30ProRequestResolutionTier value)
        {
            return value switch
            {
                GenerateImageGemini30ProRequestResolutionTier.x1k => "1K",
                GenerateImageGemini30ProRequestResolutionTier.x2k => "2K",
                GenerateImageGemini30ProRequestResolutionTier.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageGemini30ProRequestResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1K" => GenerateImageGemini30ProRequestResolutionTier.x1k,
                "2K" => GenerateImageGemini30ProRequestResolutionTier.x2k,
                "4K" => GenerateImageGemini30ProRequestResolutionTier.x4k,
                _ => null,
            };
        }
    }
}