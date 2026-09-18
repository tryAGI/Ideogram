
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output-size tier; the server defaults to `1k` when omitted. Cannot be combined with `custom_width`/`custom_height`.
    /// </summary>
    public enum GenerateImagePImageIdeogramRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateImagePImageIdeogramRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImagePImageIdeogramRequestResolution value)
        {
            return value switch
            {
                GenerateImagePImageIdeogramRequestResolution.x1k => "1k",
                GenerateImagePImageIdeogramRequestResolution.x2k => "2k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImagePImageIdeogramRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1k" => GenerateImagePImageIdeogramRequestResolution.x1k,
                "2k" => GenerateImagePImageIdeogramRequestResolution.x2k,
                _ => null,
            };
        }
    }
}