
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How the prompt is staged. `customize` follows the prompt as written;<br/>
    /// `intelligent` lets the model break the prompt into its own shots.<br/>
    /// Default Value: customize
    /// </summary>
    public enum KlingV3ShotType
    {
        /// <summary>
        ///
        /// </summary>
        Customize,
        /// <summary>
        ///
        /// </summary>
        Intelligent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KlingV3ShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KlingV3ShotType value)
        {
            return value switch
            {
                KlingV3ShotType.Customize => "customize",
                KlingV3ShotType.Intelligent => "intelligent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KlingV3ShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => KlingV3ShotType.Customize,
                "intelligent" => KlingV3ShotType.Intelligent,
                _ => null,
            };
        }
    }
}