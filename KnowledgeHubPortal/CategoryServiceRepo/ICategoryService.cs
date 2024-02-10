using KnowledgeHubPortal.Models;

namespace KnowledgeHubPortal.CategoryServiceRepo
{
    public interface ICategoryService
    {
        void SaveCategory(Category cat);

        List<Category> GetCategories();

        void EditCategory(Category category); 
        
        void Update(Category category);

        Category GetCategoryById(int id);

        List<Category> GetBySearch(string search);


    }
}
