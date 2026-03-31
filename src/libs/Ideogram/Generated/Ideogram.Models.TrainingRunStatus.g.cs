
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The status of a training run.
    /// </summary>
    public enum TrainingRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Finalizing,
        /// <summary>
        /// 
        /// </summary>
        PreparingData,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Training,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainingRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingRunStatus value)
        {
            return value switch
            {
                TrainingRunStatus.Completed => "COMPLETED",
                TrainingRunStatus.Finalizing => "FINALIZING",
                TrainingRunStatus.PreparingData => "PREPARING_DATA",
                TrainingRunStatus.Queued => "QUEUED",
                TrainingRunStatus.Training => "TRAINING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainingRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => TrainingRunStatus.Completed,
                "FINALIZING" => TrainingRunStatus.Finalizing,
                "PREPARING_DATA" => TrainingRunStatus.PreparingData,
                "QUEUED" => TrainingRunStatus.Queued,
                "TRAINING" => TrainingRunStatus.Training,
                _ => null,
            };
        }
    }
}