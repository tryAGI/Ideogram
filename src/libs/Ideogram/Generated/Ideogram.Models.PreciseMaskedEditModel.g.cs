
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The model used to apply the masked edit.<br/>
    /// Default Value: GPT_IMAGE_2
    /// </summary>
    public enum PreciseMaskedEditModel
    {
        /// <summary>
        ///
        /// </summary>
        GptImage2,
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
                _ => null,
            };
        }
    }
}