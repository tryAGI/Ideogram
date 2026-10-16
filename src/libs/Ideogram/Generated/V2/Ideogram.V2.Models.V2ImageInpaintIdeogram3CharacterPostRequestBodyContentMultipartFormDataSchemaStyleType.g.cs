
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The style type to repaint the character with. Defaults to `auto`. `realistic` and `fiction` are supported for character-only requests; style codes or style references (not both) require `auto`. For API-key callers, combining a style with a character requires that feature to be enabled for their account.<br/>
    /// Default Value: auto
    /// </summary>
    public enum V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Fiction,
        /// <summary>
        ///
        /// </summary>
        Realistic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType value)
        {
            return value switch
            {
                V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Auto => "auto",
                V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Fiction => "fiction",
                V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Realistic => "realistic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Auto,
                "fiction" => V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Fiction,
                "realistic" => V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Realistic,
                _ => null,
            };
        }
    }
}