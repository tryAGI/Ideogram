
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Tool type for filtering usage information<br/>
    /// Example: GENERATE
    /// </summary>
    public enum ToolType
    {
        /// <summary>
        /// 
        /// </summary>
        GENERATE,
        /// <summary>
        /// 
        /// </summary>
        REMIX,
        /// <summary>
        /// 
        /// </summary>
        EDIT,
        /// <summary>
        /// 
        /// </summary>
        UPSCALE,
        /// <summary>
        /// 
        /// </summary>
        DESCRIBE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolType value)
        {
            return value switch
            {
                ToolType.GENERATE => "GENERATE",
                ToolType.REMIX => "REMIX",
                ToolType.EDIT => "EDIT",
                ToolType.UPSCALE => "UPSCALE",
                ToolType.DESCRIBE => "DESCRIBE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolType? ToEnum(string value)
        {
            return value switch
            {
                "GENERATE" => ToolType.GENERATE,
                "REMIX" => ToolType.REMIX,
                "EDIT" => ToolType.EDIT,
                "UPSCALE" => ToolType.UPSCALE,
                "DESCRIBE" => ToolType.DESCRIBE,
                _ => null,
            };
        }
    }
}