using CoreBusiness;
using System.Collections.Generic;

namespace UserCases
{
    public interface IViewProductsByCategoryId
    {
        IEnumerable<Product> Execute(int categoryId);
    }
}