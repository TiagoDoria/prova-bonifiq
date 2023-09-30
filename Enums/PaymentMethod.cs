using System.ComponentModel;

namespace ProvaPub.Enums
{
    public enum PaymentMethodEnum
    {
        [Description("pix")]
        Pix,
        [Description("creditcard")]
        Creditcard,
        [Description("paypal")]
        Paypal
    }
}
