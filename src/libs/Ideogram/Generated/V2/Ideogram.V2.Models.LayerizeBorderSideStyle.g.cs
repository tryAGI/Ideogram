
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeBorderSideStyle
    {
        /// <summary>
        ///
        /// </summary>
        Dashed,
        /// <summary>
        ///
        /// </summary>
        Dotted,
        /// <summary>
        ///
        /// </summary>
        Solid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeBorderSideStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeBorderSideStyle value)
        {
            return value switch
            {
                LayerizeBorderSideStyle.Dashed => "dashed",
                LayerizeBorderSideStyle.Dotted => "dotted",
                LayerizeBorderSideStyle.Solid => "solid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeBorderSideStyle? ToEnum(string value)
        {
            return value switch
            {
                "dashed" => LayerizeBorderSideStyle.Dashed,
                "dotted" => LayerizeBorderSideStyle.Dotted,
                "solid" => LayerizeBorderSideStyle.Solid,
                _ => null,
            };
        }
    }
}