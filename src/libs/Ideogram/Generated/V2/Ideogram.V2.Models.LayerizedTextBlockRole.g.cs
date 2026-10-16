
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Inferred typographic role of this text block.
    /// </summary>
    public enum LayerizedTextBlockRole
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
    public static class LayerizedTextBlockRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizedTextBlockRole value)
        {
            return value switch
            {
                LayerizedTextBlockRole.Body => "body",
                LayerizedTextBlockRole.Caption => "caption",
                LayerizedTextBlockRole.Heading => "heading",
                LayerizedTextBlockRole.Subheading => "subheading",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizedTextBlockRole? ToEnum(string value)
        {
            return value switch
            {
                "body" => LayerizedTextBlockRole.Body,
                "caption" => LayerizedTextBlockRole.Caption,
                "heading" => LayerizedTextBlockRole.Heading,
                "subheading" => LayerizedTextBlockRole.Subheading,
                _ => null,
            };
        }
    }
}