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
        public List<ProductBase> SelectAll()
        {
            return Data.ProductList;
        }
    }
}
