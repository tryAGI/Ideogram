
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
    /// Default Value: x2
    /// </summary>
    public enum V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor
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
    public static class V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor value)
        {
            return value switch
            {
                V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X2 => "x2",
                V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X4 => "x4",
                V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X8 => "x8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? ToEnum(string value)
        {
            return value switch
            {
                "x2" => V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X2,
                "x4" => V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X4,
                "x8" => V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor.X8,
                _ => null,
            };
        }
    }
}