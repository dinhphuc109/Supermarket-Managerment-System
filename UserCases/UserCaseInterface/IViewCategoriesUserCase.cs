using CoreBusiness;
using System.Collections.Generic;

namespace UserCases
{
    public interface IViewCategoriesUserCase
    {
        IEnumerable<Category> Execute();
    }
}