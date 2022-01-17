using ListRepository.Database;
using ListRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ListRepository.Models
{
    public class TelephoneManager : IRepository
    {
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

        public List<ProductBase> SelectAll()
        {
            return Data.ProductList;
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

        public void ShowTelephones()
        {
            Console.WriteLine("List of Telephones in the stock");
            Console.WriteLine();

            foreach (var item in SelectAll().OfType<Telephone>())
            {
                Console.WriteLine(item);
            }

            foreach (var item in SelectAll())
            {
                if (item is Telephone && item.Name == "Galaxy")
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
