
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Inferred typographic role of this text block.
    /// </summary>
    public enum DetectedTextBlockRole
    {
        /// <summary>
        /// 
        /// </summary>
        Body,
        /// <summary>
        /// 
        /// </summary>
        Caption,
        /// <summary>
        /// 
        /// </summary>
        Heading,
        /// <summary>
        /// 
        /// </summary>
        Subheading,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectedTextBlockRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectedTextBlockRole value)
        {
            return value switch
            {
                DetectedTextBlockRole.Body => "body",
                DetectedTextBlockRole.Caption => "caption",
                DetectedTextBlockRole.Heading => "heading",
                DetectedTextBlockRole.Subheading => "subheading",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectedTextBlockRole? ToEnum(string value)
        {
            return value switch
            {
                "body" => DetectedTextBlockRole.Body,
                "caption" => DetectedTextBlockRole.Caption,
                "heading" => DetectedTextBlockRole.Heading,
                "subheading" => DetectedTextBlockRole.Subheading,
                _ => null,
            };
        }
    }
}