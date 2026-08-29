
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier. Influences which model serves the request; not every model offers every tier. When omitted the server uses the selected model's default tier.
    /// </summary>
    public enum ToolImageToImageRequestResolutionTier
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
    public static class ToolImageToImageRequestResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolImageToImageRequestResolutionTier value)
        {
            return value switch
            {
                ToolImageToImageRequestResolutionTier.x1k => "1K",
                ToolImageToImageRequestResolutionTier.x2k => "2K",
                ToolImageToImageRequestResolutionTier.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolImageToImageRequestResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1K" => ToolImageToImageRequestResolutionTier.x1k,
                "2K" => ToolImageToImageRequestResolutionTier.x2k,
                "4K" => ToolImageToImageRequestResolutionTier.x4k,
                _ => null,
            };
        }
    }
}