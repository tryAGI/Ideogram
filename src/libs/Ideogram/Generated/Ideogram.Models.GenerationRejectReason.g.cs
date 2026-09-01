
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The account or usage limit that rejected a generation request.
    /// </summary>
    public enum GenerationRejectReason
    {
        /// <summary>
        ///
        /// </summary>
        DailyLimit,
        /// <summary>
        ///
        /// </summary>
        FeatureLimit,
        /// <summary>
        ///
        /// </summary>
        InflightLimit,
        /// <summary>
        ///
        /// </summary>
        InsufficientFunds,
        /// <summary>
        ///
        /// </summary>
        PriorityCreditRequired,
        /// <summary>
        ///
        /// </summary>
        SubscriptionRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationRejectReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationRejectReason value)
        {
            return value switch
            {
                GenerationRejectReason.DailyLimit => "daily_limit",
                GenerationRejectReason.FeatureLimit => "feature_limit",
                GenerationRejectReason.InflightLimit => "inflight_limit",
                GenerationRejectReason.InsufficientFunds => "insufficient_funds",
                GenerationRejectReason.PriorityCreditRequired => "priority_credit_required",
                GenerationRejectReason.SubscriptionRequired => "subscription_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationRejectReason? ToEnum(string value)
        {
            return value switch
            {
                "daily_limit" => GenerationRejectReason.DailyLimit,
                "feature_limit" => GenerationRejectReason.FeatureLimit,
                "inflight_limit" => GenerationRejectReason.InflightLimit,
                "insufficient_funds" => GenerationRejectReason.InsufficientFunds,
                "priority_credit_required" => GenerationRejectReason.PriorityCreditRequired,
                "subscription_required" => GenerationRejectReason.SubscriptionRequired,
                _ => null,
            };
        }
    }
}