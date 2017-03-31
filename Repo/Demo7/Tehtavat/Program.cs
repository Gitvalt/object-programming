using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = null;
        try
        {
            outputFile = new System.IO.StreamWriter(@"c:\test.file");
            outputFile.WriteLine("Here is a sample text to file.");
        }
        
        catch (Exception ex)
        {
            Console.WriteLine("Some other exception happend (Exception)\n" + ex.Message);
        }
        finally
        {
            // check for null because OpenWrite might have failed
            if (outputFile != null)
            {
                outputFile.Close();
            }
        }
        }
    }
}
