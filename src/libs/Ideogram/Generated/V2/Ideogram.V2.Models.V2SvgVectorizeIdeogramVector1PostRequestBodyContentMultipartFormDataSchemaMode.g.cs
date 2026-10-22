
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Simple draws fewer, simpler shapes; default preserves more fine detail.<br/>
    /// Default Value: default
    /// </summary>
    public enum V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode
    {
        /// <summary>
        ///
        /// </summary>
        Default,
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
                V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode.Default => "default",
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
                "default" => V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode.Default,
                "simple" => V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode.Simple,
                _ => null,
            };
        }
    }
}