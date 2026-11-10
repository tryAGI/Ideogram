
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeAssetIdentifierAssetType
    {
        /// <summary>
        ///
        /// </summary>
        Response,
        /// <summary>
        ///
        /// </summary>
        Upload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeAssetIdentifierAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeAssetIdentifierAssetType value)
        {
            return value switch
            {
                LayerizeAssetIdentifierAssetType.Response => "RESPONSE",
                LayerizeAssetIdentifierAssetType.Upload => "UPLOAD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeAssetIdentifierAssetType? ToEnum(string value)
        {
            return value switch
            {
                "RESPONSE" => LayerizeAssetIdentifierAssetType.Response,
                "UPLOAD" => LayerizeAssetIdentifierAssetType.Upload,
                _ => null,
            };
        }
    }
}