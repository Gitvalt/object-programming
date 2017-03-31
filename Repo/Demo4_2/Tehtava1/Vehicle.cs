using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void RemoveTyres()
        {
            rengas.Clear();
        }

        public void AddTyre(Rengas t)
        {
            rengas.Add(t);
        }


        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;

            rengas = new List<Rengas>();

            AddTyre(new Rengas("Michelin", "X-Ice", "225/48r45"));
            AddTyre(new Rengas("Michelin", "X-Ice", "225/48r45"));
            AddTyre(new Rengas("Michelin", "X-Ice", "225/48r45"));
            AddTyre(new Rengas("Michelin", "X-Ice", "225/48r45"));
            AddTyre(new Rengas("Michelin", "X-Ice", "225/48r45"));
        }

        public override string ToString()
        {
            string s = "Vehicle: " + Brand + ", " + Model;

            foreach(Rengas t in rengas)
            {
                s += "\n";
                s += t.ToString();
            }
            return s;
        }

        private List<Rengas> rengas;

    }
}
