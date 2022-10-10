using System;
using System.Collections.Generic;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace UserCases
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRespository categoryRespository;

        public DeleteCategoryUseCase(ICategoryRespository categoryRespository)
        {
            this.categoryRespository = categoryRespository;
        }
        public void Delete(int categoryId)
        {
            categoryRespository.DeleteCategory(categoryId);
        }
    }
}
