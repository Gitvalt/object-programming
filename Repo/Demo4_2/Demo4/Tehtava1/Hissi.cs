using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class Hissi
    {
        public static int floors = 5;
        public int nfloor;
        public int Nfloor {
            get
            {
                return nfloor;
            }
          
            set
            {
                if (Nfloor < 0 || Nfloor > floors)
              
                    Nfloor = floors;
                
                else
                
                    Nfloor = value;
                
            }
        }
        

        public Hissi()
        {
            nfloor = 1;
            
        } 
    }
}
