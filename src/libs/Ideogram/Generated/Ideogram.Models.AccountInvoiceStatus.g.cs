
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Status of the invoice<br/>
    /// Example: paid
    /// </summary>
    public enum AccountInvoiceStatus
    {
        /// <summary>
        ///
        /// </summary>
        Draft,
        /// <summary>
        ///
        /// </summary>
        Paid,
        /// <summary>
        ///
        /// </summary>
        PendingPayment,
        /// <summary>
        ///
        /// </summary>
        Voided,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccountInvoiceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountInvoiceStatus value)
        {
            return value switch
            {
                AccountInvoiceStatus.Draft => "draft",
                AccountInvoiceStatus.Paid => "paid",
                AccountInvoiceStatus.PendingPayment => "pending_payment",
                AccountInvoiceStatus.Voided => "voided",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountInvoiceStatus? ToEnum(string value)
        {
            return value switch
            {
                "draft" => AccountInvoiceStatus.Draft,
                "paid" => AccountInvoiceStatus.Paid,
                "pending_payment" => AccountInvoiceStatus.PendingPayment,
                "voided" => AccountInvoiceStatus.Voided,
                _ => null,
            };
        }
    }
}