
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeDocumentSchemaVersion
    {
        /// <summary>
        ///
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeDocumentSchemaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeDocumentSchemaVersion value)
        {
            return value switch
            {
                LayerizeDocumentSchemaVersion.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeDocumentSchemaVersion? ToEnum(string value)
        {
            return value switch
            {
                "1" => LayerizeDocumentSchemaVersion.x1,
                _ => null,
            };
        }
    }
}