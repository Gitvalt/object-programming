using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat
{
    abstract class Human : IMammal
    {

        public float Weight { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        
        /*
        override public void Move(int amount)
        {
            Console.WriteLine("Mammal" + " is moving " + amount + " steps");
        }
    */
        override public void GetOlder()
        {
            Age++;
            Console.WriteLine("Human is " + Age + " years old.");
        }
    }
}
