using CoreBusiness;
using System.Collections.Generic;

namespace UserCases
{
    public interface IViewProductUseCase
    {
        IEnumerable<Product> Execute();
    }
}