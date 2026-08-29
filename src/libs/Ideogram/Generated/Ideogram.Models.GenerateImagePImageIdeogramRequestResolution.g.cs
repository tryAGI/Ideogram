
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output-size tier; the server defaults to `1K` when omitted. Cannot be combined with `custom_width`/`custom_height`.
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
                GenerateImagePImageIdeogramRequestResolution.x1k => "1K",
                GenerateImagePImageIdeogramRequestResolution.x2k => "2K",
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
                "1K" => GenerateImagePImageIdeogramRequestResolution.x1k,
                "2K" => GenerateImagePImageIdeogramRequestResolution.x2k,
                _ => null,
            };
        }
    }
}