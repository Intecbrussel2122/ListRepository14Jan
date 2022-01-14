﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepository.Models
{
    public class Computer:ProductBase
    {
        public string Meassure { get; set; }

        public Computer(int id, string name, decimal price, string category, string meassure = "piece"):base(id, name,price,category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
            Meassure = meassure;
        }
    }
}
