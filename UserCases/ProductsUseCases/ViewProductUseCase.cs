using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace UserCases
{
    public class ViewProductUseCase : IViewProductUseCase
    {
        private readonly IProductRepository productRepository;

        public ViewProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IEnumerable<Product> Execute()
        {
            return productRepository.GetProducts();
        }
    }
}
