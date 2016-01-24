using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            int sekuntit;

            bool tulos = Int32.TryParse(input, out sekuntit);

            if (tulos)
            {
                sekuntit = Convert.ToInt32(input);
                int tunnit = sekuntit / 3600;
                int minuutit = sekuntit / 60 - tunnit * 60;
                int sekuntti = sekuntit % 60; 
               
                Console.WriteLine("sekuntit: " + sekuntti + "\nminuutit: " + minuutit + "\ntunnit: " + tunnit);
            }
            else
            {
                Console.WriteLine("Sinun laittamasi arvo ei ollut luku");
                
            }

            
            Console.ReadLine();

        }
    }
}
