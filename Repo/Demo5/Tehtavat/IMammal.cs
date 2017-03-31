using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat
{
    abstract class IMammal
    {
        public int Age { get; set; }


        abstract public void Move(int amount);
        abstract public void GetOlder();
            /*
        {
            Console.WriteLine("Mammal is moving " + amount + "steps");
        }
        */
    }
}
