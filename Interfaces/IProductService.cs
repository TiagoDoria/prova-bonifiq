using ProvaPub.Models;

namespace ProvaPub.Interfaces
{
    public interface IProductService
    {
        GenericList<Product> ListProducts(int page);
    }
}
