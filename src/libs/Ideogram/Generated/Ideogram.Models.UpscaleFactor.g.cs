
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Upscale the initially generated image by the given factor. Upscale factors other than X1 will incur additional cost.<br/>
    /// Default Value: X1<br/>
    /// Example: X2
    /// </summary>
    public enum UpscaleFactor
    {
        /// <summary>
        /// 
        /// </summary>
        X1,
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
    public static class UpscaleFactorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleFactor value)
        {
            return value switch
            {
                UpscaleFactor.X1 => "X1",
                UpscaleFactor.X2 => "X2",
                UpscaleFactor.X4 => "X4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleFactor? ToEnum(string value)
        {
            return value switch
            {
                "X1" => UpscaleFactor.X1,
                "X2" => UpscaleFactor.X2,
                "X4" => UpscaleFactor.X4,
                _ => null,
            };
        }
    }
}