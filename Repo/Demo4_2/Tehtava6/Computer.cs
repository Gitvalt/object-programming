using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6
{
    class Computer : Product
    {
        public int memory { get; set; }
        public string proceccor { get; set; }
        public string producer { get; set; }

        public Computer()
        {

        }

        public Computer(string name, string type, int Memory, string Proceccor, string Producer)
            :base(name, type)
        {
            memory = Memory;
            proceccor = Proceccor;
            producer = Producer;
        }

        public override string ToString()
        {
            return base.ToString() + ", Memory: " + memory + "GB, Proceccor: " + proceccor + ", Producer: " + producer;
        }
    }
}
