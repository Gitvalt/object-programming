using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6
{
    

    class Kirja
    {
        public Kirja(int index, string knimi, string kirjailija, string Genre, int sivumaara, int valmvuosi)
        {
            this.index = index;
            this.knimi = knimi;
            this.kirjailija = kirjailija;
            this.Genre = Genre;
            this.sivumaara = sivumaara;
            this.valmvuosi = valmvuosi;
        }

        public int index = 0;
        public string knimi;
        public string kirjailija;
        public string Genre;
        public int sivumaara;
        public int valmvuosi;
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Kirja k1 = new Kirja(0, "Book1_2", "Aalto Testi", "Kauhu", 155, 1998);
            Kirja k2 = new Kirja(1, "Book1_3", "Aalto Testi", "Kauhu", 200, 2000);
            Kirja k3 = new Kirja(2, "BookX", "Matti Kirjailija", "Jannitys", 300, 2010);
            Kirja k4 = new Kirja(3, "Book1_4", "Aalto Testi", "Kauhu", 246, 2004);
            Kirja k5 = new Kirja(4, "BookT", "Matti Kirjailija", "Tietokirja", 347, 2012);



            string[,] kirjakaappi = new string[5, 6] {
            { Convert.ToString(k1.index), k1.knimi, k1.kirjailija, k1.Genre, Convert.ToString(k1.sivumaara), Convert.ToString(k1.valmvuosi)},
            { Convert.ToString(k2.index), k2.knimi, k2.kirjailija, k2.Genre, Convert.ToString(k2.sivumaara), Convert.ToString(k2.valmvuosi)},
            { Convert.ToString(k3.index), k3.knimi, k3.kirjailija, k3.Genre, Convert.ToString(k3.sivumaara), Convert.ToString(k3.valmvuosi)},
            { Convert.ToString(k4.index), k4.knimi, k4.kirjailija, k4.Genre, Convert.ToString(k4.sivumaara), Convert.ToString(k4.valmvuosi)},
            { Convert.ToString(k5.index), k5.knimi, k5.kirjailija, k5.Genre, Convert.ToString(k5.sivumaara), Convert.ToString(k5.valmvuosi)},
            };
                
            

            bool endprogram = false;

            do
            {
                Console.WriteLine("1. Katso kirjakaapin sisalto\n2. Lisaa uusi kirja\n3. Muuta kirjan tietoja\n4. Lopeta ohjelma");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        int count = 0;
                        foreach (string l in kirjakaappi)
                        {
                            Console.WriteLine(l);
                            count++;

                            if (count == 6)
                            {
                                Console.WriteLine("\n");
                                count = 0;
                            }

                        }

                        break;
                    case 2:
                        string uindex = Convert.ToString(kirjakaappi.GetLength(1) + 1);
                        Console.WriteLine("Uuden kirjan nimi: ");
                        string nname = Console.ReadLine();

                        Console.WriteLine("Uuden kirjan kirjailija: ");
                        string nkirjailija = Console.ReadLine();

                        Console.WriteLine("Uuden kirjan Genre: ");
                        string nGenre = Console.ReadLine();

                        Console.WriteLine("Uuden kirjan sivumaara: ");
                        string nsivumaara = Console.ReadLine();

                        Console.WriteLine("Uuden kirjan valmistusvuosi: ");
                        string nvalmis = Console.ReadLine();

                        Console.WriteLine(uindex + nname + nkirjailija + nGenre + nsivumaara + nvalmis);

                        Kirja  new_name[uindex] = ;


                        break;
                    case 3:

                        break;
                    case 4:
                        Console.WriteLine("Ohjelma lopetetaan");
                        endprogram = true;
                        break;
                }



            } while (endprogram != true);

           

            Console.ReadLine();
            
        }
    }
}
