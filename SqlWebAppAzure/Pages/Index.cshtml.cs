using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SqlWebAppAzure.Models;
using SqlWebAppAzure.ProductService;

namespace SqlWebAppAzure.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IProductServices _productServices;
        public IndexModel(IProductServices productService)
        {
            _productServices = productService;
        }
        public List<Product> prodcut;
        public void OnGet()
        {
           
            prodcut = _productServices.GetProducts();

        }
    }
}
