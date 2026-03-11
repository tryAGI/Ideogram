
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"invoices":[{"total_spend":{"amount":1050,"currency_code":"USD"},"start_time":"2024-01-01T00:00:00\u002B00:00","end_time":"2024-01-31T23:59:59\u002B00:00","line_items":[{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"}},{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"}}],"issued_time":"2024-01-01T00:00:00\u002B00:00","invoice_status":"PAID"},{"total_spend":{"amount":1050,"currency_code":"USD"},"start_time":"2024-01-01T00:00:00\u002B00:00","end_time":"2024-01-31T23:59:59\u002B00:00","line_items":[{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"}},{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"}}],"issued_time":"2024-01-01T00:00:00\u002B00:00","invoice_status":"PAID"}]}
    /// </summary>
    public sealed partial class ListOrganizationInvoicesResponse
    {
        /// <summary>
        /// List of invoices<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Ideogram.Invoice> Invoices { get; set; } = default!;

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOrganizationInvoicesResponse(
            global::System.Collections.Generic.IList<global::Ideogram.Invoice> invoices)
        {
            this.Invoices = invoices ?? throw new global::System.ArgumentNullException(nameof(invoices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationInvoicesResponse" /> class.
        /// </summary>
        public ListOrganizationInvoicesResponse()
        {
        }
    }
}