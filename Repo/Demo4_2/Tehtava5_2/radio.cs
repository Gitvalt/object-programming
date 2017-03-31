using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5_2
{
    class radio
    {
        public bool onoff { get; set; }
        public bool Cont_creation = false;
        
        public int vol;

        private int max_vol = 9;
        private int min_vol = 0;

        public int volume {
            get
            {
                return vol;
            }
            set
            {

                
                    if (value >= min_vol && value <= max_vol)
                    {
                        vol = value;
                    }
                    else
                    {
                        Console.WriteLine("Volume: (" + value + ") is out of range");
                        Console.WriteLine("Volume reset to minimum volume level: (" + min_vol + ")");
                    }
                
            }
        }

        


        public float freq { get; set; }
        private float min_freq = 2000.0f;
        private float max_freq = 26000.0f;
        public float radio_freq
        {
            get
            {
                return freq;
            }
            set
            {
                if (value >= min_freq && value <= max_freq) freq = value;
                else
                {
                    Console.WriteLine("Radio freq: (" + value + ") is out of acceptable range (2000.0 - 260000.0Hz)");
                    Console.WriteLine("Radio freq has now been changed to minimum settings: (" + min_freq + ")");
                    freq = 2000.0f;
                }
            }
        }

        public radio()
        {
          
        }

        public string printdata()
        {
            return "Current status:\nRadio is on? = " + onoff + "\nVolume level is set to =  " + vol + "\nCurrent radio freq =  " + freq + "Hz";
        }

        public void ChangeData()
        {
            string onoff_stat;

            //Dynaaminen valikko: Jos on paalla tarjoa laittaa kiinni ja toisinpain jos radio on kiinni

            if (onoff == true)
            {
                onoff_stat = "OFF";
            }
            else
            {
                onoff_stat = "ON";
            }

            bool cont2 = true;

            do
            {

                if (onoff == true)
                {
                    onoff_stat = "OFF";
                }
                else
                {
                    onoff_stat = "ON";
                }


                Console.WriteLine("1. Turn radio " + onoff_stat);
                Console.WriteLine("2. Change volume level, Current (" + vol + ")");
                Console.WriteLine("3. Change radio freq, Current (" + freq + "Hz)");
                Console.WriteLine("4. Cancel changes");



                int input2 = int.Parse(Console.ReadLine());

                 switch (input2)
                {
                    case 1:
                        if (onoff == true)
                        {
                            onoff = false;
                        }
                        else
                        {
                            onoff = true;
                        }

                        break;
                    case 2:
                        Console.WriteLine("Input a new volume level (range is from " + min_vol + " to " + max_vol + ")");
                        int new_vol = int.Parse(Console.ReadLine());
                        volume = new_vol;
                        Console.WriteLine("New volume is: " + volume);
                        break;
                    case 3:
                        Console.WriteLine("Input a new radio freq (range is from " + min_freq + " to " + max_freq + "):");
                        float new_freq = int.Parse(Console.ReadLine());
                        radio_freq = new_freq;
                        Console.WriteLine("New radio freq is: " + radio_freq);
                        break;
                    case 4:
                        cont2 = false;
                        break;
                }
            } while (cont2 == true);

        }

    }
}
