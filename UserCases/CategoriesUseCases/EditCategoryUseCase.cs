using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace UserCases
{
    public class EditCategoryUseCase : IEditCategoryUseCase
    {
        private readonly ICategoryRespository categoryRespository;

        public EditCategoryUseCase(ICategoryRespository categoryRespository)
        {
            this.categoryRespository = categoryRespository;
        }
        public void Execute(Category category)
        {
            categoryRespository.UpdateCategory(category);
        }
    }
}
