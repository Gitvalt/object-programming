using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tehtava.test
{
    public class Image
    {
        public string path { get; set; }
        public string headline { get; set; }
        public string description { get; set; }
        

        public Image(string Path)
        {
            path = Path;
        }



    }
}
