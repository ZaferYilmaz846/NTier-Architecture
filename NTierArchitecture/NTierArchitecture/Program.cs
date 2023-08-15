using BusinessLayer;
using DataAccessLayer.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductBL pl = new ProductBL();
            var products = pl.GetProducts();
            if (products != null)
            {
                Console.WriteLine(products.Count + " adet ürün vardır...");
                Console.WriteLine("-----------------------------------");
                foreach (var item in products)
                {
                    Console.WriteLine(item.ProductID + ". " + item.ProductName);
                }
            }
            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.WriteLine("=========================================");

            CategoryBL cl = new CategoryBL();
            var categories = cl.GetCategories();
            if (categories != null)
            {
                Console.WriteLine(categories.Count + " adet kategori vardır...");
                Console.WriteLine("------------------------------------");
                foreach (var item in categories)
                {
                    Console.WriteLine(item.CategoryID + ". " + item.CategoryName);
                }
            }
            Console.ReadKey();
        }
    }
}
