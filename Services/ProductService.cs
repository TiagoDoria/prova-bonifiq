using ProvaPub.Interfaces;
using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public class ProductService : IProductService
	{
		TestDbContext _ctx;

		public ProductService(TestDbContext ctx)
		{
			_ctx = ctx;
		}

		public GenericList<Product> ListProducts(int page)
		{
			GenericList<Product> products = new GenericList<Product>();
			return products.ListItems<Product>(page, _ctx.Products.ToList());
		}

	}
}
