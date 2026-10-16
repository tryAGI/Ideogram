
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
    /// Default Value: x2
    /// </summary>
    public enum V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor
    {
        /// <summary>
        ///
        /// </summary>
        X2,
        /// <summary>
        ///
        /// </summary>
        X4,
        /// <summary>
        ///
        /// </summary>
        X8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor value)
        {
            return value switch
            {
                V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X2 => "x2",
                V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X4 => "x4",
                V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X8 => "x8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? ToEnum(string value)
        {
            return value switch
            {
                "x2" => V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X2,
                "x4" => V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X4,
                "x8" => V2ImageUpscaleAutoPostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X8,
                _ => null,
            };
        }
    }
}