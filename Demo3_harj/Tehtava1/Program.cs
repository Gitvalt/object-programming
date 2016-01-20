using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class kiuas
    {
        private bool onoff;
        private int kosteus;
        private double lampo;

        public kiuas(bool onoff, int kosteus, double lampo){
            this.onoff = onoff;
            this.kosteus = kosteus;
            this.lampo = lampo;
            }


        public void Printstatus()
        {
            Console.WriteLine("Onko paalla: " + onoff);
            Console.WriteLine("Lampotila: " + lampo + "°C");
            Console.WriteLine("Kosteus: " + kosteus);

        }

        public void lampotila()
        {
            Console.WriteLine("\nNykyinen lampotila on: " + lampo + "°C");
            Console.WriteLine("\nIlmoita uusi lampotila: ");
            int ulampo = int.Parse(Console.ReadLine());
            lampo = ulampo;
            Console.WriteLine("\nUusi lampotila on: " + lampo + "°C\n");


        }

        public void kostaeustila()
        {
            Console.WriteLine("\nNykyinen kosteus on: " + kosteus);
            Console.WriteLine("\nIlmoita uusi kosteus: ");
            int ukosteus = int.Parse(Console.ReadLine());
            kosteus = ukosteus;
            Console.WriteLine("\nUusi ilmankosteus on: " + kosteus + "\n");

        }

        public void virtakytkin()
        {
            if(onoff == true)
            {
                onoff = false;
            }
            else
            {
                onoff = true;
            }


        }

    }

    

    class Program
    {
        static void Main(string[] args)
        {
            kiuas KT1 = new kiuas(true, 30, 40);
            bool lopeta = false;
            do
            {
                Console.WriteLine("Nykyinen kiuas on: ");
                KT1.Printstatus();
                Console.WriteLine("\nJos haluat muuttaa lampotilaa paina 1\nJos haluat muuttaa kosteutta paina 2\nJos haluat sammuttaa kiukaan paina 3\nJos haluat lopettaa paina 0");
                int komento = int.Parse(Console.ReadLine());
                /*
                if (komento == 3)
                {
                    KT1.virtakytkin();
                }
                if (komento == 1)
                {
                    KT1.lampotila();
                }
                if (komento == 0)
                {
                    lopeta = true;
                }
                */
                switch (komento)
                {
                    case 3:
                        KT1.virtakytkin();
                        break;
                    case 1:
                        KT1.lampotila();
                        break;
                    case 0:
                        lopeta = true;
                        break;
                    case 2:
                        KT1.kostaeustila();
                        break;
                }


            } while (lopeta != true);
            Console.WriteLine("Ohjelma lopetetaan");
            Console.ReadLine();
        }
    }
}
