
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssetType
    {
        /// <summary>
        /// 
        /// </summary>
        Asset,
        /// <summary>
        /// 
        /// </summary>
        CanvasAsset,
        /// <summary>
        /// 
        /// </summary>
        LayeredAsset,
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
    public static class AssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetType value)
        {
            return value switch
            {
                AssetType.Asset => "ASSET",
                AssetType.CanvasAsset => "CANVAS_ASSET",
                AssetType.LayeredAsset => "LAYERED_ASSET",
                AssetType.Response => "RESPONSE",
                AssetType.Upload => "UPLOAD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetType? ToEnum(string value)
        {
            return value switch
            {
                "ASSET" => AssetType.Asset,
                "CANVAS_ASSET" => AssetType.CanvasAsset,
                "LAYERED_ASSET" => AssetType.LayeredAsset,
                "RESPONSE" => AssetType.Response,
                "UPLOAD" => AssetType.Upload,
                _ => null,
            };
        }
    }
}