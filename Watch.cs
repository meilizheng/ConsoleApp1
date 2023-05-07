using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Users_with_Objects
{
    abstract class Watch
    { 
            public string Brand { get; set; }
            public string Model { get; set; }
            public double Price { get; set; }

            public Watch(string brand, string model, double price)
            {
                Brand = brand;
                Model = model;
                Price = price;
            }

            public override string ToString()
            {
                return $"{Brand} {Model} (${Price})";
            }
        }
}
