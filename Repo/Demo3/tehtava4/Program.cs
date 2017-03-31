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

        public void Muutatieto()
        {
            bool jatka = true;

            do
            {
                Console.WriteLine("1. Muuta nimi\n2. Muuta nopeus\n3. Muuta rengas tyyppi\n4. lopeta muuttaminen");
                int input2 = int.Parse(Console.ReadLine());
                switch (input2)
                {
                    case 1:
                        Console.WriteLine("Uusi nimi: ");
                        string unimi = Console.ReadLine();
                        name = unimi;
                        Console.WriteLine("Nimi on nyt: " + name);
                        break;
                    case 2:
                        Console.WriteLine("Uusi nopeus: ");
                        int unopeus = int.Parse(Console.ReadLine());
                        speed = unopeus;
                        Console.WriteLine("Nopeus on nyt: " + speed);
                        break;
                    case 3:
                        Console.WriteLine("Uusi rengas tyyppi: ");
                        int utyyppi = int.Parse(Console.ReadLine());
                        tyres = utyyppi;
                        Console.WriteLine("Rengas tyyppi on nyt: " + tyres);
                        break;
                    case 4:
                        jatka = false;
                        break;
                }
            } while (jatka == true);
            
        }

        public override string ToString()
        {
            return base.ToString() + ": " + "Nimi: " + name.ToString() + " Nopeus: " + speed.ToString() + " Renkaat: " + tyres.ToString();
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

            bool TT = false;
            /*
            Console.WriteLine("Kirjoita uuden ajoneuvon ominaisuudet: \nnimi: ");
            string inputnim = Console.ReadLine();

            bool nimi = String.IsNullOrEmpty(inputnim);*/
            bool tester1 = true;

            Console.WriteLine("Kirjoita uuden ajoneuvon ominaisuudet: \nNimi: ");
            string inputnim = Console.ReadLine();
            bool nimi = String.IsNullOrEmpty(inputnim);
            if (nimi)
            {
                do
                {
                    Console.WriteLine("Kirjoita uuden ajoneuvon ominaisuudet: \nNimi: ");
                    inputnim = Console.ReadLine();
                    nimi = String.IsNullOrEmpty(inputnim);

                    if (nimi == false)
                    {
                        Console.WriteLine("Nimi on: " + inputnim + "\n");
                        tester1 = false;
                    }


                } while (tester1 == true);
            }
            

            Console.WriteLine("\nNopeus: ");
            int inputnopeus = int.Parse(Console.ReadLine());
            

            Console.WriteLine("\nRengas tyyppi: ");
            int inputrengas = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            vehicle vh1 = new vehicle(inputnim, inputnopeus, inputrengas);


            do
            {
                
                Console.WriteLine("0. Lopeta ohjelma\n1. Tulosta vehicle ominaisuudet\n2. Merkkijonon tulostus\n3. Tietojen muuttaminen");
                int input = int.Parse(Console.ReadLine());

                switch (input) {
                    case 0:
                    TT = true;
                    break;
                    case 1:
                    vh1.PrintData();
                        
                    break;
                    case 2:
                        Console.WriteLine(vh1.ToString());
                    break;

                    case 3:
                        vh1.Muutatieto();
                        break;

                }
                
            } while (TT != true);
            Console.WriteLine("Ohjelma lopetetaan");

            Console.ReadLine();


        }
    }
}
