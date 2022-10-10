using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace UserCases
{
    public class AddCategoryUseCase : IAddCategoryUseCase
    {
        private readonly ICategoryRespository categoryRespository;

        public AddCategoryUseCase(ICategoryRespository categoryRespository)
        {
            this.categoryRespository = categoryRespository;
        }

        public void Execute(Category category)
        {
            categoryRespository.AddCategory(category);
        }
    }
}
