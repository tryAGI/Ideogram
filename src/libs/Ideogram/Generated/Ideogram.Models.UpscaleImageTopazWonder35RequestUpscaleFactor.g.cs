
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
    /// Default Value: X2
    /// </summary>
    public enum UpscaleImageTopazWonder35RequestUpscaleFactor
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
    public static class UpscaleImageTopazWonder35RequestUpscaleFactorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleImageTopazWonder35RequestUpscaleFactor value)
        {
            return value switch
            {
                UpscaleImageTopazWonder35RequestUpscaleFactor.X2 => "X2",
                UpscaleImageTopazWonder35RequestUpscaleFactor.X4 => "X4",
                UpscaleImageTopazWonder35RequestUpscaleFactor.X8 => "X8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleImageTopazWonder35RequestUpscaleFactor? ToEnum(string value)
        {
            return value switch
            {
                "X2" => UpscaleImageTopazWonder35RequestUpscaleFactor.X2,
                "X4" => UpscaleImageTopazWonder35RequestUpscaleFactor.X4,
                "X8" => UpscaleImageTopazWonder35RequestUpscaleFactor.X8,
                _ => null,
            };
        }
    }
}