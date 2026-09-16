
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The model used to apply the edit. For Ideogram 4.5, an optional mask is sent as one of the model's five image inputs and therefore reduces the reference-image limit by one.<br/>
    /// Default Value: GPT_IMAGE_2
    /// </summary>
    public enum PreciseMaskedEditModel
    {
        /// <summary>
        ///
        /// </summary>
        GptImage2,
        /// <summary>
        ///
        /// </summary>
        Ideogram45,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreciseMaskedEditModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreciseMaskedEditModel value)
        {
            return value switch
            {
                PreciseMaskedEditModel.GptImage2 => "GPT_IMAGE_2",
                PreciseMaskedEditModel.Ideogram45 => "IDEOGRAM_4_5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreciseMaskedEditModel? ToEnum(string value)
        {
            return value switch
            {
                "GPT_IMAGE_2" => PreciseMaskedEditModel.GptImage2,
                "IDEOGRAM_4_5" => PreciseMaskedEditModel.Ideogram45,
                _ => null,
            };
        }
    }
}