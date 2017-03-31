using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava4
{
    class Office:Company
    {
        
        public string Location { get; set; }
        public List<Employee> EmployeesInOffice { get; set; }
        public int Employee_count { get; set; }

        public Office(string Company_name, string Owner, string location):
            base(Company_name, Owner)
        {
     
            Location = location;

        }

        public override string ToString()
        {
            if(Employee_count != 0)
            {
                return base.ToString() + "\nOffice address: " + Location + "\nEmployees in the location: " + Employee_count;
            }
            else {
          return base.ToString() + "\nOffice address: " + Location;
        }
        }


    }
}
