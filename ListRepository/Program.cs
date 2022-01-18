using ListRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get All records from the database/collection
           
            Helper helper = new Helper();
            IEnumerable<ProductBase> resultAll = helper.SelectAll();
            Show(resultAll, "All data from the database");

            Computer productBase = new Computer(50, "Sony", 560.00m, "Laptop");
            helper.AddProduct(productBase);

            Show(resultAll, "All data from the database after new computer added");

            helper.SortByPrice();
            Show(resultAll, "All data from the database after sort by price");

            helper.SortByName();
            Show(resultAll, "All data from the database after sort by name");
            Console.WriteLine();
            decimal total = helper.GetTotal();
            Console.WriteLine($"The total sum is: {total}");

            ProductBase mostExpensiveProduct = helper.FindTopExpensiveProduct();
            Console.WriteLine($"Most expensive product : product name {mostExpensiveProduct.Name} price {mostExpensiveProduct.Price}");

            helper.ShowComputers();
        }

        //IEnumarable = for read only collections, it's forward only collection
        public static void Show(IEnumerable<ProductBase> resultAll, string argument )
        {
            
            Console.WriteLine(argument);
            Console.WriteLine(new string('_',50));
           
            foreach (var item in resultAll)
            {
                    Console.WriteLine(item);
            }
        }

        
    }
}
