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
       //ComputerManager manager = new ComputerManager();
       TelephoneManager manager = new TelephoneManager();
       public void AddProduct(ProductBase product)
       {
            manager.Insert(product);
       }
       
        public void SortByName()
        {
          var getAll =  manager.SelectAll();
          getAll.Sort();
        }

        public List<ProductBase> SelectAll()
        {
            return manager.SelectAll();
        }
    }
}
