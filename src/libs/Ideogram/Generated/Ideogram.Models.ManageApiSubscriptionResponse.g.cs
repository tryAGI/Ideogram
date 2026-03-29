
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"recharge_settings":{"is_active":true},"has_stripe_setup":true,"metronome_dashboard_dark_mode_url":"metronome_dashboard_dark_mode_url","stripe_billing_url":"stripe_billing_url","current_balance":{"amount":1050,"currency_code":"USD"},"has_accepted_terms":true,"metronome_dashboard_url":"metronome_dashboard_url","metronome_links":{"usage_iframe_url":"usage_iframe_url","usage_iframe_dark_mode_url":"usage_iframe_dark_mode_url","credits_iframe_dark_mode_url":"credits_iframe_dark_mode_url","invoices_iframe_dark_mode_url":"invoices_iframe_dark_mode_url","invoices_iframe_url":"invoices_iframe_url","credits_iframe_url":"credits_iframe_url"}}
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
        /// Example: {"usage_iframe_url":"usage_iframe_url","usage_iframe_dark_mode_url":"usage_iframe_dark_mode_url","credits_iframe_dark_mode_url":"credits_iframe_dark_mode_url","invoices_iframe_dark_mode_url":"invoices_iframe_dark_mode_url","invoices_iframe_url":"invoices_iframe_url","credits_iframe_url":"credits_iframe_url"}
        /// </summary>
        /// <example>{"usage_iframe_url":"usage_iframe_url","usage_iframe_dark_mode_url":"usage_iframe_dark_mode_url","credits_iframe_dark_mode_url":"credits_iframe_dark_mode_url","invoices_iframe_dark_mode_url":"invoices_iframe_dark_mode_url","invoices_iframe_url":"invoices_iframe_url","credits_iframe_url":"credits_iframe_url"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_links")]
        public global::Ideogram.MetronomeLinks? MetronomeLinks { get; set; }

        /// <summary>
        /// Example: {"is_active":true}
        /// </summary>
        /// <example>{"is_active":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recharge_settings")]
        public global::Ideogram.RechargeSettingsResponse? RechargeSettings { get; set; }

        /// <summary>
        /// The URL for the user to manage the existing Stripe subscription plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_billing_url")]
        public string? StripeBillingUrl { get; set; }

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price CurrentBalance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="hasAcceptedTerms">
        /// Whether or not the latest required terms have been accepted.
        /// </param>
        /// <param name="hasStripeSetup">
        /// Whether or not Stripe is setup for API usage.
        /// </param>
        /// <param name="currentBalance">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="metronomeLinks">
        /// Example: {"usage_iframe_url":"usage_iframe_url","usage_iframe_dark_mode_url":"usage_iframe_dark_mode_url","credits_iframe_dark_mode_url":"credits_iframe_dark_mode_url","invoices_iframe_dark_mode_url":"invoices_iframe_dark_mode_url","invoices_iframe_url":"invoices_iframe_url","credits_iframe_url":"credits_iframe_url"}
        /// </param>
        /// <param name="rechargeSettings">
        /// Example: {"is_active":true}
        /// </param>
        /// <param name="stripeBillingUrl">
        /// The URL for the user to manage the existing Stripe subscription plan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManageApiSubscriptionResponse(
            bool hasAcceptedTerms,
            bool hasStripeSetup,
            global::Ideogram.Price currentBalance,
            global::Ideogram.MetronomeLinks? metronomeLinks,
            global::Ideogram.RechargeSettingsResponse? rechargeSettings,
            string? stripeBillingUrl)
        {
            this.HasAcceptedTerms = hasAcceptedTerms;
            this.HasStripeSetup = hasStripeSetup;
            this.MetronomeLinks = metronomeLinks;
            this.RechargeSettings = rechargeSettings;
            this.StripeBillingUrl = stripeBillingUrl;
            this.CurrentBalance = currentBalance ?? throw new global::System.ArgumentNullException(nameof(currentBalance));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiSubscriptionResponse" /> class.
        /// </summary>
        public ManageApiSubscriptionResponse()
        {
        }
    }
}