using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tehtava2_printnumbers_totext
{
    class Program
    {
        public static void WriteToFile(List<string> x, string y)
        {
            //Writetofile(user input, txt.document)
            string pathtodocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                
                
                System.IO.StreamWriter outputFile = null;
                string path = pathtodocument + @"\" + y;
                bool exists = File.Exists(path);
                Console.WriteLine(exists);
                string readfile;
                
                if (exists == true)
                {

                    foreach (string luku in x)
                    {
                        readfile = System.IO.File.ReadAllText(path);
                        Console.WriteLine(luku);
                        System.IO.File.WriteAllText(path, readfile + luku + Environment.NewLine);
                    }
                }


                else
                {
                    outputFile = new System.IO.StreamWriter(path);
                    outputFile.Write(x + "\n");
                    outputFile.Close();
                }

                


            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong..." + ex.Message);
            }
            return;
        }

        static void Main(string[] args)
        {

            bool jatka = true;


            int kokonaisluku;
            double reaaliluku;

            bool isdouble;
            bool isint;
            

            List<string> kokonaisL = new List<string>();
            List<string> reaaliL = new List<string>();

         

           


            string input;


            string output_file_reaali = "T2double.txt";
            string output_file_kokonais = "T2Integers.txt";

            do
            {
                input = Console.ReadLine();
                isdouble = double.TryParse(input, out reaaliluku);
                isint = int.TryParse(input, out kokonaisluku);


                if (isint == false && isdouble == true)
                {
                    reaaliL.Add(input);
                    
         
                }
                else if (isint == true && isdouble == true)
                {
                    kokonaisL.Add(input);
                }
                else
                {
                    jatka = false;
                }

            } while (jatka == true);

            WriteToFile(reaaliL, output_file_reaali);
            WriteToFile(kokonaisL, output_file_kokonais);


            Console.WriteLine("\nKokonaisluku");
            foreach (string luku in kokonaisL)
            {
                Console.WriteLine(luku);
            }

            Console.WriteLine("\nReaaliluku:");
            foreach (string luku in reaaliL)
            {
                Console.WriteLine(luku);
            }


            Console.ReadLine();
        }
    }
}
