using ListRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepository.Database
{
    public class Data
    {
        public static List<ProductBase> ProductList { get; set; }

        static Data()
        {
            ProductList = new List<ProductBase>();
            ProductBase p1 = new ProductBase(1, "Asus", 800.00m, "Laptop");
            ProductBase p2 = new ProductBase(2, "ThinkPad", 850.00m, "Laptop");
            ProductBase p3 = new ProductBase(3, "HP", 500.00m, "Desktop");
            ProductBase p4 = new ProductBase(4, "Daewoo", 450.00m, "Desktop");
            ProductBase p5 = new ProductBase(5, "Lenovo", 950.00m, "Laptop");

            ProductList.Add(p1);
            ProductList.Add(p2);
            ProductList.Add(p3);
            ProductList.Add(p4);
            ProductList.Add(p5);
        }
    }
}
