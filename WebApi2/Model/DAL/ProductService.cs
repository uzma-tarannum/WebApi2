using System.Linq;
using WebApi2.Model.Entititees;

namespace WebApi2.Model.DAL
{
    public class ProductService : IProductService
    {
        DbContextClass _dbContextClass = new DbContextClass();
        public void AddProduct(Product product)
        {
            _dbContextClass.Products.Add(product);
            _dbContextClass.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _dbContextClass.Products.Find(id);
            _dbContextClass.Remove(product);
            _dbContextClass.SaveChanges();
        }

        public List<Product> GetProductBybrand(string brand)
        {
            return (from p in  _dbContextClass.Products 
                     where p.Brand == brand select p).ToList();
        }

        public List<Product> GetProductByCategory(string category)
        {
            return (from p in  _dbContextClass.Products
                    where p.Category == category select p).ToList();
        }

        public Product GetProductById(int id)
        {
            var product = _dbContextClass.Products.Find(id);
            return product;
        }

        public Product GetProductByName(string name)
        {
            var product = _dbContextClass.Products.Find(name);
            return product;
        }

        public List<Product> GetProductByPrice(double price)
        {
            var product = (from p in _dbContextClass.Products
                           where p.Price== price select p).ToList();
            return product;
        }

        public List<Product> GetProducts()
        {
            var p = _dbContextClass.Products.ToList();
            return p;
        }

        public void UpdateProduct(Product product)
        {
            _dbContextClass.Products.Update(product);
            _dbContextClass.SaveChanges();
        }
    }
}
