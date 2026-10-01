
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier. Each tier is a total pixel budget equal<br/>
    /// to a square of the named size (for example, `8k` delivers at most<br/>
    /// 8192x8192 pixels in total). Wide and tall aspect ratios keep the<br/>
    /// same budget, so one side may exceed the named size. Tiers above<br/>
    /// 2k are produced by upscaling after generation. Defaults to 1k.<br/>
    /// Default Value: 1k
    /// </summary>
    public enum GenerateImageIdeogramV4TransparentRequestOutputResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x4k,
        /// <summary>
        ///
        /// </summary>
        x8k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateImageIdeogramV4TransparentRequestOutputResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV4TransparentRequestOutputResolution value)
        {
            return value switch
            {
                GenerateImageIdeogramV4TransparentRequestOutputResolution.x1k => "1k",
                GenerateImageIdeogramV4TransparentRequestOutputResolution.x2k => "2k",
                GenerateImageIdeogramV4TransparentRequestOutputResolution.x4k => "4k",
                GenerateImageIdeogramV4TransparentRequestOutputResolution.x8k => "8k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV4TransparentRequestOutputResolution? ToEnum(string value)
        {
            return value switch
            {
                "1k" => GenerateImageIdeogramV4TransparentRequestOutputResolution.x1k,
                "2k" => GenerateImageIdeogramV4TransparentRequestOutputResolution.x2k,
                "4k" => GenerateImageIdeogramV4TransparentRequestOutputResolution.x4k,
                "8k" => GenerateImageIdeogramV4TransparentRequestOutputResolution.x8k,
                _ => null,
            };
        }
    }
}