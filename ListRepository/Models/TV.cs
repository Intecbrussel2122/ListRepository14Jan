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
            throw new NotImplementedException();
        }

        public bool Find(int find)
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductBase product)
        {
            throw new NotImplementedException();
        }

        public List<ProductBase> SelectAll()
        {
            throw new NotImplementedException();
        }

        public ProductBase SelectSingle(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductBase product)
        {
            throw new NotImplementedException();
        }
    }
}
