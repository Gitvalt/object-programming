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

            
            string[] op1t = new string[] { op1.etunimi, op1.sukunimi, op1.ryhma, Convert.ToString(op1.opintopisteet) };
            string[] op2t = new string[] { op2.etunimi, op2.sukunimi, op2.ryhma, Convert.ToString(op2.opintopisteet) };
            string[] op3t = new string[] { op3.etunimi, op3.sukunimi, op3.ryhma, Convert.ToString(op3.opintopisteet) };
            string[] op4t = new string[] { op4.etunimi, op4.sukunimi, op4.ryhma, Convert.ToString(op4.opintopisteet) };
            string[] op5t = new string[] { op5.etunimi, op5.sukunimi, op5.ryhma, Convert.ToString(op5.opintopisteet) };
            

            string[,] opts = new string[5,4];
            Console.WriteLine(op1t[1]);
            Console.WriteLine(op1t[2]);
            Console.WriteLine(op1t[3]);
            Console.WriteLine(op1t[4]);//miksi ei
            /*
            for(int i=1; i < 5; i++)
            {
                opts[1, i] = op1t[i];
            }
            
            Console.WriteLine(opts[1, 1] + "\n" + opts[1, 2] + "\n" + opts[1, 3] + "\n" + opts[1, 4]);
            */









            /*
            foreach (string name in op1t) {
                Console.WriteLine(name);
            }
            */



            Console.ReadLine();


        }
    }
}
