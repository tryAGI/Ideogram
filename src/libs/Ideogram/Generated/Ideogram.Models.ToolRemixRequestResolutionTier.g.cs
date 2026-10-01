
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier. When omitted, the tier is inferred from `resolution`, or defaults to 1k. A color palette, style codes, style preset, or non-`auto` style type are only supported at 1k.
    /// </summary>
    public enum ToolRemixRequestResolutionTier
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRemixRequestResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRemixRequestResolutionTier value)
        {
            return value switch
            {
                ToolRemixRequestResolutionTier.x1k => "1k",
                ToolRemixRequestResolutionTier.x2k => "2k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRemixRequestResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1k" => ToolRemixRequestResolutionTier.x1k,
                "2k" => ToolRemixRequestResolutionTier.x2k,
                _ => null,
            };
        }
    }
}