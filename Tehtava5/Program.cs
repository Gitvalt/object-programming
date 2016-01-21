using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5
{
    class Oppilas
    {
        public Oppilas(string etunimi, string sukunimi, string ryhma)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.ryhma = ryhma;
        }

        private string etunimi;
        private string sukunimi;
        private string ryhma;

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Oppilas op1 = new Oppilas("Timo", "Joku", "TTV34S");
            Oppilas op2 = new Oppilas("Heikki", "Makinen", "TTV34S");
            Oppilas op3 = new Oppilas("Johanna", "Nieminen", "TTV35P");
            Oppilas op4 = new Oppilas("Matti", "Mattinen", "TTV35S");
            Oppilas op5 = new Oppilas("Tommi", "Hakkeri", "TTV34S");



        }
    }
}
