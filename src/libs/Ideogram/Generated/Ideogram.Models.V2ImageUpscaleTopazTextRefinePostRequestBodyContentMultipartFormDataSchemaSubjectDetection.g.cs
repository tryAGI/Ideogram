
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Where enhancements apply. Omit to let the model choose per image.
    /// </summary>
    public enum V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection
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
    public static class V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection value)
        {
            return value switch
            {
                V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.All => "all",
                V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Background => "background",
                V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Foreground => "foreground",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection? ToEnum(string value)
        {
            return value switch
            {
                "all" => V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.All,
                "background" => V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Background,
                "foreground" => V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Foreground,
                _ => null,
            };
        }
    }
}