using System;
using System.Collections.Generic;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace UserCases
{
    public class RecordTransactionUseCase : IRecordTransactionUseCase
    {
        private readonly ITransactionRepository transactionRepository;
        private readonly IGetProductByIdUseCase getProductByIdUseCase;

        public RecordTransactionUseCase(
            ITransactionRepository transactionRepository,
            IGetProductByIdUseCase getProductByIdUseCase)
        {
            this.transactionRepository = transactionRepository;
            this.getProductByIdUseCase = getProductByIdUseCase;
        }
        public void Execute(string casherName, int productId, int qty)
        {
            var product = getProductByIdUseCase.Execute(productId);
            transactionRepository.Save(casherName, productId,product.Name, product.Price.Value, product.Quantity.Value, qty);
        }
    }
}
