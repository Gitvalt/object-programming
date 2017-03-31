using System;

namespace Tehtava4_Kiuas
{
    class Kiuas
    {
        public double tempeature { get; set; }
        public double humidity { get; set; }

        public double maxheat { get; set; }
        public double minheat { get; set; }
        public double maxhum { get; set; }
        public double minhum { get; set; }
        public string errormessage { get; set; }

        public bool result { get; set; }

        public Kiuas()
        {
            maxheat = 40 + 1;
            minheat = 0 + 1;

            //i have no idea how humidity is messured
            maxhum = 6 + 1;
            minhum = 1 + 1;

        }

        public bool Isok(string x, string inputtype)
        {
            ///x= value
            ///inputtype = humidity/tempeature to check if within correct range
            ///result = true or false

            if (x == "")
            {
                result = false;
                errormessage = "Empty value";
                
            }
            else {
                double k = Convert.ToDouble(x);


                if (inputtype == "Temperature")
                {
                    if (k < minheat && k < maxheat)
                    {
                        result = false;
                        errormessage = "Too low heat" + " (" + k + ")";
                    }
                    else if (k > maxheat && k > minheat)
                    {
                        result = false;
                        errormessage = "Too high heat" + " (" + k + ")";
                    }
                    else
                    {
                        result = true;

                    }
                }

                if (inputtype == "humidity")
                {
                    if (k > minhum && k > maxhum)
                    {
                        result = false;
                        errormessage = "Too high humidity" + " (" + k + ")";

                    }
                    else if (k < maxhum && k < minhum)
                    {
                        result = false;
                        errormessage = "Too low humidity" + " (" + k + ")";
                    }
                    else
                    {
                        result = true;
                    }
                }

                if (inputtype != "humidity" && inputtype != "Temperature")
                {
                    result = false;
                }
            }
            //Send a error if statement if fails
            return result;
        }
    }
}

