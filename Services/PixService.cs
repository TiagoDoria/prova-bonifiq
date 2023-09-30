using ProvaPub.Interfaces;

namespace ProvaPub.Services
{
    public class PixService : IPaymentService
    {
        public void Payment(decimal paymentValue, int customerId)
        {
           //Faz pagamento...
        }
    }
}
