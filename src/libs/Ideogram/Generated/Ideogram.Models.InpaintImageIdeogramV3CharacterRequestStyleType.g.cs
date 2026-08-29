
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The style type to repaint the character with. Defaults to `AUTO`.<br/>
    /// Default Value: AUTO
    /// </summary>
    public enum InpaintImageIdeogramV3CharacterRequestStyleType
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
    public static class InpaintImageIdeogramV3CharacterRequestStyleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InpaintImageIdeogramV3CharacterRequestStyleType value)
        {
            return value switch
            {
                InpaintImageIdeogramV3CharacterRequestStyleType.Auto => "AUTO",
                InpaintImageIdeogramV3CharacterRequestStyleType.Fiction => "FICTION",
                InpaintImageIdeogramV3CharacterRequestStyleType.Realistic => "REALISTIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InpaintImageIdeogramV3CharacterRequestStyleType? ToEnum(string value)
        {
            return value switch
            {
                "AUTO" => InpaintImageIdeogramV3CharacterRequestStyleType.Auto,
                "FICTION" => InpaintImageIdeogramV3CharacterRequestStyleType.Fiction,
                "REALISTIC" => InpaintImageIdeogramV3CharacterRequestStyleType.Realistic,
                _ => null,
            };
        }
    }
}