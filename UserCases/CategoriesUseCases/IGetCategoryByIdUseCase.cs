using CoreBusiness;

namespace UserCases
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}