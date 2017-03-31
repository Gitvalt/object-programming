using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7
{
    class Motorcycle : Vehicle
    {
        public string motor { get; set; }
        public string tire_type { get; set; }
        public string fuel { get; set; }

        public Motorcycle()
        {

        }

        public Motorcycle(string Name, string Model, string Publisher, float Price, string Motor, string Tire_type, string Fuel)
            : base(Name, Model, Publisher, Price)
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
