
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
        Generate,
        /// <summary>
        /// 
        /// </summary>
        Remix,
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        Upscale,
        /// <summary>
        /// 
        /// </summary>
        Describe,
        /// <summary>
        /// 
        /// </summary>
        Other,
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
                ToolType.Generate => "GENERATE",
                ToolType.Remix => "REMIX",
                ToolType.Edit => "EDIT",
                ToolType.Upscale => "UPSCALE",
                ToolType.Describe => "DESCRIBE",
                ToolType.Other => "OTHER",
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
                "GENERATE" => ToolType.Generate,
                "REMIX" => ToolType.Remix,
                "EDIT" => ToolType.Edit,
                "UPSCALE" => ToolType.Upscale,
                "DESCRIBE" => ToolType.Describe,
                "OTHER" => ToolType.Other,
                _ => null,
            };
        }
    }
}