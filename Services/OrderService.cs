using ProvaPub.Interfaces;
using ProvaPub.Models;

namespace ProvaPub.Services
{
	public class OrderService
	{
		public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
			IPaymentService _paymentService = PaymentMethodService.SelectPayment(paymentMethod);

			_paymentService.Payment(paymentValue, customerId);

			return await Task.FromResult( new Order()
			{
				Value = paymentValue
			});
		}
	}
}
