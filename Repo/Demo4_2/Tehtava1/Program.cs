using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle mycar = new Vehicle("Toyota", "Purkki");
            


            Console.WriteLine(mycar.ToString());

            mycar.RemoveTyres();
            Console.WriteLine(mycar.ToString());
            mycar.AddTyre(new Rengas("Nokia", "Hakkapeliita", "123/4561r"));
            mycar.AddTyre(new Rengas("Nokia", "Hakkapeliita", "123/4561r"));
            mycar.AddTyre(new Rengas("Nokia", "Hakkapeliita", "123/4561r"));

            Console.WriteLine(mycar.ToString());
            Console.ReadLine();

        }
    }
}
