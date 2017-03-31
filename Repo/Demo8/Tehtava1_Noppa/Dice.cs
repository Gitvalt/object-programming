using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1_Noppa
{
    class Dice
    {
        public int number { get; set; }

        public List<int> memory = new List<int>();
        public Random rnd = new Random();
        public int result { get; set; }

        public void ThrowDice()
        {

            result = rnd.Next(0, 7);
            memory.Add(result);
         
        }
    }
}
