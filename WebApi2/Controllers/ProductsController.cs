using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi2.Model.DAL;
using WebApi2.Model.Entititees;

namespace WebApi2.Controllers
{


    [Route("api/[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {
        //private readonly IProductService _productService;
        //public ProductsController(IProductService productService)
        //{
        //    _productService = productService;
        //}

        private IProductService _productService = new ProductService();

        [HttpGet]
        [EnableQuery]
        public IQueryable<Product> Get()
        {
            var p = _productService.GetProducts().AsQueryable();
            return p;
        }
        [HttpPost]
        public void AddProduct(Product p)
        {
            _productService.AddProduct(p);
        }
        [HttpDelete]
        public void DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
        }

        //[HttpGet]
        //[Route("Brand/{brand}")]
        //public List<Product> GetProductsbyBrand(string brand)
        //{
        //    var p = _productService.GetProductBybrand(brand);
        //    return p.ToList();
        //}

        //[HttpGet]
        //[Route("categoy/{cat}")]
        //public List<Product> GetProductsbycategory(string cat)
        //{
        //    var p = _productService.GetProductByCategory(cat);
        //    return p.ToList();
        //}
        [HttpPut]
         
        public void PutProduct(Product p)
        {
            _productService.UpdateProduct(p);
        }

    }
}

