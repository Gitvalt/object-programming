using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tehtava3_tvprograms_todisk
{
    class Program
    {
        static void Main(string[] args)
        {

            TvPrograms tvprog = new TvPrograms("Ohjelman nimi", "MTV 3", "14:00", "15:00", "");
            TvPrograms tvprog2 = new TvPrograms("Ohjelman nimi", "MTV 3","15:00","16:45","ksaodkosadko");
            TvPrograms tvprog3 = new TvPrograms("Ohjelman nimi", "MTV 3", "16:45", "18:00", "ksaodkosadko");
            TvPrograms tvprog4 = new TvPrograms("Ohjelman nimi", "Tele Finland", "20:00", "21:00", "");

            List<TvPrograms> monday = new List<TvPrograms>();
           
            monday.Add(tvprog);
            monday.Add(tvprog2);
            monday.Add(tvprog3);
            monday.Add(tvprog4);

            string pathtodocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            System.IO.StreamWriter outputFile = null;
            string path = pathtodocument + @"\TvPrograms.txt";
            bool exists = File.Exists(path);


            try
            {
                outputFile = new System.IO.StreamWriter(path);


                foreach (TvPrograms program in monday)
                {

                    outputFile.Write(program + Environment.NewLine);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            outputFile.Close();
            string new_txt;

            try {
                string[] txt_output;
                txt_output = System.IO.File.ReadAllLines(path);
                
                foreach (string txt in txt_output)
                {
                    new_txt = txt.Replace(";", "\n");
                    Console.WriteLine(new_txt + "\n");

                }
            }
                  
            
            catch (Exception es)
            {
                Console.WriteLine(es.Message);
            }




     
            Console.ReadLine();

        }
    }
}
