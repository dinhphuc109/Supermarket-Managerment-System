using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserCases.DateStorePluginInterFace;

namespace Plugin.DateStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;
        public ProductInMemoryRepository()
        {
            //init with default value

            products = new List<Product>()
            {
                new Product{ProductId=1, CategoryId=1, Name="mell", Quantity=100, Price=1.99},
                new Product{ProductId=2, CategoryId=2, Name="meat", Quantity=200, Price=1.99},
                new Product{ProductId=3, CategoryId=3, Name="Mona", Quantity=30, Price=1.99},
            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }

            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            var ProductToUpdate = GetProductById(product.ProductId);
            if (ProductToUpdate != null)
            {
                ProductToUpdate.Name = product.Name;
                ProductToUpdate.CategoryId = product.CategoryId;
                ProductToUpdate.Price = product.Price;
                ProductToUpdate.Quantity = product.Quantity;
            }
        }

        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(x=>x.ProductId==productId);
        }

        public void DeleteProduct(int productId)
        {
            var productToDelete = GetProductById(productId);
            if (productToDelete != null) products.Remove(productToDelete);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return products.Where(x => x.CategoryId == categoryId);
        }
    }
}
