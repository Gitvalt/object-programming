using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava4
{
    class vehicle
    {
        public vehicle(string name, int speed, int tyres)
        {
            this.name = name;
            this.speed = speed;
            this.tyres = tyres;
        }

        public void PrintData()
        {
            Console.WriteLine("Nimi: " + name);
            Console.WriteLine("Nopeus: " + speed);
            Console.WriteLine("Renkaat: " + tyres);

        }

        public void ToString()
        {
            string yht = name + " " + speed + " " + tyres;
            Console.WriteLine(yht);
        }

        private string name;
        private int speed;
        private int tyres;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*vehicle vh1 = new vehicle("Scoda GT", 200, 14);
            vh1.PrintData();
            Console.WriteLine("\n");
            vh1.ToString();
            */
            Console.WriteLine("Kirjoita uuden ajoneuvon ominaisuudet: \nnimi: ");
            string inputnim = Console.ReadLine();

            Console.WriteLine("Nopeus: ");
            int inputnopeus = int.Parse(Console.ReadLine());

            Console.WriteLine("Rengas tyyppi: ");
            int inputrengas = int.Parse(Console.ReadLine());

            vehicle vh1 = new vehicle(inputnim, inputnopeus, inputrengas);
            vh1.PrintData();
            vh1.ToString();

            Console.ReadLine();


        }
    }
}
