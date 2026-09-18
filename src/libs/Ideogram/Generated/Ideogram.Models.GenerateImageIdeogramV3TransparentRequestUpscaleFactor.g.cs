
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Optional enhancement factor applied after generation. `x1` (the default) delivers the base render.<br/>
    /// Default Value: x1
    /// </summary>
    public enum GenerateImageIdeogramV3TransparentRequestUpscaleFactor
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
    public static class GenerateImageIdeogramV3TransparentRequestUpscaleFactorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV3TransparentRequestUpscaleFactor value)
        {
            return value switch
            {
                GenerateImageIdeogramV3TransparentRequestUpscaleFactor.X1 => "x1",
                GenerateImageIdeogramV3TransparentRequestUpscaleFactor.X2 => "x2",
                GenerateImageIdeogramV3TransparentRequestUpscaleFactor.X4 => "x4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV3TransparentRequestUpscaleFactor? ToEnum(string value)
        {
            return value switch
            {
                "x1" => GenerateImageIdeogramV3TransparentRequestUpscaleFactor.X1,
                "x2" => GenerateImageIdeogramV3TransparentRequestUpscaleFactor.X2,
                "x4" => GenerateImageIdeogramV3TransparentRequestUpscaleFactor.X4,
                _ => null,
            };
        }
    }
}