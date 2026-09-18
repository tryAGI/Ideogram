
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"invoices":[{"start_time":"2000-01-23T04:56:07\u002B00:00","total":"150.00","paid_time":"2000-01-23T04:56:07\u002B00:00","end_time":"2000-01-23T04:56:07\u002B00:00","line_items":[{"cost_total":"84.00","quantity":"2100","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","unit_price":"0.04","currency_code":"USD"},{"cost_total":"84.00","quantity":"2100","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","unit_price":"0.04","currency_code":"USD"}],"issued_time":"2000-01-23T04:56:07\u002B00:00","currency_code":"USD","status":"paid"},{"start_time":"2000-01-23T04:56:07\u002B00:00","total":"150.00","paid_time":"2000-01-23T04:56:07\u002B00:00","end_time":"2000-01-23T04:56:07\u002B00:00","line_items":[{"cost_total":"84.00","quantity":"2100","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","unit_price":"0.04","currency_code":"USD"},{"cost_total":"84.00","quantity":"2100","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","unit_price":"0.04","currency_code":"USD"}],"issued_time":"2000-01-23T04:56:07\u002B00:00","currency_code":"USD","status":"paid"}]}
    /// </summary>
    public sealed partial class ListAccountInvoicesResponse
    {
        /// <summary>
        /// The organization's invoices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AccountInvoice> Invoices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccountInvoicesResponse" /> class.
        /// </summary>
        /// <param name="invoices">
        /// The organization's invoices.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAccountInvoicesResponse(
            global::System.Collections.Generic.IList<global::Ideogram.AccountInvoice> invoices)
        {
            this.Invoices = invoices ?? throw new global::System.ArgumentNullException(nameof(invoices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccountInvoicesResponse" /> class.
        /// </summary>
        public ListAccountInvoicesResponse()
        {
        }

    }
}