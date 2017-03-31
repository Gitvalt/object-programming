using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6
{
    class Print : Product
    {

        public string publisher { get; set; }
        public int pagenumber { get; set; }

        public Print()
        {

        }

        public Print(string name, string type, string Publisher, int Pagenumber)
            : base(name, type)
        {
            publisher = Publisher;
            pagenumber = Pagenumber;
        }

        public override string ToString()
        {
            return base.ToString() + ", Pagenumber: " + pagenumber + ", Publisher: " + publisher;
        }


    }
}
