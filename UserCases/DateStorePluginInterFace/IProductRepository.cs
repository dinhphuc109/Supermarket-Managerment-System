using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserCases.DateStorePluginInterFace
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProductById(int productId);
        void DeleteProduct(int productId);
        IEnumerable<Product> GetProductsByCategoryId(int categoryId);
    }
}
