using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UserCases.DateStorePluginInterFace;

namespace Plugin.DateStore.InMemory
{
    public class CategoryInMemoryRespository : ICategoryRespository
    {
        private List<Category> categories;
        public CategoryInMemoryRespository()
        {
            categories = new List<Category>()
            {
                new Category{CategoryID=1, Name="dnp", Description= "dnp"},
                new Category{CategoryID=2, Name="dnp2", Description= "dnp2"},
                new Category{CategoryID=3, Name="dnp3", Description= "dnp3"}
            };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            if(categories!=null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryID);
                category.CategoryID = maxId + 1;
            }
            else
            {
                category.CategoryID = 1;
            }
            
            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var CategoryToUpdate = GetCategoryById(category.CategoryID);
            if (CategoryToUpdate != null) 
            {
                CategoryToUpdate.Name = category.Name;
                CategoryToUpdate.Description = category.Description;
            } 
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryID == categoryId);
        }
        
        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }
    }
}
