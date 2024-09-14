
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManageApiSubscriptionResponse
    {
        /// <summary>
        /// Whether or not the latest required terms have been accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_accepted_terms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAcceptedTerms { get; set; }

        /// <summary>
        /// Whether or not Stripe is setup for API usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_stripe_setup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasStripeSetup { get; set; }

        /// <summary>
        /// The URL to display the customer usage dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_dashboard_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MetronomeDashboardUrl { get; set; }

        /// <summary>
        /// The URL to display the customer usage dashboard, in dark mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_dashboard_dark_mode_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MetronomeDashboardDarkModeUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_links")]
        public global::Ideogram.MetronomeLinks? MetronomeLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recharge_settings")]
        public global::Ideogram.RechargeSettingsResponse? RechargeSettings { get; set; }

        /// <summary>
        /// The URL for the user to manage the existing Stripe subscription plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_billing_url")]
        public string? StripeBillingUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}