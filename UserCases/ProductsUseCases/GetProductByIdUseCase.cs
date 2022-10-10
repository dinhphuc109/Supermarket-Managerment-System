using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace UserCases
{
    public class GetProductByIdUseCase : IGetProductByIdUseCase
    {
        private readonly IProductRepository productRepository;

        public GetProductByIdUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product Execute(int productId)
        {
            return productRepository.GetProductById(productId);
        }
    }
}
