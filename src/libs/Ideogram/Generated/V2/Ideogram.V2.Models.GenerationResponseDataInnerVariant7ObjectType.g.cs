
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Discriminator value: image_judgment.result
    /// </summary>
    public enum GenerationResponseDataInnerVariant7ObjectType
    {
        /// <summary>
        /// image_judgment.result
        /// </summary>
        ImageJudgmentResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataInnerVariant7ObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataInnerVariant7ObjectType value)
        {
            return value switch
            {
                GenerationResponseDataInnerVariant7ObjectType.ImageJudgmentResult => "image_judgment.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataInnerVariant7ObjectType? ToEnum(string value)
        {
            return value switch
            {
                "image_judgment.result" => GenerationResponseDataInnerVariant7ObjectType.ImageJudgmentResult,
                _ => null,
            };
        }
    }
}