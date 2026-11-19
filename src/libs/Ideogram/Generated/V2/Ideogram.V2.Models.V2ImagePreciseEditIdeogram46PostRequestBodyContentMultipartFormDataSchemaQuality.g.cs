
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The rendering quality to use. `very_low` is the fastest and cheapest and renders up to 2K. `low` is faster and cheaper than `medium`. `medium` renders each image once. `high` renders several candidates for each image and returns the best one, so it takes longer and is priced higher. The price also depends on the size of the image you send: an image over 2048x2048 pixels is billed at the 4K price, except at `very_low`. Setting `context_window` does not lower it.<br/>
    /// Default Value: medium
    /// </summary>
    public enum V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality
    {
        /// <summary>
        /// an image over 2048x2048 pixels is billed at the 4K price, except at `very_low`. Setting `context_window` does not lower it.
        /// </summary>
        High,
        /// <summary>
        /// an image over 2048x2048 pixels is billed at the 4K price, except at `very_low`. Setting `context_window` does not lower it.
        /// </summary>
        Low,
        /// <summary>
        /// an image over 2048x2048 pixels is billed at the 4K price, except at `very_low`. Setting `context_window` does not lower it.
        /// </summary>
        Medium,
        /// <summary>
        /// an image over 2048x2048 pixels is billed at the 4K price, except at `very_low`. Setting `context_window` does not lower it.
        /// </summary>
        VeryLow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality value)
        {
            return value switch
            {
                V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.High => "high",
                V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.Low => "low",
                V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.Medium => "medium",
                V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.VeryLow => "very_low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.High,
                "low" => V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.Low,
                "medium" => V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.Medium,
                "very_low" => V2ImagePreciseEditIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.VeryLow,
                _ => null,
            };
        }
    }
}