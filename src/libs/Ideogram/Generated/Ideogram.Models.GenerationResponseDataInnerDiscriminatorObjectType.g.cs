
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum GenerationResponseDataInnerDiscriminatorObjectType
    {
        /// <summary>
        ///
        /// </summary>
        ImageGeneration,
        /// <summary>
        ///
        /// </summary>
        ImageWithoutPromptOrSeed,
        /// <summary>
        ///
        /// </summary>
        LayerizedDesignGeneration,
        /// <summary>
        ///
        /// </summary>
        LayerizedImage,
        /// <summary>
        ///
        /// </summary>
        SvgGeneration,
        /// <summary>
        ///
        /// </summary>
        VideoGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataInnerDiscriminatorObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataInnerDiscriminatorObjectType value)
        {
            return value switch
            {
                GenerationResponseDataInnerDiscriminatorObjectType.ImageGeneration => "image.generation",
                GenerationResponseDataInnerDiscriminatorObjectType.ImageWithoutPromptOrSeed => "image.without-prompt-or-seed",
                GenerationResponseDataInnerDiscriminatorObjectType.LayerizedDesignGeneration => "layerized_design.generation",
                GenerationResponseDataInnerDiscriminatorObjectType.LayerizedImage => "layerized_image",
                GenerationResponseDataInnerDiscriminatorObjectType.SvgGeneration => "svg.generation",
                GenerationResponseDataInnerDiscriminatorObjectType.VideoGeneration => "video.generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataInnerDiscriminatorObjectType? ToEnum(string value)
        {
            return value switch
            {
                "image.generation" => GenerationResponseDataInnerDiscriminatorObjectType.ImageGeneration,
                "image.without-prompt-or-seed" => GenerationResponseDataInnerDiscriminatorObjectType.ImageWithoutPromptOrSeed,
                "layerized_design.generation" => GenerationResponseDataInnerDiscriminatorObjectType.LayerizedDesignGeneration,
                "layerized_image" => GenerationResponseDataInnerDiscriminatorObjectType.LayerizedImage,
                "svg.generation" => GenerationResponseDataInnerDiscriminatorObjectType.SvgGeneration,
                "video.generation" => GenerationResponseDataInnerDiscriminatorObjectType.VideoGeneration,
                _ => null,
            };
        }
    }
}