
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum ModelPoseVariantsQuality
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelPoseVariantsQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPoseVariantsQuality value)
        {
            return value switch
            {
                ModelPoseVariantsQuality.High => "high",
                ModelPoseVariantsQuality.Low => "low",
                ModelPoseVariantsQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPoseVariantsQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelPoseVariantsQuality.High,
                "low" => ModelPoseVariantsQuality.Low,
                "medium" => ModelPoseVariantsQuality.Medium,
                _ => null,
            };
        }
    }
}