using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7
{
    class Car : Vehicle
    {
        public string motor { get; set; }
        public string tire_type { get; set; }
        public string fuel { get; set; }

        public Car()
        {

        }

        public Car(string Name, string Model, string Producer, float Price, string Motor, string Tire_type, string Fuel)
            : base(Name, Model, Producer, Price)
        {
            motor = Motor;
            tire_type = Tire_type;
            fuel = Fuel;
        }

        public override string ToString()
        {
            return base.ToString() + ", Motor: " + motor + ", Tire type: " + tire_type + ", Fuel: " + fuel;
        }

    }

}
