namespace ProvaPub.Interfaces
{
    public interface IPaymentService
    {
        void Payment(decimal paymentValue, int customerId);
    }
}
