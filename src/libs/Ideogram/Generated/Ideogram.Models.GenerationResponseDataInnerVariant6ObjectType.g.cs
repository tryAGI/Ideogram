
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator value: layerized_design.generation
    /// </summary>
    public enum GenerationResponseDataInnerVariant6ObjectType
    {
        /// <summary>
        /// layerized_design.generation
        /// </summary>
        LayerizedDesignGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataInnerVariant6ObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataInnerVariant6ObjectType value)
        {
            return value switch
            {
                GenerationResponseDataInnerVariant6ObjectType.LayerizedDesignGeneration => "layerized_design.generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataInnerVariant6ObjectType? ToEnum(string value)
        {
            return value switch
            {
                "layerized_design.generation" => GenerationResponseDataInnerVariant6ObjectType.LayerizedDesignGeneration,
                _ => null,
            };
        }
    }
}