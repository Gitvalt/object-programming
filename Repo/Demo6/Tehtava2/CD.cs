using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Songs { get; set; }

        public CD(string name, string artist)
        {
            Name = name;
            Artist = artist;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nArtist: " + Artist + "\nSongs: \n" + Songs;
        }

    }





}
