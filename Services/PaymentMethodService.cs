using ProvaPub.Enums;
using ProvaPub.Interfaces;

namespace ProvaPub.Services
{
    public static class PaymentMethodService
    {
        public static IPaymentService SelectPayment(string paymentMethod)
        {
            switch (paymentMethod)
            {
                case "pix": return new PixService();
                case "creditcard": return new CreditCardService();
                case "paypal": return new PaypalService();
                default: throw new ArgumentException("Invalid payment method!");
            }
        }
    }
}
