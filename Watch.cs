using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Users_with_Objects
{
    public abstract class Watch
    { 
       string Brand { get; set; }
       string Model { get; set; }
       double Price { get; set; }

       public Watch(string brand, string model, double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

        public abstract void SetTime(DateTime time);

        public override string ToString()
        {
            return $"{Brand} {Model} (${Price})";
        }
    }
}
