using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava4
{
    class Programmer : Employee
    {

        public Programmer(string Firstname, string Lastname):
            base(Firstname,Lastname)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nJob description: " + GetType();
        }

    }
}
