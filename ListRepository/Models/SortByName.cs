using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepository.Models
{
    public class SortByName : IComparer<ProductBase>
    {
        public int Compare(ProductBase x, ProductBase y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
