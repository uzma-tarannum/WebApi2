using KnowledgeHubPortal.CategoryServiceRepo;
using KnowledgeHubPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net.Http.Headers;

namespace KnowledgeHubPortal.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Save(Category cat)
        {
            _categoryService.SaveCategory(cat);
            return View();
        }

        public IActionResult GetList(string searchText=null)
        {
            List<Category> result = null;
            if (searchText.Length >= 0 && searchText != null)
            {
               result= _categoryService.GetBySearch(searchText);
            }
            else
            {
                result =_categoryService.GetCategories().ToList();
            }
            return View(result);
        }
        public IActionResult Edit(int id)
        {
            var result = _categoryService.GetCategoryById(id);
            return View(result);
        }

        public IActionResult UpdateCategory(Category cat)
        {
            if (!ModelState.IsValid && cat == null)
            {
                return View("Edit");
            }
            _categoryService.Update(cat);
            return RedirectToAction("GetList");
        }


    }
}
