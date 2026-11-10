
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeDocumentLayersInnerDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Container,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeDocumentLayersInnerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeDocumentLayersInnerDiscriminatorType value)
        {
            return value switch
            {
                LayerizeDocumentLayersInnerDiscriminatorType.Container => "container",
                LayerizeDocumentLayersInnerDiscriminatorType.Image => "image",
                LayerizeDocumentLayersInnerDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeDocumentLayersInnerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container" => LayerizeDocumentLayersInnerDiscriminatorType.Container,
                "image" => LayerizeDocumentLayersInnerDiscriminatorType.Image,
                "text" => LayerizeDocumentLayersInnerDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}