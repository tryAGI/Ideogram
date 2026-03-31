
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The status of a custom model.
    /// </summary>
    public enum ModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Creating,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Errored,
        /// <summary>
        /// 
        /// </summary>
        Training,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelStatus value)
        {
            return value switch
            {
                ModelStatus.Archived => "ARCHIVED",
                ModelStatus.Completed => "COMPLETED",
                ModelStatus.Creating => "CREATING",
                ModelStatus.Draft => "DRAFT",
                ModelStatus.Errored => "ERRORED",
                ModelStatus.Training => "TRAINING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "ARCHIVED" => ModelStatus.Archived,
                "COMPLETED" => ModelStatus.Completed,
                "CREATING" => ModelStatus.Creating,
                "DRAFT" => ModelStatus.Draft,
                "ERRORED" => ModelStatus.Errored,
                "TRAINING" => ModelStatus.Training,
                _ => null,
            };
        }
    }
}