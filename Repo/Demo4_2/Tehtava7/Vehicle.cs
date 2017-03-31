using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Producer { get; set; }
        public float Price { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string name, string model, string producer, float price)
        {
            Name = name;
            Model = model;
            Producer = producer;
            Price = price;

        }

        public override string ToString()
        {
            return "Name: " + Name + ", Model: " + Model + ", Producer: " + Producer + ", Price: " + Price;
        }

        

    }
}
