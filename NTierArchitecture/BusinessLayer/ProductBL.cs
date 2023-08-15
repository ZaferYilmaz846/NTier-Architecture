using DataAccessLayer.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BusinessLayer
{
    public class ProductBL
    {
        public List<Product> GetProducts()
        {
            ProductRepository pr = new ProductRepository();
            var products = pr.GetProducts();
            return products;
        }
    }
}
