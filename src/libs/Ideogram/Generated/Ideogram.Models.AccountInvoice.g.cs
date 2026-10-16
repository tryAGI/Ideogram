
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
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
        /// Status of the invoice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AccountInvoiceStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AccountInvoiceStatus Status { get; set; }

        /// <summary>
        /// Invoice total in `currency_code`, as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Total { get; set; }

        /// <summary>
        /// ISO 4217 currency code of the amounts on this invoice.
        /// </summary>
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
        /// Status of the invoice
        /// </param>
        /// <param name="total">
        /// Invoice total in `currency_code`, as a decimal string.
        /// </param>
        /// <param name="currencyCode">
        /// ISO 4217 currency code of the amounts on this invoice.
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