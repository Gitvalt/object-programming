using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            //Console.WriteLine(array.Sum()); 26,60
            
           
            Console.WriteLine(ArrayCalcs.SumF(array));
            Console.WriteLine(ArrayCalcs.AVG(array));
            Console.WriteLine(ArrayCalcs.Min(array));
            Console.WriteLine(ArrayCalcs.Max(array));


            /*
            Jos array on tyhja ohjelma toimii normaalisti keskiarvoon saakka.
            keskiarvo = lukujen summa / lukujen maara

            Average(array) = 0/0, nollalla ei voi jakaa

            double[] array2 = { };

            Console.WriteLine(ArrayCalcs.SumF(array2));
            Console.WriteLine(ArrayCalcs.AVG(array2));
            Console.WriteLine(ArrayCalcs.Min(array2));
            Console.WriteLine(ArrayCalcs.Max(array2));
            */

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
