
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Where enhancements apply. Omit to let the model choose per image.
    /// </summary>
    public enum V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Background,
        /// <summary>
        ///
        /// </summary>
        Foreground,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection value)
        {
            return value switch
            {
                V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection.All => "all",
                V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Background => "background",
                V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Foreground => "foreground",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection? ToEnum(string value)
        {
            return value switch
            {
                "all" => V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection.All,
                "background" => V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Background,
                "foreground" => V2ImageUpscaleTopazStandard2PostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Foreground,
                _ => null,
            };
        }
    }
}