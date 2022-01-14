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
            ComputerManager cm = new ComputerManager();
            var resultAll = cm.SelectAll();
            Show(resultAll, "All data from the database");

            //Add new record to the database/collection
            ProductBase p0 = new ProductBase(12, "IBM", 900.00m, "Laptop");
            cm.Insert(p0);

            if (resultAll == null)
            {
                resultAll = cm.SelectAll();
            }
            else
            {
                Show(resultAll,"Data in the database after a new record inserted");
            }

            // find product in the database/collection
            Console.WriteLine("Find a product in the database/collection");
            Console.WriteLine();
            var findProduct = cm.Find(3);
            if (findProduct)
            {
                Console.WriteLine("Product found");
            }
            else
            {
                Console.WriteLine("Product not found");
            }

            // get product by caategory
            //var findByCategory = cm.GetAllByCategory("Desktop");
            var findByCategory = cm.GetAllByCategory("Laptop");
            Show(findByCategory, "Products listed by category");

            // Get single record from de database/collection
            Console.WriteLine("single record in the database");
            Console.WriteLine();
            var singleRecord = cm.SelectSingle(3);
            Console.WriteLine("Single record");
            Console.WriteLine(singleRecord);

            //delete record in the database/collection
            cm.Delete(4);
            Show(resultAll, "After the record was deleted");
            Console.WriteLine();


            // Add record if id and name are same
            ProductBase p1 = new ProductBase(3, "HP1", 600.00m, "Laptop");
            ProductBase p2 = new ProductBase(3, "HP1", 600.00m, "Laptop");
            Console.WriteLine("Test with ==");
            Console.WriteLine(p1==p2);

            Console.WriteLine("Test with Equals");
            var equal = p1.Equals(p2);
            Console.WriteLine(equal);


            // get list in a variable sort
            var sort = cm.SelectAll();

            sort.Sort(); // sort the list by price
            Show(sort, "Sorted by price list");

            sort.Sort(new SortByName());
            Show(sort, "Sorted by name list");

        }

        public static void Show(List<ProductBase> resultAll, string argument )
        {
            Console.WriteLine(argument);
            Console.WriteLine(new string('_',50));
            foreach (var item in resultAll)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        
    }
}
