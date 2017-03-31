using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava4
{
    class Program
    {
        private static void Officeadd(string name, List<Employee> officeemplist, Employee you)
        {
            /*
            1. Name of the office you are being assinged to.
            2. List of employees in office
            3. List of employees in company
            4. New employee
            */
            you.Work_office = name;
            officeemplist.Add(you);            
            return;
        }

        private static void Companyadd(Company j, List<Employee> x, Employee y)
        {
            x.Add(y);
            y.Employer = j.Company_name;
            return;
        }

        private static void ADDtoA(string name, List<Employee> officeemplist, Employee you, List<Employee> wholecompemp, Company j)
        {
            Companyadd(j, wholecompemp, you);
            Officeadd(name,officeemplist,you);
            return;
        }

        static void Main(string[] args)
        {

            //Creating company structure....
            Company test_company = new Company("Dcompany software", "Pekka Suomalainen");

            Office toimisto = new Office(test_company.Company_name, test_company.Owner, "Sijainti");
            List<Employee> sijainti_employees = new List<Employee>();


            Office toimisto2 = new Office(test_company.Company_name, test_company.Owner, "Paakatu 5");
            List<Employee> paakatu_employees = new List<Employee>();



            //Creating employees....
            //There cannot exist just a employee. Must have profession BOSS, Programmer or Secretery
            Boss boss = new Boss("Pekka", "Suomalainen");
            Boss boss2 = new Boss("Bosstest", "Other");



            //Creating a programmer
            Programmer programmer = new Programmer("Tester", "Someone");
            Programmer programmer2 = new Programmer("Toinen", "Joku");
            Programmer programmer3 = new Programmer("Kolmas", "Testi");
            Programmer programmer4 = new Programmer("Neljas", "Kopio");
            Programmer programmer5 = new Programmer("Viides", "Copy");
            Programmer programmer6 = new Programmer("Kuudes", "Others");





            //Uuden lisääminen työpaikan nimi, työpaikan työntekijät lista, koko yrityksen lista ja uuden työntekijän objekti
            List<Employee> allemployees = new List<Employee>();

            //Easy way to add new employees to office
            //Officeadd(toimisto.Location,sijainti_employees,programmer);
            //Officeadd(toimisto.Location, sijainti_employees, programmer3);

            //Companyadd(test_company, allemployees, programmer);
            //Companyadd(test_company, allemployees, programmer2);
            //Companyadd(test_company, allemployees, programmer3);

            Companyadd(test_company, allemployees, boss);
            Companyadd(test_company, allemployees, boss2);

            ADDtoA(toimisto.Location, sijainti_employees, boss, allemployees, test_company);
            ADDtoA(toimisto.Location, sijainti_employees, programmer, allemployees, test_company);
            ADDtoA(toimisto.Location, sijainti_employees, programmer2, allemployees, test_company);
            ADDtoA(toimisto.Location, sijainti_employees, programmer3, allemployees, test_company);

            ADDtoA(toimisto2.Location, paakatu_employees, boss2, allemployees, test_company);
            ADDtoA(toimisto2.Location, paakatu_employees, programmer4, allemployees, test_company);
            ADDtoA(toimisto2.Location, paakatu_employees, programmer5, allemployees, test_company);
            ADDtoA(toimisto2.Location, paakatu_employees, programmer6, allemployees, test_company);
            //Setting list allemployees as list that contains names of every employee of the company.

            test_company.AllEmployees = allemployees;
            toimisto.EmployeesInOffice = sijainti_employees;
            toimisto2.EmployeesInOffice = paakatu_employees;





            Console.WriteLine("All employees of the test_company:\n");

            foreach (Employee employee in test_company.AllEmployees)
            {    
                Console.WriteLine(employee + "\n");
            }

            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Workers in office: " + toimisto.Location + "\n");

            foreach (Employee employee in toimisto.EmployeesInOffice)
            {
                Console.WriteLine(employee + "\n");
                
            }

            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Workers in office: " + toimisto2.Location + "\n");

            foreach (Employee employee in toimisto2.EmployeesInOffice)
            {
                Console.WriteLine(employee + "\n");

            }
            

            Console.WriteLine();
            Console.ReadLine();
            
        }
    }
}
