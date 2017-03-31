using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava4
{
    class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public static string Username { get; set; }


        public string Work_office { get; set; }
        public string Employer { get; set; }


        //public string Profession { get; set; }
        //make class that can only be inherited. Forcing creation of employee based on profession

        //Set if there is employer or placeofwork

        public Employee(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;

            string test = Firstname.Substring(0, 3);
            string test2 = Lastname.Substring(0, 3);

            Work_office = "Not defined";

            Random rnd = new Random();
            int usern = rnd.Next(100, 999);

            Username = test + usern + test2;
            Employer = "Unemployed";
                     
        }

        public override string ToString()
        {
            return "Firstname: " + Firstname + "\nSurname: " + Lastname + "\nUsername: " + Username + "\nPlace of Work: " + Work_office
                + "\nEmployer: " + Employer;
        }
    }
}
