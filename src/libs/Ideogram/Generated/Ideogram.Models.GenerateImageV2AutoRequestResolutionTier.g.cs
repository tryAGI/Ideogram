
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier. Influences which model serves the request; not every model offers every tier. When omitted the server uses the selected model's default tier.
    /// </summary>
    public enum GenerateImageV2AutoRequestResolutionTier
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
    public static class GenerateImageV2AutoRequestResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageV2AutoRequestResolutionTier value)
        {
            return value switch
            {
                GenerateImageV2AutoRequestResolutionTier.x1k => "1k",
                GenerateImageV2AutoRequestResolutionTier.x2k => "2k",
                GenerateImageV2AutoRequestResolutionTier.x4k => "4k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageV2AutoRequestResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1k" => GenerateImageV2AutoRequestResolutionTier.x1k,
                "2k" => GenerateImageV2AutoRequestResolutionTier.x2k,
                "4k" => GenerateImageV2AutoRequestResolutionTier.x4k,
                _ => null,
            };
        }
    }
}