
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The price a request would cost, returned in place of the endpoint's<br/>
    /// usual response when `dry_run=true`. Money is in millionths of a US<br/>
    /// dollar and credits in thousandths of a credit, so a quote can be<br/>
    /// compared against `usage_cost_usd_micros` and credit balances without<br/>
    /// rounding.
    /// </summary>
    public sealed partial class PriceQuote
    {
        /// <summary>
        /// Always "price_quote".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.PriceQuoteObjectJsonConverter))]
        public global::Ideogram.PriceQuoteObject Object { get; set; }

        /// <summary>
        /// The catalog product the request would bill.<br/>
        /// Example: ideogram_v3_generation
        /// </summary>
        /// <example>ideogram_v3_generation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingIdentifier { get; set; }

        /// <summary>
        /// Billable units the request would consume, usually the image count.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Quantity { get; set; }

        /// <summary>
        /// The price in millionths of a US dollar.<br/>
        /// Example: 60000
        /// </summary>
        /// <example>60000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usd_micros")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UsdMicros { get; set; }

        /// <summary>
        /// The credit charge for callers funded from credits, in thousandths<br/>
        /// of a credit at the caller's own credit rate.<br/>
        /// Example: 3000
        /// </summary>
        /// <example>3000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CreditMillis { get; set; }

        /// <summary>
        /// Whether a quoted price is what the request would bill (`exact`) or a<br/>
        /// computed estimate for a product priced from provider cost after<br/>
        /// inference (`estimate`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qualifier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.PriceQualifierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.PriceQualifier Qualifier { get; set; }

        /// <summary>
        /// The most the request can cost, in millionths of a US dollar.<br/>
        /// Present only on estimates.<br/>
        /// Example: 84000
        /// </summary>
        /// <example>84000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upper_bound_usd_micros")]
        public long? UpperBoundUsdMicros { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceQuote" /> class.
        /// </summary>
        /// <param name="billingIdentifier">
        /// The catalog product the request would bill.<br/>
        /// Example: ideogram_v3_generation
        /// </param>
        /// <param name="quantity">
        /// Billable units the request would consume, usually the image count.<br/>
        /// Example: 2
        /// </param>
        /// <param name="usdMicros">
        /// The price in millionths of a US dollar.<br/>
        /// Example: 60000
        /// </param>
        /// <param name="creditMillis">
        /// The credit charge for callers funded from credits, in thousandths<br/>
        /// of a credit at the caller's own credit rate.<br/>
        /// Example: 3000
        /// </param>
        /// <param name="qualifier">
        /// Whether a quoted price is what the request would bill (`exact`) or a<br/>
        /// computed estimate for a product priced from provider cost after<br/>
        /// inference (`estimate`).
        /// </param>
        /// <param name="object">
        /// Always "price_quote".
        /// </param>
        /// <param name="upperBoundUsdMicros">
        /// The most the request can cost, in millionths of a US dollar.<br/>
        /// Present only on estimates.<br/>
        /// Example: 84000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PriceQuote(
            string billingIdentifier,
            int quantity,
            long usdMicros,
            long creditMillis,
            global::Ideogram.PriceQualifier qualifier,
            global::Ideogram.PriceQuoteObject @object,
            long? upperBoundUsdMicros)
        {
            this.Object = @object;
            this.BillingIdentifier = billingIdentifier ?? throw new global::System.ArgumentNullException(nameof(billingIdentifier));
            this.Quantity = quantity;
            this.UsdMicros = usdMicros;
            this.CreditMillis = creditMillis;
            this.Qualifier = qualifier;
            this.UpperBoundUsdMicros = upperBoundUsdMicros;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceQuote" /> class.
        /// </summary>
        public PriceQuote()
        {
        }

    }
}