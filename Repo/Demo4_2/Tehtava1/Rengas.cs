using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class Rengas
    {
        public string model { get; set; }
        public string type { get; set; }
        public string tire_size { get; set; }

        public Rengas(string Model, string Type, string Tire_size)
        {
            Model = model;
            Type = type;
            Tire_size = tire_size;
        }

        public override string ToString()
        {
            return "Tire: " + model + ", " + type + ", " + tire_size;
         }
    }
}
