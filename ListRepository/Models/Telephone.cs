using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepository.Models
{
    public class Telephone:ProductBase
    {
        public Telephone(int id, string name, decimal price, string category):base(id,name,price,category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

    }
}
