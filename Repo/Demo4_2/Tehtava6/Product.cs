using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6
{
    class Product { 

    public string name { get; set; }
    public string type { get; set; }

        public Product(string Name, string Type)
        {
            name = Name;
            type = Type;
        }

        public Product()
        {

        }
           public override string ToString()
        {
            return "Name: " + name + ", Type: " + type;
        }

    }
}
