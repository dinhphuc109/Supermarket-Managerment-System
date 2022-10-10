using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBusiness
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int BeforeQty { get; set; }
        public int SoldQty { get; set; }
        public string CasherName { get; set; }
    }
}
