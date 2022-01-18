using ListRepository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepository.Models
{
    public class Helper
    {
        // hello kenan
        ComputerManager manager = new ComputerManager();
        //TelephoneManager manager = new TelephoneManager();
        public void AddProduct(ProductBase product)
       {
            manager.Insert(product);
       }
       
        public void SortByPrice()
        {
          var getAll =  manager.SelectAll();
          getAll.Sort();
        }

        public void SortByName()
        {
            var getAll = manager.SelectAll();
            getAll.Sort(new SortByName());
        }
        public List<ProductBase> SelectAll()
        {
            return manager.SelectAll();
        }

        public decimal GetTotal()
        {
            //var result = SelectAll();
            //decimal total = 0;
            //foreach (var item in result)
            //{
            //    total += item.Price;
            //}
            //return total;
            return SelectAll().Sum(x => x.Price);
        }

        public ProductBase FindTopExpensiveProduct()
        {
            //var result = SelectAll();
            //decimal mostExpensive = 0;
            //ProductBase MostExpensiveProduct = null;
            //foreach (var item in result)
            //{
            //    if (item.Price > mostExpensive)
            //    {
            //        mostExpensive = item.Price;
            //        MostExpensiveProduct = item;
            //    }
            //}
            //return MostExpensiveProduct;

            return manager.SelectAll().OrderByDescending(x => x.Price).FirstOrDefault();
        }

        public void ShowComputers()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The list of all computers");
            //var result = SelectAll();
            //foreach (var item in result)
            //{
            //    if (item is Computer )
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            var result = manager.SelectAll().Where(x => x is Computer).ToList();
            result.ForEach(x => Console.WriteLine(x));
        }
    }
}
