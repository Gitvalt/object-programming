using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoittelua_Kapselointi
{
    class Student : Person
    {
        public string StudentID { get; set; }

        // default constructor
        public Student()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Student(string firstName, string lastName, string studentID)
            : base(firstName, lastName)
        {
            StudentID = studentID;
        }

        // just one method what Student can do
        public void StudentMethod()
        {
            Console.WriteLine("This method belongs to Student!");
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}
