using SqlWebAppAzure.Connection;
using SqlWebAppAzure.Models;
using System.Data.SqlClient;

namespace SqlWebAppAzure.ProductService
{
    public class ProductServices : IProductServices
    {
        ProductConnection _db = new ProductConnection();
        public List<Product> GetProducts()
        {
            SqlConnection conn = _db.GetConnectionstring();
            List<Product> products = new List<Product>();
            string stament = "SELECT ProductID,ProductName,Quantity from Products";
            SqlCommand cmd = new SqlCommand(stament, conn);
            conn.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    Product product = new Product
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        Quantity = reader.GetInt32(2)
                    };
                    products.Add(product);


                }
            }
            conn.Close();
            return products;
        }
    }
}
