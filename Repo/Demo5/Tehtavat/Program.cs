using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat
{
    class Program
    {
        static void Main(string[] args)
        {

            IMammal mammal = new Adult();
            mammal.Move(10);

            Baby Man = new Baby();
            Man.Move(3);
            
            /* Count age from 0 to 50
            for (int i = 0; i<50; i++)
            {
                Man.GetOlder();
            }
            */

            Console.ReadLine();
        }
    }
}
