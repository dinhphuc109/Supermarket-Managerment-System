using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserCases.DateStorePluginInterFace
{
    public interface ICategoryRespository
    {
        IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        Category GetCategoryById(int categoryId);
        void DeleteCategory(int categoryId);
    }
}
