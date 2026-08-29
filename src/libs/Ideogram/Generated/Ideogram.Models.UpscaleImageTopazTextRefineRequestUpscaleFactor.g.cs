
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
    /// Default Value: X2
    /// </summary>
    public enum UpscaleImageTopazTextRefineRequestUpscaleFactor
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
    public static class UpscaleImageTopazTextRefineRequestUpscaleFactorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleImageTopazTextRefineRequestUpscaleFactor value)
        {
            return value switch
            {
                UpscaleImageTopazTextRefineRequestUpscaleFactor.X2 => "X2",
                UpscaleImageTopazTextRefineRequestUpscaleFactor.X4 => "X4",
                UpscaleImageTopazTextRefineRequestUpscaleFactor.X8 => "X8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleImageTopazTextRefineRequestUpscaleFactor? ToEnum(string value)
        {
            return value switch
            {
                "X2" => UpscaleImageTopazTextRefineRequestUpscaleFactor.X2,
                "X4" => UpscaleImageTopazTextRefineRequestUpscaleFactor.X4,
                "X8" => UpscaleImageTopazTextRefineRequestUpscaleFactor.X8,
                _ => null,
            };
        }
    }
}