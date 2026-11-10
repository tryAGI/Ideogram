
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Discriminator value: text
    /// </summary>
    public enum LayerizeDocumentLayersInnerVariant2Type
    {
        /// <summary>
        /// text
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeDocumentLayersInnerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeDocumentLayersInnerVariant2Type value)
        {
            return value switch
            {
                LayerizeDocumentLayersInnerVariant2Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeDocumentLayersInnerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => LayerizeDocumentLayersInnerVariant2Type.Text,
                _ => null,
            };
        }
    }
}