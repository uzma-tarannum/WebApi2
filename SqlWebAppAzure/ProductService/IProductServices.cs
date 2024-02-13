using SqlWebAppAzure.Models;

namespace SqlWebAppAzure.ProductService
{
    public interface IProductServices
    {
        List<Product> GetProducts();
    }
}
