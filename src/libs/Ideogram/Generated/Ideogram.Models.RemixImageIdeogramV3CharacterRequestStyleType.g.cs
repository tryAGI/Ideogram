
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The style type to remix the character with. Defaults to `AUTO`.<br/>
    /// Default Value: AUTO
    /// </summary>
    public enum RemixImageIdeogramV3CharacterRequestStyleType
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Fiction,
        /// <summary>
        ///
        /// </summary>
        Realistic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemixImageIdeogramV3CharacterRequestStyleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemixImageIdeogramV3CharacterRequestStyleType value)
        {
            return value switch
            {
                RemixImageIdeogramV3CharacterRequestStyleType.Auto => "AUTO",
                RemixImageIdeogramV3CharacterRequestStyleType.Fiction => "FICTION",
                RemixImageIdeogramV3CharacterRequestStyleType.Realistic => "REALISTIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemixImageIdeogramV3CharacterRequestStyleType? ToEnum(string value)
        {
            return value switch
            {
                "AUTO" => RemixImageIdeogramV3CharacterRequestStyleType.Auto,
                "FICTION" => RemixImageIdeogramV3CharacterRequestStyleType.Fiction,
                "REALISTIC" => RemixImageIdeogramV3CharacterRequestStyleType.Realistic,
                _ => null,
            };
        }
    }
}