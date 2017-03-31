using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            radio travel_radio = new radio();

            travel_radio.onoff = true;
            travel_radio.volume = 2;
            travel_radio.radio_freq = 20000.45f;

            Console.WriteLine(travel_radio.printdata());
            Console.WriteLine("\n");
            bool cont = true;

            do
            {
                Console.WriteLine("1. Print current status\n2. Change status\n3. End program");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine(travel_radio.printdata());
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        travel_radio.ChangeData();
                        break;
                    case 3:
                        Console.WriteLine("Ending program");
                        cont = false;
                        break;
                }

            } while (cont == true);


            //printdata prints radio's current status
            //change_data changes radio's status

            Console.ReadLine();
        }
    }
}
