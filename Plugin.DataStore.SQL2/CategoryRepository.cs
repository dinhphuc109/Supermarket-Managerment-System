using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace Plugin.DataStore.SQL2
{
    public class CategoryRepository : ICategoryRespository
    {
        private readonly MarketContext db;

        public CategoryRepository(MarketContext db)
        {
            this.db = db;
        }
        public void AddCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = db.Categories.Find(categoryId);
            if (category == null) return;

            db.Categories.Remove(category);
            db.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return db.Categories.Find(categoryId);
        }

        public void UpdateCategory(Category category)
        {
            var cat = db.Categories.Find(category.CategoryID);
            cat.Name = category.Name;
            cat.Description = category.Description;
            db.SaveChanges();
        }
    }
}
