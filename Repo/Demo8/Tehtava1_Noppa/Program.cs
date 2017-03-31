using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1_Noppa
{
    class Program
    {
        static void Printspace()
        {
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Dice noppa = new Dice();
            Console.WriteLine("Throwing dice...");
            noppa.ThrowDice();
            Console.WriteLine("Result was: " + noppa.result);


            Printspace();
            bool jatka = true;


            do
            {
                Console.WriteLine("Select how many numbers of throws do you want to make:");
                try
                {
                    int throw_count = int.Parse(Console.ReadLine());


                    for (int i = 0; i < throw_count; i++)
                    {
                        noppa.ThrowDice();
                        
                    }

                    Console.WriteLine("Dice has been thrown " + throw_count + " times, average is {0:F}", noppa.memory.Average());


                    int count;
                    for (int i = 0; i < 7; i++)
                    {
                        count = noppa.memory.Where(x => x.Equals(i)).Count();
                        Console.WriteLine("-\t" + i + " Count is " + count);
                    }

                    jatka = false;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Has to be a number!!!\n");
                    
                }


                
            } while (jatka == true);
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
