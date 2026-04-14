
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"total_spend":{"amount":1050,"currency_code":"USD"},"start_time":"2024-01-01T00:00:00\u002B00:00","end_time":"2024-01-31T23:59:59\u002B00:00","invoice_id":"invoice_123","line_items":[{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"},"api_key_id":"api_key_id"},{"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"},"api_key_id":"api_key_id"}],"issued_time":"2024-01-01T00:00:00\u002B00:00","paid_date":"2024-02-01T00:00:00\u002B00:00","invoice_status":"PAID"}
    /// </summary>
    public sealed partial class Invoice
    {
        /// <summary>
        /// The invoice ID in Metronome<br/>
        /// Example: invoice_123
        /// </summary>
        /// <example>invoice_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_id")]
        public string? InvoiceId { get; set; }

        /// <summary>
        /// The start time of the invoice period<br/>
        /// Example: 2024-01-01T00:00:00+00:00
        /// </summary>
        /// <example>2024-01-01T00:00:00+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The end time of the invoice period<br/>
        /// Example: 2024-01-31T23:59:59+00:00
        /// </summary>
        /// <example>2024-01-31T23:59:59+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// The date when the invoice was issued<br/>
        /// Example: 2024-01-01T00:00:00+00:00
        /// </summary>
        /// <example>2024-01-01T00:00:00+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issued_time")]
        public global::System.DateTime? IssuedTime { get; set; }

        /// <summary>
        /// The date when the invoice was marked paid in Metronome<br/>
        /// Example: 2024-02-01T00:00:00+00:00
        /// </summary>
        /// <example>2024-02-01T00:00:00+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("paid_date")]
        public global::System.DateTime? PaidDate { get; set; }

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price TotalSpend { get; set; }

        /// <summary>
        /// Status of the invoice<br/>
        /// Example: PAID
        /// </summary>
        /// <example>PAID</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.InvoiceStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.InvoiceStatus InvoiceStatus { get; set; }

        /// <summary>
        /// A list of line items within the invoice<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.InvoiceLineItem> LineItems { get; set; }

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
        /// Example: 2024-01-01T00:00:00+00:00
        /// </param>
        /// <param name="endTime">
        /// The end time of the invoice period<br/>
        /// Example: 2024-01-31T23:59:59+00:00
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
        /// A list of line items within the invoice<br/>
        /// Default Value: []
        /// </param>
        /// <param name="invoiceId">
        /// The invoice ID in Metronome<br/>
        /// Example: invoice_123
        /// </param>
        /// <param name="issuedTime">
        /// The date when the invoice was issued<br/>
        /// Example: 2024-01-01T00:00:00+00:00
        /// </param>
        /// <param name="paidDate">
        /// The date when the invoice was marked paid in Metronome<br/>
        /// Example: 2024-02-01T00:00:00+00:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Invoice(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::Ideogram.Price totalSpend,
            global::Ideogram.InvoiceStatus invoiceStatus,
            global::System.Collections.Generic.IList<global::Ideogram.InvoiceLineItem> lineItems,
            string? invoiceId,
            global::System.DateTime? issuedTime,
            global::System.DateTime? paidDate)
        {
            this.InvoiceId = invoiceId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.IssuedTime = issuedTime;
            this.PaidDate = paidDate;
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