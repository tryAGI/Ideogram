
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
    /// Default Value: x2
    /// </summary>
    public enum V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor
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
    public static class V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor value)
        {
            return value switch
            {
                V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X2 => "x2",
                V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X4 => "x4",
                V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X8 => "x8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? ToEnum(string value)
        {
            return value switch
            {
                "x2" => V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X2,
                "x4" => V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X4,
                "x8" => V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X8,
                _ => null,
            };
        }
    }
}