﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepository.Models
{
    public class ProductBasteDTO
    {
        public string IdNameCategory { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{IdNameCategory} {Price}";
        }
    }
}
