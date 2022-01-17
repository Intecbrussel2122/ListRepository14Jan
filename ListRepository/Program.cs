using ListRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get All records from the database/collection
           
            Helper helper = new Helper();
            IEnumerable<ProductBase> resultAll = helper.SelectAll();
            Show(resultAll, "All data from the database");

            TV tv2 = new TV(19, "Panasonic", 800.00m, "HD 4k");
            tv2.Insert(tv2);
            Show(resultAll, "All data after insert");

            TV tv3 = new TV();
            

        }

        //IEnumarable = for read only collections, it's forward only collection
        public static void Show(IEnumerable<ProductBase> resultAll, string argument )
        {
            
            Console.WriteLine(argument);
            Console.WriteLine(new string('_',50));
           
            foreach (var item in resultAll)
            {
                    Console.WriteLine(item);
            }
            //Console.WriteLine(resultAll.Count);
        }

        
    }
}
