using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava4
{
    class Company
    {
        public string Company_name { get; set; }
        public string Owner { get; set; }
        public string offices { get; set; }

        public List<Employee> AllEmployees { get; set; }

        public Company(string name, string owner)
        {
            Company_name = name;
            Owner = owner;
        }

        public override string ToString()
        {
            return "Company name: " + Company_name 
                + "\nOwner: " + Owner;
        }
    }
}
