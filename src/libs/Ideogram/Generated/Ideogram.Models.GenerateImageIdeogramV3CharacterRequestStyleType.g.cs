
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The style type to generate the character with. Defaults to `AUTO`.<br/>
    /// Default Value: AUTO
    /// </summary>
    public enum GenerateImageIdeogramV3CharacterRequestStyleType
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
    public static class GenerateImageIdeogramV3CharacterRequestStyleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV3CharacterRequestStyleType value)
        {
            return value switch
            {
                GenerateImageIdeogramV3CharacterRequestStyleType.Auto => "AUTO",
                GenerateImageIdeogramV3CharacterRequestStyleType.Fiction => "FICTION",
                GenerateImageIdeogramV3CharacterRequestStyleType.Realistic => "REALISTIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV3CharacterRequestStyleType? ToEnum(string value)
        {
            return value switch
            {
                "AUTO" => GenerateImageIdeogramV3CharacterRequestStyleType.Auto,
                "FICTION" => GenerateImageIdeogramV3CharacterRequestStyleType.Fiction,
                "REALISTIC" => GenerateImageIdeogramV3CharacterRequestStyleType.Realistic,
                _ => null,
            };
        }
    }
}