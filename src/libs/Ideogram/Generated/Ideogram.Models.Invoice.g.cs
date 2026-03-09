
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"total_spend":{"amount":1050,"currency_code":"USD"},"start_time":"2024-01-01T00:00:00.0000000\u002B00:00","end_time":"2024-01-31T23:59:59.0000000\u002B00:00","line_items":[{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"}},{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"}}],"issued_time":"2024-01-01T00:00:00.0000000\u002B00:00","invoice_status":"PAID"}
    /// </summary>
    public sealed partial class Invoice
    {
        /// <summary>
        /// The start time of the invoice period<br/>
        /// Example: 2024-01-01T00:00:00.0000000+00:00
        /// </summary>
        /// <example>2024-01-01T00:00:00.0000000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// The end time of the invoice period<br/>
        /// Example: 2024-01-31T23:59:59.0000000+00:00
        /// </summary>
        /// <example>2024-01-31T23:59:59.0000000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime EndTime { get; set; } = default!;

        /// <summary>
        /// The date when the invoice was issued<br/>
        /// Example: 2024-01-01T00:00:00.0000000+00:00
        /// </summary>
        /// <example>2024-01-01T00:00:00.0000000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issued_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime IssuedTime { get; set; } = default!;

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Ideogram.Price TotalSpend { get; set; } = default!;

        /// <summary>
        /// Status of the invoice<br/>
        /// Example: PAID
        /// </summary>
        /// <example>PAID</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.InvoiceStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Ideogram.InvoiceStatus InvoiceStatus { get; set; } = default!;

        /// <summary>
        /// A list of line items within the invoice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Ideogram.InvoiceLineItem> LineItems { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        /// <param name="startTime">
        /// The start time of the invoice period<br/>
        /// Example: 2024-01-01T00:00:00.0000000+00:00
        /// </param>
        /// <param name="endTime">
        /// The end time of the invoice period<br/>
        /// Example: 2024-01-31T23:59:59.0000000+00:00
        /// </param>
        /// <param name="issuedTime">
        /// The date when the invoice was issued<br/>
        /// Example: 2024-01-01T00:00:00.0000000+00:00
        /// </param>
        /// <param name="totalSpend">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="invoiceStatus">
        /// Status of the invoice<br/>
        /// Example: PAID
        /// </param>
        /// <param name="lineItems">
        /// A list of line items within the invoice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Invoice(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.DateTime issuedTime,
            global::Ideogram.Price totalSpend,
            global::Ideogram.InvoiceStatus invoiceStatus,
            global::System.Collections.Generic.IList<global::Ideogram.InvoiceLineItem> lineItems)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.IssuedTime = issuedTime;
            this.TotalSpend = totalSpend ?? throw new global::System.ArgumentNullException(nameof(totalSpend));
            this.InvoiceStatus = invoiceStatus;
            this.LineItems = lineItems ?? throw new global::System.ArgumentNullException(nameof(lineItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        public Invoice()
        {
        }
    }
}