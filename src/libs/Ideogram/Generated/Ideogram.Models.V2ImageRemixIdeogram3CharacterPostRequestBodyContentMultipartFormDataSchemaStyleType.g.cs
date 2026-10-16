
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The style type to remix the character with. Defaults to `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType
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
    public static class V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType value)
        {
            return value switch
            {
                V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Auto => "auto",
                V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Fiction => "fiction",
                V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Realistic => "realistic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Auto,
                "fiction" => V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Fiction,
                "realistic" => V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType.Realistic,
                _ => null,
            };
        }
    }
}