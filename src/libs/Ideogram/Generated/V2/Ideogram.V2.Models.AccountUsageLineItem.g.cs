
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// One billed rate for one billing actor within one time bucket.
    /// </summary>
    public sealed partial class AccountUsageLineItem
    {
        /// <summary>
        /// Stable identifier of the public pricing catalog entry this charge was billed under, at the granularity the pricing page prices it (for example one entry per quality and resolution). `unknown` when a historical charge can no longer be attributed; its cost is still included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Product { get; set; }

        /// <summary>
        /// The API endpoint path this product belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// Name of the public pricing catalog entry, as shown on the pricing page. Not an identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Pricing dimensions this line item was billed under, for products priced per dimension (for example rendering speed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::System.Collections.Generic.Dictionary<string, string>? Dimensions { get; set; }

        /// <summary>
        /// Total billed amount in `currency_code`, as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CostTotal { get; set; }

        /// <summary>
        /// ISO 4217 currency code of the amounts on this line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrencyCode { get; set; }

        /// <summary>
        /// Which billing surface the usage came through. `api` usage is attributed to an API key when one was used; `app` usage is attributed to the member who generated it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.AccountUsageLineItemSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.AccountUsageLineItemSource Source { get; set; }

        /// <summary>
        /// The API key the usage was billed to, in redacted form.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::Ideogram.V2.AccountUsageApiKey? ApiKey { get; set; }

        /// <summary>
        /// Email address of the member who generated the usage. Only present on `app` usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Per-unit detail for products billed per item. `quantity × unit_price` always equals the line item's `cost_total`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billed_units")]
        public global::Ideogram.V2.AccountUsageBilledUnits? BilledUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsageLineItem" /> class.
        /// </summary>
        /// <param name="product">
        /// Stable identifier of the public pricing catalog entry this charge was billed under, at the granularity the pricing page prices it (for example one entry per quality and resolution). `unknown` when a historical charge can no longer be attributed; its cost is still included.
        /// </param>
        /// <param name="endpoint">
        /// The API endpoint path this product belongs to.
        /// </param>
        /// <param name="description">
        /// Name of the public pricing catalog entry, as shown on the pricing page. Not an identifier.
        /// </param>
        /// <param name="costTotal">
        /// Total billed amount in `currency_code`, as a decimal string.
        /// </param>
        /// <param name="currencyCode">
        /// ISO 4217 currency code of the amounts on this line item.
        /// </param>
        /// <param name="source">
        /// Which billing surface the usage came through. `api` usage is attributed to an API key when one was used; `app` usage is attributed to the member who generated it.
        /// </param>
        /// <param name="dimensions">
        /// Pricing dimensions this line item was billed under, for products priced per dimension (for example rendering speed).
        /// </param>
        /// <param name="apiKey">
        /// The API key the usage was billed to, in redacted form.
        /// </param>
        /// <param name="userEmail">
        /// Email address of the member who generated the usage. Only present on `app` usage.
        /// </param>
        /// <param name="billedUnits">
        /// Per-unit detail for products billed per item. `quantity × unit_price` always equals the line item's `cost_total`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountUsageLineItem(
            string product,
            string endpoint,
            string description,
            string costTotal,
            string currencyCode,
            global::Ideogram.V2.AccountUsageLineItemSource source,
            global::System.Collections.Generic.Dictionary<string, string>? dimensions,
            global::Ideogram.V2.AccountUsageApiKey? apiKey,
            string? userEmail,
            global::Ideogram.V2.AccountUsageBilledUnits? billedUnits)
        {
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Dimensions = dimensions;
            this.CostTotal = costTotal ?? throw new global::System.ArgumentNullException(nameof(costTotal));
            this.CurrencyCode = currencyCode ?? throw new global::System.ArgumentNullException(nameof(currencyCode));
            this.Source = source;
            this.ApiKey = apiKey;
            this.UserEmail = userEmail;
            this.BilledUnits = billedUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsageLineItem" /> class.
        /// </summary>
        public AccountUsageLineItem()
        {
        }

    }
}