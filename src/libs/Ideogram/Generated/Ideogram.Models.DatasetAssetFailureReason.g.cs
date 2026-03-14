
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Reason why an asset failed to upload.
    /// </summary>
    public enum DatasetAssetFailureReason
    {
        /// <summary>
        /// 
        /// </summary>
        FailedSafetyCheck,
        /// <summary>
        /// 
        /// </summary>
        FileTooLarge,
        /// <summary>
        /// 
        /// </summary>
        InternalError,
        /// <summary>
        /// 
        /// </summary>
        InvalidCaption,
        /// <summary>
        /// 
        /// </summary>
        InvalidImage,
        /// <summary>
        /// 
        /// </summary>
        InvalidZip,
        /// <summary>
        /// 
        /// </summary>
        TooManyImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetAssetFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetAssetFailureReason value)
        {
            return value switch
            {
                DatasetAssetFailureReason.FailedSafetyCheck => "FAILED_SAFETY_CHECK",
                DatasetAssetFailureReason.FileTooLarge => "FILE_TOO_LARGE",
                DatasetAssetFailureReason.InternalError => "INTERNAL_ERROR",
                DatasetAssetFailureReason.InvalidCaption => "INVALID_CAPTION",
                DatasetAssetFailureReason.InvalidImage => "INVALID_IMAGE",
                DatasetAssetFailureReason.InvalidZip => "INVALID_ZIP",
                DatasetAssetFailureReason.TooManyImages => "TOO_MANY_IMAGES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetAssetFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "FAILED_SAFETY_CHECK" => DatasetAssetFailureReason.FailedSafetyCheck,
                "FILE_TOO_LARGE" => DatasetAssetFailureReason.FileTooLarge,
                "INTERNAL_ERROR" => DatasetAssetFailureReason.InternalError,
                "INVALID_CAPTION" => DatasetAssetFailureReason.InvalidCaption,
                "INVALID_IMAGE" => DatasetAssetFailureReason.InvalidImage,
                "INVALID_ZIP" => DatasetAssetFailureReason.InvalidZip,
                "TOO_MANY_IMAGES" => DatasetAssetFailureReason.TooManyImages,
                _ => null,
            };
        }
    }
}