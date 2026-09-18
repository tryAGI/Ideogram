
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum GenerateImageNanoBanana2RequestResolutionTier
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
    public static class GenerateImageNanoBanana2RequestResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageNanoBanana2RequestResolutionTier value)
        {
            return value switch
            {
                GenerateImageNanoBanana2RequestResolutionTier.x1k => "1K",
                GenerateImageNanoBanana2RequestResolutionTier.x2k => "2K",
                GenerateImageNanoBanana2RequestResolutionTier.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageNanoBanana2RequestResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1K" => GenerateImageNanoBanana2RequestResolutionTier.x1k,
                "2K" => GenerateImageNanoBanana2RequestResolutionTier.x2k,
                "4K" => GenerateImageNanoBanana2RequestResolutionTier.x4k,
                _ => null,
            };
        }
    }
}