using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3_construct
{
    class Lottokone
    {
        public int repeat { get; set; }


        public string game { get; set; }
        public Random rnd { get; set; }
        private int draws { get; set; }
        private int draws_tahti { get; set; }

        public string input_name { get; set; }
        public List<string> number_row { get; set; }
        private int bignumber { get; set; }
        public string k { get; set; }

        public string test1 { get; set; }
        public string test2 { get; set; }
        public string test3 { get; set; }

        public int number { get; set; }

        public Lottokone()
        {
           
        }

        public List<string> Draw(string game, int repeats_output)
        {
            if (game == "Lotto")
            {
                draws = 7;
                bignumber = 39;
            }
            else if (game == "Viiking Lotto")
            {
                draws = 6;
                bignumber = 48;
            }
            else if (game == "Eurojackpot")
            {
                draws = 5 + 2;

                bignumber = 50;
            }
            
            for (int i = 0; i < repeats_output; i++)
            {
                for (int j = 0; j < draws; j++)
                {
                    number = rnd.Next(1, bignumber + 1);
                    k += number + ",";
                }               
                number_row.Add(k);
            }

            return number_row;

        }
    }
}
