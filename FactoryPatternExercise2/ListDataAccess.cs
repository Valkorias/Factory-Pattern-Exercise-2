﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {

        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from your List");
            return Product.Products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving your data...");
        }
    }
}
