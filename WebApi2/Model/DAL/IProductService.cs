using WebApi2.Model.Entititees;

namespace WebApi2.Model.DAL
{
    public interface IProductService
    {
        List<Product> GetProducts();

        Product GetProductById(int id);

        Product GetProductByName(string name);

        List<Product> GetProductBybrand(string brand);

        List<Product> GetProductByCategory(string category);

        List<Product> GetProductByPrice(double price);

        void AddProduct(Product product);

        void UpdateProduct(Product product);
        void DeleteProduct(int id);


    }
}
