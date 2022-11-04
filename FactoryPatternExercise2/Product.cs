using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "Pogo Stick", Price = 25.00},
            new Product() {Name = "Skateboard", Price = 35.00},
            new Product() {Name = "Slinky", Price = 5.00}
        };
    }
}
