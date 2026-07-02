
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"has_stripe_setup":true,"stripe_billing_url":"stripe_billing_url"}
    /// </summary>
    public sealed partial class GetOrganizationBillingPortalResponse
    {
        /// <summary>
        /// Whether or not Stripe billing is set up for the organization's API usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_stripe_setup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasStripeSetup { get; set; }

        /// <summary>
        /// The URL for an organization admin to manage the organization's Stripe billing, including adding or removing payment methods. Absent when no Stripe customer exists for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_billing_url")]
        public string? StripeBillingUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationBillingPortalResponse" /> class.
        /// </summary>
        /// <param name="hasStripeSetup">
        /// Whether or not Stripe billing is set up for the organization's API usage.
        /// </param>
        /// <param name="stripeBillingUrl">
        /// The URL for an organization admin to manage the organization's Stripe billing, including adding or removing payment methods. Absent when no Stripe customer exists for the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationBillingPortalResponse(
            bool hasStripeSetup,
            string? stripeBillingUrl)
        {
            this.HasStripeSetup = hasStripeSetup;
            this.StripeBillingUrl = stripeBillingUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationBillingPortalResponse" /> class.
        /// </summary>
        public GetOrganizationBillingPortalResponse()
        {
        }

    }
}