
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// How much to enlarge the source image: 2x or 4x its original width and height. Rejected when the output would exceed 100 megapixels.<br/>
    /// Default Value: x2
    /// </summary>
    public enum V2ImageUpscaleTopazWonder4PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor
    {
        /// <summary>
        ///
        /// </summary>
        X2,
        /// <summary>
        ///
        /// </summary>
        X4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ImageUpscaleTopazWonder4PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageUpscaleTopazWonder4PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor value)
        {
            return value switch
            {
                V2ImageUpscaleTopazWonder4PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X2 => "x2",
                V2ImageUpscaleTopazWonder4PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X4 => "x4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageUpscaleTopazWonder4PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? ToEnum(string value)
        {
            return value switch
            {
                "x2" => V2ImageUpscaleTopazWonder4PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X2,
                "x4" => V2ImageUpscaleTopazWonder4PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X4,
                _ => null,
            };
        }
    }
}