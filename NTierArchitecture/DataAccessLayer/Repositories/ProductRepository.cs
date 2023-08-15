using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public List<Product> GetProducts()
        {
            return GetAll();
        }
        public List<Product> GetProductByPrice(int minPrice, int maxPrice)
        {
            return GetAll(p => p.UnitPrice > minPrice && p.UnitPrice < maxPrice);
        }
        public List<Product> GetByCategory(int categoryId)
        {
            return GetAll(p => p.CategoryID == categoryId);
        }
        public Product GetByProductId(int productId)
        {
            return Get(p => p.ProductID == productId);
        }
    }
}
