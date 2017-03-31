using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava4
{
    class Boss : Employee
    {
        public string alaiset { get; set; }

        public Boss(string Firstname, string Lastname):
            base(Firstname, Lastname)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "\nJob description: " + GetType();
        }
    }
}
