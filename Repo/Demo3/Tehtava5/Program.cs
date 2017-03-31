using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5
{
    class Oppilas
    {
        public Oppilas(string etunimi, string sukunimi, string ryhma, int opintopisteet)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.ryhma = ryhma;
            this.opintopisteet = opintopisteet;
        }

        public void nimenvaihto()
        {
            Console.WriteLine("Nimen vaihtaminen: \nEtunimi:");
            string enimi = Console.ReadLine();

            

            Console.WriteLine("Sukunimi:");
            string snimi = Console.ReadLine();
            Console.WriteLine("Uusi nimi on:");
            etunimi = enimi;
            sukunimi = snimi;
            Console.WriteLine(etunimi + " " + sukunimi);



        }

        //Muuta ryhmaa
        //vaihda nimi
        //Keksi lisaa ominaisuuksia

        public string etunimi;
        public string sukunimi;
        public string ryhma;
        public int opintopisteet;

        
    }
    class Program
    {
     
        static void Main(string[] args)
        {
            Oppilas op1 = new Oppilas("Timo", "Joku", "TTV34S", 68);
            Oppilas op2 = new Oppilas("Heikki", "Makinen", "TTV34S", 64);
            Oppilas op3 = new Oppilas("Johanna", "Nieminen", "TTV35P", 18);
            Oppilas op4 = new Oppilas("Matti", "Mattinen", "TTV35S", 22);
            Oppilas op5 = new Oppilas("Tommi", "Hakkeri", "TTV34S", 70);

            string piste1 = Convert.ToString(op1.opintopisteet);
            string piste2 = Convert.ToString(op2.opintopisteet);
            string piste3 = Convert.ToString(op3.opintopisteet);
            string piste4 = Convert.ToString(op4.opintopisteet);
            string piste5 = Convert.ToString(op5.opintopisteet);



            string[] op1t = new string[] { op1.etunimi, op1.sukunimi, op1.ryhma, piste1 };
            string[] op2t = new string[] { op2.etunimi, op2.sukunimi, op2.ryhma, piste2 };
            string[] op3t = new string[] { op3.etunimi, op3.sukunimi, op3.ryhma, piste3 };
            string[] op4t = new string[] { op4.etunimi, op4.sukunimi, op4.ryhma, piste4 };
            string[] op5t = new string[] { op5.etunimi, op5.sukunimi, op5.ryhma, piste5 };
            

            string[,] opts = new string[5,4];
           /* Console.WriteLine(op1t[0]);
            Console.WriteLine(op1t[1]);
            Console.WriteLine(op1t[2]);
            Console.WriteLine(op1t[3]);
            Console.WriteLine(piste1);//miksi ei == [0] on Timo, [3] == opintopisteet
            */

            //Tietojen laittaminen taulukkoon
            for(int i=0; i < 4; i++)
            {
                opts[0, i] = op1t[i];
            }

            for (int i = 0; i < 4; i++)
            {
                opts[1, i] = op2t[i];
            }

            for (int i = 0; i < 4; i++)
            {
                opts[2, i] = op3t[i];
            }

            for (int i = 0; i < 4; i++)
            {
                opts[3, i] = op4t[i];
            }

            for (int i = 0; i < 4; i++)
            {
                opts[4, i] = op5t[i];
            }

            /*
           
            */
            bool valmis = false;
            int oppilas;

            do
            {
                Console.WriteLine("1. Tulosta olemassa olevat oppilaat\n2. Muuta tietoja\n3. Lopeta ohjelma");
                int console = int.Parse(Console.ReadLine());
                int limiter = 4;
                switch (console)
                {

                    case 1:
                        string name = "";
                        for (int i = 0; i < limiter; i++)
                        {
                            for (int j = 0; j < limiter; j++)
                            {
                                name += opts[i, j];
                                name += " ";
                                if (j == 3)
                                {
                                    Console.WriteLine(name);
                                    name = "";
                                }


                            }
                            Console.WriteLine("\n");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Valitse oppilas: ");
                        for(int p = 0; p < 4; p++)
                        {
                            Console.WriteLine(p + ". " + opts[p, 0] + " " + opts[p, 1]);
                        }
                        Console.WriteLine("4. Cancel");
                        int valinta = int.Parse(Console.ReadLine());//Oppilaan numero taulukossa x,
                        Console.WriteLine("\n");
                        Console.WriteLine("Oppilas: " + opts[valinta,0] + " " + opts[valinta, 1]);
                        Console.WriteLine("Oppilaan ryhma: " + opts[valinta, 2] + " Opintopisteet: " + opts[valinta, 3]);

                        bool loopperi = false;
                        do {
                            Console.WriteLine("1. Muuta nimi\n2. Muuta ryhma\n3. Muuta opintopisteita\n4. Poistu");
                            int lue = int.Parse(Console.ReadLine());

                            switch (lue)
                            {
                                case 1:
                                    Console.WriteLine("Uusi etunimi: ");
                                    string usenimi = Console.ReadLine();
                                    Console.WriteLine("Uusi sukunimi: ");
                                    string ussnimi = Console.ReadLine();
                                    opts[valinta, 0] = usenimi;
                                    opts[valinta, 1] = ussnimi;
                                    Console.WriteLine("Uusi nimi: " + opts[valinta, 0] + " " + opts[valinta, 1]);
                                    break;

                                case 2:
                                    Console.WriteLine("Uusi ryhma: ");
                                    string uryhma = Console.ReadLine();
                                    opts[valinta, 2] = uryhma;
                                    Console.WriteLine("Uusi ryhma on: " + opts[valinta, 2]);

                                    break;
                                case 3:
                                    Console.WriteLine("Uusi opintopisteiden maara: ");
                                    int uoppiste = int.Parse(Console.ReadLine());
                                    opts[valinta, 3] = Convert.ToString(uoppiste);
                                    Console.WriteLine("Uusi pistemaara on: " + opts[valinta, 3]);

                                    break;
                                case 4:
                                    loopperi = true;
                                    break;
                            }

                        } while (loopperi != true);
                        break;
                    case 3:
                        Console.WriteLine("Ohjelma lopetetaan");
                        valmis = true;
                        break;
                }

            } while (valmis == false);

            Console.ReadLine();


        }
    }
}
