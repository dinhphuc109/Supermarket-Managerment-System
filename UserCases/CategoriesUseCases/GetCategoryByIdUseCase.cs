using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace UserCases
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRespository categoryRespository;

        public GetCategoryByIdUseCase(ICategoryRespository categoryRespository)
        {
            this.categoryRespository = categoryRespository;
        }
        public Category Execute(int categoryId)
        {
            return categoryRespository.GetCategoryById(categoryId);
        }
    }
}
