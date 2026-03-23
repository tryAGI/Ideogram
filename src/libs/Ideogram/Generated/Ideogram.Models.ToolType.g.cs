
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
        Describe,
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        Generate,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Remix,
        /// <summary>
        /// 
        /// </summary>
        Upscale,
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
                ToolType.Describe => "DESCRIBE",
                ToolType.Edit => "EDIT",
                ToolType.Generate => "GENERATE",
                ToolType.Other => "OTHER",
                ToolType.Remix => "REMIX",
                ToolType.Upscale => "UPSCALE",
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
                "DESCRIBE" => ToolType.Describe,
                "EDIT" => ToolType.Edit,
                "GENERATE" => ToolType.Generate,
                "OTHER" => ToolType.Other,
                "REMIX" => ToolType.Remix,
                "UPSCALE" => ToolType.Upscale,
                _ => null,
            };
        }
    }
}