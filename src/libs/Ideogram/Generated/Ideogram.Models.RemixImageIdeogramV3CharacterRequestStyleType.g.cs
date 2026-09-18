
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The style type to remix the character with. Defaults to `auto`.<br/>
    /// Default Value: auto
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
                RemixImageIdeogramV3CharacterRequestStyleType.Auto => "auto",
                RemixImageIdeogramV3CharacterRequestStyleType.Fiction => "fiction",
                RemixImageIdeogramV3CharacterRequestStyleType.Realistic => "realistic",
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
                "auto" => RemixImageIdeogramV3CharacterRequestStyleType.Auto,
                "fiction" => RemixImageIdeogramV3CharacterRequestStyleType.Fiction,
                "realistic" => RemixImageIdeogramV3CharacterRequestStyleType.Realistic,
                _ => null,
            };
        }
    }
}