using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace UserCases
{
    public class ViewCategoriesUserCase : IViewCategoriesUserCase
    {
        private readonly ICategoryRespository categoryRespository;

        public ViewCategoriesUserCase(ICategoryRespository categoryRespository)
        {
            this.categoryRespository = categoryRespository;
        }
        public IEnumerable<Category> Execute()
        {
            return categoryRespository.GetCategories();
        }
    }
}
