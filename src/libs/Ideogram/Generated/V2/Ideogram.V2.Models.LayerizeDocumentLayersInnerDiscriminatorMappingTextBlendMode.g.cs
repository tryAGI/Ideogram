
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode
    {
        /// <summary>
        ///
        /// </summary>
        Darken,
        /// <summary>
        ///
        /// </summary>
        Lighten,
        /// <summary>
        ///
        /// </summary>
        Multiply,
        /// <summary>
        ///
        /// </summary>
        Normal,
        /// <summary>
        ///
        /// </summary>
        Overlay,
        /// <summary>
        ///
        /// </summary>
        Screen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode value)
        {
            return value switch
            {
                LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Darken => "darken",
                LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Lighten => "lighten",
                LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Multiply => "multiply",
                LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Normal => "normal",
                LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Overlay => "overlay",
                LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Screen => "screen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode? ToEnum(string value)
        {
            return value switch
            {
                "darken" => LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Darken,
                "lighten" => LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Lighten,
                "multiply" => LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Multiply,
                "normal" => LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Normal,
                "overlay" => LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Overlay,
                "screen" => LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode.Screen,
                _ => null,
            };
        }
    }
}