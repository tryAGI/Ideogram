
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"start_time":"2000-01-23T04:56:07\u002B00:00","total":"150.00","paid_time":"2000-01-23T04:56:07\u002B00:00","end_time":"2000-01-23T04:56:07\u002B00:00","line_items":[{"cost_total":"84.00","quantity":"2100","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","unit_price":"0.04","currency_code":"USD"},{"cost_total":"84.00","quantity":"2100","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","unit_price":"0.04","currency_code":"USD"}],"issued_time":"2000-01-23T04:56:07\u002B00:00","currency_code":"USD","status":"paid"}
    /// </summary>
    public sealed partial class AccountInvoice
    {
        /// <summary>
        /// Start of the invoice period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// End of the invoice period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// When the invoice was issued, when it has been.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issued_time")]
        public global::System.DateTime? IssuedTime { get; set; }

        /// <summary>
        /// When the invoice was paid, when it has been.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paid_time")]
        public global::System.DateTime? PaidTime { get; set; }

        /// <summary>
        /// Status of the invoice<br/>
        /// Example: paid
        /// </summary>
        /// <example>paid</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AccountInvoiceStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AccountInvoiceStatus Status { get; set; }

        /// <summary>
        /// Invoice total in `currency_code`, as a decimal string.<br/>
        /// Example: 150.00
        /// </summary>
        /// <example>150.00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Total { get; set; }

        /// <summary>
        /// ISO 4217 currency code of the amounts on this invoice.<br/>
        /// Example: USD
        /// </summary>
        /// <example>USD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrencyCode { get; set; }

        /// <summary>
        /// The invoice's charges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AccountInvoiceLineItem> LineItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInvoice" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Start of the invoice period.
        /// </param>
        /// <param name="endTime">
        /// End of the invoice period.
        /// </param>
        /// <param name="status">
        /// Status of the invoice<br/>
        /// Example: paid
        /// </param>
        /// <param name="total">
        /// Invoice total in `currency_code`, as a decimal string.<br/>
        /// Example: 150.00
        /// </param>
        /// <param name="currencyCode">
        /// ISO 4217 currency code of the amounts on this invoice.<br/>
        /// Example: USD
        /// </param>
        /// <param name="lineItems">
        /// The invoice's charges.
        /// </param>
        /// <param name="issuedTime">
        /// When the invoice was issued, when it has been.
        /// </param>
        /// <param name="paidTime">
        /// When the invoice was paid, when it has been.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountInvoice(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::Ideogram.AccountInvoiceStatus status,
            string total,
            string currencyCode,
            global::System.Collections.Generic.IList<global::Ideogram.AccountInvoiceLineItem> lineItems,
            global::System.DateTime? issuedTime,
            global::System.DateTime? paidTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.IssuedTime = issuedTime;
            this.PaidTime = paidTime;
            this.Status = status;
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
            this.CurrencyCode = currencyCode ?? throw new global::System.ArgumentNullException(nameof(currencyCode));
            this.LineItems = lineItems ?? throw new global::System.ArgumentNullException(nameof(lineItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInvoice" /> class.
        /// </summary>
        public AccountInvoice()
        {
        }

    }
}