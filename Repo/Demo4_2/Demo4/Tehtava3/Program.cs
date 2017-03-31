using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kirsi = new Employee("Kirsi Kirsi", "Teacher", 4200.50f);
            Employee jussi = new Boss("Jussi Pekka", "Head of Institute", 9000.0f, "Audi", 5000.0f);

            kirsi.Salary += 1000.0f;
            jussi.Salary -= 2000.0f;
            //jussi.Bonus = 1000.0f;
            /*kirsi.Bonus = nocando*/

            ShowSomeWork(kirsi);
            ShowSomeWork(jussi);
            Console.ReadLine();

        }

        static void ShowSomeWork(Employee emp1)
        {
            emp1.Work();
        }
    }
}
