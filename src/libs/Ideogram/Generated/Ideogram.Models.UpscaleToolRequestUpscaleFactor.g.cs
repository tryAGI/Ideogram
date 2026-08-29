
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
    /// Default Value: X2
    /// </summary>
    public enum UpscaleToolRequestUpscaleFactor
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
    public static class UpscaleToolRequestUpscaleFactorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleToolRequestUpscaleFactor value)
        {
            return value switch
            {
                UpscaleToolRequestUpscaleFactor.X2 => "X2",
                UpscaleToolRequestUpscaleFactor.X4 => "X4",
                UpscaleToolRequestUpscaleFactor.X8 => "X8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleToolRequestUpscaleFactor? ToEnum(string value)
        {
            return value switch
            {
                "X2" => UpscaleToolRequestUpscaleFactor.X2,
                "X4" => UpscaleToolRequestUpscaleFactor.X4,
                "X8" => UpscaleToolRequestUpscaleFactor.X8,
                _ => null,
            };
        }
    }
}