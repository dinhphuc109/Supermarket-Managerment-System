using CoreBusiness;
using System.Collections.Generic;

namespace UserCases
{
    public interface IGetTodayTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
    }
}