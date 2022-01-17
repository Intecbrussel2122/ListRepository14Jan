using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepository.Models
{
    public class ProductBase:CommonBase, IComparable<ProductBase>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string GetIdAndName
        {
            get 
            { 
                return Id + Name;
            }
        }

        public ProductBase(int id, string name, decimal price, string category)
        {
            Id = id;
            Name = name;
            Price = price;  
            Category = category;
        }

        public override string ToString()
        {
            return $"{Id,-10} {Name, -15} {Category, -15} {Price, 20}"; 
        }

        public override bool Equals(object obj)
        {
            var product = obj as Computer;
            if (product == null) // test if product is null
            {
                return false;
            }
            if (!(product is Computer))
            {
                return false;
            }
            //return this.Name == product.Name && this.Id == product.Id;
            return this.GetIdAndName == product.GetIdAndName;
        }

        public override int GetHashCode()
        {
            //return Id.GetHashCode() ^ Name.GetHashCode();
            return GetIdAndName.GetHashCode();
        }

        public int CompareTo(ProductBase other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
