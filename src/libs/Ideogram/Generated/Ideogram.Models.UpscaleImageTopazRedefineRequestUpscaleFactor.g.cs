
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
    /// Default Value: x2
    /// </summary>
    public enum UpscaleImageTopazRedefineRequestUpscaleFactor
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
    public static class UpscaleImageTopazRedefineRequestUpscaleFactorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleImageTopazRedefineRequestUpscaleFactor value)
        {
            return value switch
            {
                UpscaleImageTopazRedefineRequestUpscaleFactor.X2 => "x2",
                UpscaleImageTopazRedefineRequestUpscaleFactor.X4 => "x4",
                UpscaleImageTopazRedefineRequestUpscaleFactor.X8 => "x8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleImageTopazRedefineRequestUpscaleFactor? ToEnum(string value)
        {
            return value switch
            {
                "x2" => UpscaleImageTopazRedefineRequestUpscaleFactor.X2,
                "x4" => UpscaleImageTopazRedefineRequestUpscaleFactor.X4,
                "x8" => UpscaleImageTopazRedefineRequestUpscaleFactor.X8,
                _ => null,
            };
        }
    }
}