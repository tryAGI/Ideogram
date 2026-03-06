
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Status of the invoice<br/>
    /// Example: PAID
    /// </summary>
    public enum InvoiceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        PendingPayment,
        /// <summary>
        /// 
        /// </summary>
        Paid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvoiceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvoiceStatus value)
        {
            return value switch
            {
                InvoiceStatus.Draft => "DRAFT",
                InvoiceStatus.PendingPayment => "PENDING_PAYMENT",
                InvoiceStatus.Paid => "PAID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvoiceStatus? ToEnum(string value)
        {
            return value switch
            {
                "DRAFT" => InvoiceStatus.Draft,
                "PENDING_PAYMENT" => InvoiceStatus.PendingPayment,
                "PAID" => InvoiceStatus.Paid,
                _ => null,
            };
        }
    }
}