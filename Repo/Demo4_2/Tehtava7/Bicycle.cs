using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7
{
    class Bicycle : Vehicle
    {
        public string tire_type { get; set; }
        public int gearing { get; set; }

        public Bicycle()
        {

        }

        public Bicycle(string Name, string Model, string Publisher, float Price, string Tire_type, int Gearing)
            : base(Name, Model, Publisher, Price)
        {
            tire_type = Tire_type;
            gearing = Gearing;

        }

        public override string ToString()
        {
            return base.ToString() + ", Tire type: " + tire_type + ", Number of gears: " + gearing;
        }

    }
}
