
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum GenerateImageNanoBananaProRequestResolutionTier
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
    public static class GenerateImageNanoBananaProRequestResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageNanoBananaProRequestResolutionTier value)
        {
            return value switch
            {
                GenerateImageNanoBananaProRequestResolutionTier.x1k => "1K",
                GenerateImageNanoBananaProRequestResolutionTier.x2k => "2K",
                GenerateImageNanoBananaProRequestResolutionTier.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageNanoBananaProRequestResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1K" => GenerateImageNanoBananaProRequestResolutionTier.x1k,
                "2K" => GenerateImageNanoBananaProRequestResolutionTier.x2k,
                "4K" => GenerateImageNanoBananaProRequestResolutionTier.x4k,
                _ => null,
            };
        }
    }
}