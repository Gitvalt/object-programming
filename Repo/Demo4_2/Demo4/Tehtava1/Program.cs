using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi elevator = new Hissi();

            bool cont = false;
            Console.WriteLine("Current floor >> " + elevator.Nfloor);
            do
            {
                
                Console.WriteLine("Enter new floor(1-5, 0 for exit elevator): ");
                int new_floor = int.Parse(Console.ReadLine());

                if (new_floor == 0)
                {
                    Console.WriteLine("Leaving elevator...");
                    cont = true;
                }
                else {

                    elevator.Nfloor = new_floor;

                //    if(new_floor > elevator.nfloor)

                    Console.WriteLine("Current floor >> " + elevator.Nfloor);
                 
                

            }

            } while (cont == false);

            Console.ReadLine();
        }
    }
}
