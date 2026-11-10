
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Discriminator value: container
    /// </summary>
    public enum LayerizeDocumentLayersInnerVariant3Type
    {
        /// <summary>
        /// container
        /// </summary>
        Container,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeDocumentLayersInnerVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeDocumentLayersInnerVariant3Type value)
        {
            return value switch
            {
                LayerizeDocumentLayersInnerVariant3Type.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeDocumentLayersInnerVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "container" => LayerizeDocumentLayersInnerVariant3Type.Container,
                _ => null,
            };
        }
    }
}