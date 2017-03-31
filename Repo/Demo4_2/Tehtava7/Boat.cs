using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7
{
    class Boat : Vehicle
    {

        public string motor { get; set; }
        public string fuel { get; set; }

        public Boat()
        {

        }

        public Boat(string Name, string Model, string Publisher, float Price, string Motor, string Fuel)
            : base(Name, Model, Publisher, Price)
        {
            motor = Motor;
            fuel = Fuel;
        }

        public override string ToString()
        {
            return base.ToString() + ", Motor: " + motor + ", Fuel: " + fuel;
        }
    }
}
