using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace Plugin.DataStore.SQL2
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MarketContext db;

        public TransactionRepository(MarketContext db)
        {
            this.db = db;
        }
        public IEnumerable<Transaction> Get(string cashierName)
        {
            return db.Transactions.ToList();
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return db.Transactions.Where(x => x.TimeStamp.Date == date.Date);
            else
                return db.Transactions.Where(x =>
                    EF.Functions.Like(x.CasherName, $"%{cashierName}%") &&
                    x.TimeStamp.Date == date.Date);
        }

        public void Save(string casherName, int productId, string productName, double price, int beforeQty, int soldQty)
        {
            var transaction = new Transaction
            {
                ProductId=productId,
                ProductName=productName,
                TimeStamp=DateTime.Now,
                Price=price,
                BeforeQty=beforeQty,
                SoldQty=soldQty,
                CasherName=casherName
            };

            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return db.Transactions.Where(x => x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
            else
                return db.Transactions.Where(x =>
                    EF.Functions.Like(x.CasherName, $"%{cashierName}%") &&
                    x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
        }
    }
}
