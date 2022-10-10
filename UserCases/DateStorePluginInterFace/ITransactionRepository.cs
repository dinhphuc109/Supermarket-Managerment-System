using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserCases.DateStorePluginInterFace
{
    public interface ITransactionRepository
    {
        public IEnumerable<Transaction> Get(string cashierName);
        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date);
        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate);
        public void Save(string casherName, int productId, string productName, double price,int beforeQty, int soldQty);
    }
}
