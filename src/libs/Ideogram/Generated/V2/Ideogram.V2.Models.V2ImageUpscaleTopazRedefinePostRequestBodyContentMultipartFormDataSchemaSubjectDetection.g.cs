
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Where enhancements apply. Omit to let the model choose per image.
    /// </summary>
    public enum V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection
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
    public static class V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection value)
        {
            return value switch
            {
                V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.All => "all",
                V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Background => "background",
                V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Foreground => "foreground",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection? ToEnum(string value)
        {
            return value switch
            {
                "all" => V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.All,
                "background" => V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Background,
                "foreground" => V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection.Foreground,
                _ => null,
            };
        }
    }
}