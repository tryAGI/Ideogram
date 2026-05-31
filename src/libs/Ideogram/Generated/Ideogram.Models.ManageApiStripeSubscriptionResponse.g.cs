
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"stripe_subscription_url":"stripe_subscription_url","stripe_billing_url":"stripe_billing_url","stripe_payment_setup_url":"stripe_payment_setup_url"}
    /// </summary>
    public sealed partial class ManageApiStripeSubscriptionResponse
    {
        /// <summary>
        /// The URL for the user to checkout the Stripe subscription plan. Soft-deprecated — this is the legacy $0-subscription flow; new clients use stripe_payment_setup_url instead. Removed once no callers reference it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_subscription_url")]
        public string? StripeSubscriptionUrl { get; set; }

        /// <summary>
        /// The URL for the user to capture a payment method via hosted Stripe Checkout (mode='setup'). No charge happens during this flow; the captured payment method is attached to the org's Stripe Customer via the checkout.session.completed webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_payment_setup_url")]
        public string? StripePaymentSetupUrl { get; set; }

        /// <summary>
        /// DEPRECATED. The URL for the user to manage the existing Stripe subscription plan. Get this from ManageApiSubscriptionResponse instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_billing_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? StripeBillingUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiStripeSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="stripeSubscriptionUrl">
        /// The URL for the user to checkout the Stripe subscription plan. Soft-deprecated — this is the legacy $0-subscription flow; new clients use stripe_payment_setup_url instead. Removed once no callers reference it.
        /// </param>
        /// <param name="stripePaymentSetupUrl">
        /// The URL for the user to capture a payment method via hosted Stripe Checkout (mode='setup'). No charge happens during this flow; the captured payment method is attached to the org's Stripe Customer via the checkout.session.completed webhook.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManageApiStripeSubscriptionResponse(
            string? stripeSubscriptionUrl,
            string? stripePaymentSetupUrl)
        {
            this.StripeSubscriptionUrl = stripeSubscriptionUrl;
            this.StripePaymentSetupUrl = stripePaymentSetupUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiStripeSubscriptionResponse" /> class.
        /// </summary>
        public ManageApiStripeSubscriptionResponse()
        {
        }

    }
}