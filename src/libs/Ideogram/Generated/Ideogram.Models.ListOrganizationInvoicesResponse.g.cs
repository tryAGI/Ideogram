
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"invoices":[{"total_spend":{"amount":1050,"currency_code":"USD"},"start_time":"2024-01-01T00:00:00\u002B00:00","end_time":"2024-01-31T23:59:59\u002B00:00","invoice_id":"invoice_123","line_items":[{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"},"api_key_id":"api_key_id"},{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"},"api_key_id":"api_key_id"}],"issued_time":"2024-01-01T00:00:00\u002B00:00","paid_date":"2024-02-01T00:00:00\u002B00:00","invoice_status":"PAID"},{"total_spend":{"amount":1050,"currency_code":"USD"},"start_time":"2024-01-01T00:00:00\u002B00:00","end_time":"2024-01-31T23:59:59\u002B00:00","invoice_id":"invoice_123","line_items":[{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"},"api_key_id":"api_key_id"},{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"},"api_key_id":"api_key_id"}],"issued_time":"2024-01-01T00:00:00\u002B00:00","paid_date":"2024-02-01T00:00:00\u002B00:00","invoice_status":"PAID"}],"billing_configured":true}
    /// </summary>
    public sealed partial class ListOrganizationInvoicesResponse
    {
        /// <summary>
        /// List of invoices<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.Invoice> Invoices { get; set; }

        /// <summary>
        /// Whether the organization has a billing account that invoices can be issued against. When false, the list is empty because nothing is billed yet, not because nothing was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_configured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BillingConfigured { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationInvoicesResponse" /> class.
        /// </summary>
        /// <param name="invoices">
        /// List of invoices<br/>
        /// Default Value: []
        /// </param>
        /// <param name="billingConfigured">
        /// Whether the organization has a billing account that invoices can be issued against. When false, the list is empty because nothing is billed yet, not because nothing was used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOrganizationInvoicesResponse(
            global::System.Collections.Generic.IList<global::Ideogram.Invoice> invoices,
            bool billingConfigured)
        {
            this.Invoices = invoices ?? throw new global::System.ArgumentNullException(nameof(invoices));
            this.BillingConfigured = billingConfigured;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationInvoicesResponse" /> class.
        /// </summary>
        public ListOrganizationInvoicesResponse()
        {
        }

    }
}