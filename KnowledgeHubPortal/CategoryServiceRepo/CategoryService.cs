using KnowledgeHubPortal.Data;
using KnowledgeHubPortal.Models;

namespace KnowledgeHubPortal.CategoryServiceRepo
{
    public class CategoryService : ICategoryService
    {
        KnowledgeHubDBContext _KnowledgeHubPortal = new();
        public void EditCategory(Category category)
        {
            _KnowledgeHubPortal.categories.Update(category);
            _KnowledgeHubPortal.SaveChanges();
        }

        public List<Category> GetBySearch(string search)
        {
            var result = from items in _KnowledgeHubPortal.categories
                         where items.CategoryName.Contains(search) || items.Description.Contains(search) select items;
            return result.ToList();
        }

        public List<Category> GetCategories()
        {
            var res= _KnowledgeHubPortal.categories.ToList();
            return res;

        }

        public Category GetCategoryById(int id)
        {
            var res = _KnowledgeHubPortal.categories.Find(id);
            return res;
        }

        public void SaveCategory(Category cat)
        {
            _KnowledgeHubPortal.categories.Add(cat);
            _KnowledgeHubPortal.SaveChanges();
        }

        public void Update(Category category)
        {
            _KnowledgeHubPortal.categories.Update(category);
            _KnowledgeHubPortal.SaveChanges();
        }
    }
}
