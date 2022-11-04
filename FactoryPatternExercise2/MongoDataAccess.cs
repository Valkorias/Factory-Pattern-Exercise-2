using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
              
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from the Mongo database.");
            return Product.Products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to the Mongo database...");
        }
    }
}
