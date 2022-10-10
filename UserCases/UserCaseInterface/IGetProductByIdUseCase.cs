using CoreBusiness;

namespace UserCases
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}