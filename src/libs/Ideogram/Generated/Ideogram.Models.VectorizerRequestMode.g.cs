
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Default draws fewer, simpler shapes; detailed preserves more fine detail.<br/>
    /// Default Value: default
    /// </summary>
    public enum VectorizerRequestMode
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Detailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorizerRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorizerRequestMode value)
        {
            return value switch
            {
                VectorizerRequestMode.Default => "default",
                VectorizerRequestMode.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorizerRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => VectorizerRequestMode.Default,
                "detailed" => VectorizerRequestMode.Detailed,
                _ => null,
            };
        }
    }
}