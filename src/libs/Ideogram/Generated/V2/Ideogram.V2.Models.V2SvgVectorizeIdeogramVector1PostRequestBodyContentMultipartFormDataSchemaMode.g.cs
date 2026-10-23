
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Simple uses fewer shapes; detailed preserves fine detail; auto chooses the level of detail that best suits the image.<br/>
    /// Default Value: auto
    /// </summary>
    public enum V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Detailed,
        /// <summary>
        ///
        /// </summary>
        Simple,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode value)
        {
            return value switch
            {
                V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode.Auto => "auto",
                V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode.Detailed => "detailed",
                V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode.Simple => "simple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode.Auto,
                "detailed" => V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode.Detailed,
                "simple" => V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode.Simple,
                _ => null,
            };
        }
    }
}