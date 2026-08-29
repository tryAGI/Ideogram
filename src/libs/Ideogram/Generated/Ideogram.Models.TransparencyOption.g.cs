
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Controls whether the edited output has a transparent background.<br/>
    /// - `TRANSPARENT`: the output is produced with a transparent background.<br/>
    /// - `OPAQUE`: the output is produced with an opaque background.<br/>
    /// - `AUTO`: the server decides based on the prompt and the image being<br/>
    ///   edited (e.g. whether it already has a transparent background). This is<br/>
    ///   the default. When the prompt asks only for background removal, the<br/>
    ///   output may be the edited image with its background removed.<br/>
    /// Default Value: AUTO
    /// </summary>
    public enum TransparencyOption
    {
        /// <summary>
        /// the server decides based on the prompt and the image being
        /// </summary>
        Auto,
        /// <summary>
        /// the output is produced with an opaque background.
        /// </summary>
        Opaque,
        /// <summary>
        /// the output is produced with a transparent background.
        /// </summary>
        Transparent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransparencyOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransparencyOption value)
        {
            return value switch
            {
                TransparencyOption.Auto => "AUTO",
                TransparencyOption.Opaque => "OPAQUE",
                TransparencyOption.Transparent => "TRANSPARENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransparencyOption? ToEnum(string value)
        {
            return value switch
            {
                "AUTO" => TransparencyOption.Auto,
                "OPAQUE" => TransparencyOption.Opaque,
                "TRANSPARENT" => TransparencyOption.Transparent,
                _ => null,
            };
        }
    }
}