using ProvaPub.Interfaces;

namespace ProvaPub.Services
{
    public class CreditCardService : IPaymentService
    {
        public void Payment(decimal paymentValue, int customerId)
        {
            //Faz pagamento...
        }
    }
}
