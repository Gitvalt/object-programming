using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3_tvprograms_todisk
{
    class TvPrograms
    {
        public string Name { get; set; }
        public string Chanel { get; set;}
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public string info;
        public string Info { get; set; }


        public TvPrograms(string name, string chanel, string begin, string end, string info)

        {
            
            Name = name;
            Chanel = chanel;
            Begin = DateTime.Parse(begin);
            End = DateTime.Parse(end);
            Info = info;


        }

        public string Tulosta()
        {
            return "Nimi: " + Name
                + "\nKanava: " + Chanel
                + "\nAlkamisaika: " + Begin.ToString("HH:mm")
                + "\nLoppumisaika: " + End.ToString("HH:mm")
                + "\nKuvaus: " + Info
                +"\n";
        }

        public override string ToString()
        {
            return Name + ";" + Chanel + ";" + Begin + ";"+ End + ";" +Info;
        }

    }
}
