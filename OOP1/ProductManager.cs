﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName+"  eklendi  "+product.CategoryId+" eklendi "+product.UnitPrice+
                " eklendi ");
        }
    }
}