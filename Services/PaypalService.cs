using ProvaPub.Interfaces;

namespace ProvaPub.Services
{
    public class PaypalService : IPaymentService
    {
        public void Payment(decimal paymentValue, int customerId)
        {
            //Faz pagamento...
        }
    }
}
