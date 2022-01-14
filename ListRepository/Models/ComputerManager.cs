using ListRepository.Database;
using ListRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepository.Models
{
    public class ComputerManager : IRepository
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

        public List<ProductBase> SelectAll()
        {
            return Data.ProductList;
        }

        public void Update(ProductBase product)
        {
            ProductBase updateProduct = Data.ProductList[product.Id];
            //updateProduct.Id = product.Id; // Nooit updaten
            updateProduct.Name = product.Name;
            updateProduct.Price = product.Price;
            updateProduct.Category = product.Category;
            updateProduct.DateUpdated = DateTime.Now;
        }

        public List<ProductBase> GetAllByCategory(string category)
        {
            // using simple foreach
            #region Search wuth foreach
            //var result = SelectAll(); // alle data ziet hier
            //var list = new List<ProductBase>(); // list voor een bepaalde category
            //foreach (var item in result)
            //{
            //    if (item.Category == category)
            //    {
            //        list.Add(new Computer(item.Id, item.Name, item.Price, item.Category));
            //    }
            //}
            //return list;
            #endregion

            #region First way Lambda
            //var result = SelectAll().FindAll(p => p.Category == category);
            //return result;

            #endregion

            #region with lambda
            var result = SelectAll();
            return result.FindAll(f => f.Category == category);
            #endregion
        }

        public List<string> GetPartOfProductAsString(int subLength)
        {
            var result = SelectAll();
            var list = new List<string>();
            string name = string.Empty;
            string category = string.Empty;

            for (int i = 0; i < result.Count; i++)
            {
                name = result[i].Name.Substring(0, subLength).ToUpper();
              
                category = result[i].Category.Substring(0, subLength).ToUpper();

                list.Add(result[i].Id.ToString()+ name+ category + "\t\t" + result[i].Price.ToString());
            }
            return list;
        }

        public List<ProductBasteDTO> GetPartOfProductDTO()
        {
            var resultAll = SelectAll();
            var list = new List<ProductBasteDTO>();
            for (int i = 0;i < resultAll.Count;i++)
            {
                // use ternary operator
                string id = resultAll[i].Id.ToString();
                string name = resultAll[i].Name.Length > 2 ? resultAll[i].Name.Substring(0,3).ToUpper(): resultAll[i].Name.Substring(0,2).ToUpper() + " ";
                string category = resultAll[i].Category.Length > 2 ? resultAll[i].Category.Substring(0, 3).ToUpper() : resultAll[i].Category.Substring(0, 2).ToUpper() + " ";
                decimal price = resultAll[i].Price;
                string idnamecategory = id + name + category;

                var productBaseDTO = new ProductBasteDTO()
                {
                    IdNameCategory = idnamecategory,
                    Price = price,
                };
                list.Add(productBaseDTO);
            }
            return list;
        }

        public void ShowTelephones()
        {
            Console.WriteLine("List of Computers in the stock");
            Console.WriteLine();

            foreach (var item in SelectAll().OfType<Computer>())
            {
                Console.WriteLine(item);
            }

            //foreach (var item in SelectAll())
            //{
            //    if (item is Computer)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
        }
    }
}
