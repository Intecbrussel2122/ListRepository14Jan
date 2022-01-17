using ListRepository.Database;
using ListRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepository.Models
{
    public class TV:ProductBase, IRepository
    {
        public TV(int id, string name, decimal price, string category):base(id, name, price, category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

       
        public void Delete(int id)
        {
            Data.ProductList.RemoveAt(id - 1);
        }

        public bool Find(int find)
        {
            var result = Data.ProductList.Find(f => f.Id == find);
            if (result != null)
            {
                return true;
            }
            return false;
        }

        public void Insert(ProductBase product)
        {
            Data.ProductList.Add(product);
        }
        public ProductBase SelectSingle(int id)
        {
            try
            {
                ProductBase productToReturn = Data.ProductList[id - 1];
                return productToReturn;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(ProductBase product)
        {
            try
            {
                ProductBase updateProduct = SelectSingle(product.Id);
                if (updateProduct != null)
                {
                    //updateProduct.Id = product.Id;//NOOIt veranderen
                    updateProduct.Name = product.Name;
                    updateProduct.Price = product.Price;
                    updateProduct.Category = product.Category;
                    updateProduct.DateUpdated = DateTime.Now;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ShowTvs()
        {
            Console.WriteLine("List of Tv's in the stock");
            Console.WriteLine();

            foreach (var item in Data.ProductList.OfType<TV>())
            {
                Console.WriteLine(item);
            }

            foreach (var item in Data.ProductList)
            {
                if (item is TV && item.Name == "Sony")
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
