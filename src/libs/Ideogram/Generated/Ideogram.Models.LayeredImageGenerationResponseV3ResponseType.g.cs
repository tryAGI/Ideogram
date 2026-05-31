
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator for the postGenerateDesignV4 oneOf response. Always "layered" for this shape; absent on the legacy postGenerateDesignV3 endpoint.
    /// </summary>
    public enum LayeredImageGenerationResponseV3ResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Layered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayeredImageGenerationResponseV3ResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayeredImageGenerationResponseV3ResponseType value)
        {
            return value switch
            {
                LayeredImageGenerationResponseV3ResponseType.Layered => "layered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayeredImageGenerationResponseV3ResponseType? ToEnum(string value)
        {
            return value switch
            {
                "layered" => LayeredImageGenerationResponseV3ResponseType.Layered,
                _ => null,
            };
        }
    }
}