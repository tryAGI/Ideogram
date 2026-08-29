
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"client_secret":"client_secret"}
    /// </summary>
    public sealed partial class ManageApiPaymentResponse
    {
        /// <summary>
        /// client_secret to be passed to the inline payment Elements on the client. Soft-deprecated — new clients use stripe_payment_setup_url on ManageApiStripeSubscriptionResponse for the hosted Checkout flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiPaymentResponse" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// client_secret to be passed to the inline payment Elements on the client. Soft-deprecated — new clients use stripe_payment_setup_url on ManageApiStripeSubscriptionResponse for the hosted Checkout flow.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManageApiPaymentResponse(
            string clientSecret)
        {
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiPaymentResponse" /> class.
        /// </summary>
        public ManageApiPaymentResponse()
        {
        }

    }
}