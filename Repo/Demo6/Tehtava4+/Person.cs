using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava4
{
    class Person
    {
        public string SSN { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public Person(string SSN, string firstname, string lastname, int age, int weight, int height)
        {
            this.SSN = SSN;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Weight = weight;
            Height = height;

        }

        public override string ToString()
        {
            return "SSN: " + SSN + "\nFirstname: " + Firstname + "\nLastname " + Lastname + "\nAge " + Age + "\nWeight " + Weight + "\nHeight " + Height + "\n\n";
        }

    }
}
