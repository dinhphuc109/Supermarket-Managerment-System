using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace UserCases
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductRepository productRepository;

        public AddProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Execute(Product product)
        {
            productRepository.AddProduct(product);
        }
    }
}
