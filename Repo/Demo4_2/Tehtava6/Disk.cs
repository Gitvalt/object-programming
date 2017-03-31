using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6
{
    class Disk:Product
    {
        public int memory { get; set; }

        public Disk()
        {

        }

        public Disk(string name, string type, int Memory)
            :base (name, type)
        {
            memory = Memory;
        }

        public override string ToString()
        {
            return base.ToString() + ", Memory: " + memory + "GB";
        }

    }
}
