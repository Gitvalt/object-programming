using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3_lottomachine
{
    class Lotto
    {

        public int repeat { get; set; }


        public string game { get; set; }
        public Random rnd { get; set; }
        private int draws { get; set; }
        private int draws_tahti { get; set; }

        public string input_name { get; set; }
        public List<int> number_row { get; set; }
        private int bignumber { get; set; } 

        public Lotto()
        {         
        }

        public void Draw(string game, int repeats_output)
        {
            if(game == "Lotto")
            {
                draws = 7;
                bignumber = 39;
            }
            else if(game == "Viiking Lotto")
            {
                draws = 6;
                bignumber = 48;
            }
            else if(game == "Eurojackpot")
            {
                draws = 5+2;
                
                bignumber = 50;
            }

            for(int i = 0; i < repeats_output; i++)
            {
                for(int j = 0; j < draws; j++)
                {
                    out
                }
            }

            




        }

    }
}
