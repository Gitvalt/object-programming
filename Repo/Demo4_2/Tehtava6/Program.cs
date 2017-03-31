using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6
{
    class Program
    {
        static void Main(string[] args)
        {


            Product test = new Product("Kaappi", "Huonekalu");
            Print testi = new Print("Pelit", "lehti", "Finnish game magazine", 120);
            Disk disk = new Disk("Ubuntu CD", "DVD", 2);
            Computer comp = new Computer("GTA 234", "Laptop", 500, "i5", "Lenovo");

            List<Product> bookcase = new List<Product>();
            bookcase.Add(test);
            bookcase.Add(testi);
            bookcase.Add(disk);
            bookcase.Add(comp);

            bool cont = true;

            do
            {
                Console.WriteLine("1. Print content of bookcase\n2. Add new item to bookcase\n3. End program");
                int read = int.Parse(Console.ReadLine());

                switch (read)
                {
                    case 1:

                        foreach (Product tuote in bookcase)
                        {
                            Console.WriteLine(tuote.ToString());
                        }

                        break;

                    case 2:

                        Console.WriteLine("Add new...\n1. Magazine or book\n2. Cd-, DVD- or blueray-disk\n3. Computer\n4. Cancel");
                        int read2 = int.Parse(Console.ReadLine());

                        switch (read2)
                        {
                            case 1:
                                Console.WriteLine("Name: ");
                                string name1 = Console.ReadLine();
                              
                                //making sure that there dosen't exist a object with that name
                                string trimmed = name1.Trim();
                                int index = bookcase.FindIndex(name => name.name == trimmed);


                                do
                                {
                                    if (index >= 0)
                                    {
                                        Console.WriteLine("There already exists a print with name: " + name1);
                                        Console.WriteLine("Try a new name: ");
                                        name1 = Console.ReadLine();
                                        index = bookcase.FindIndex(name => name.name == name1);

                                    }
                                } while (index >= 0);


                                Console.WriteLine("What type of print (example. book, magazine...): ");
                                string type1 = Console.ReadLine();

                                Console.WriteLine("Publisher of the print: ");
                                string publ1 = Console.ReadLine();

                                Console.WriteLine("Number of pages: ");
                                int page1 = int.Parse(Console.ReadLine());

                                Print Unew = new Print(name1, type1, publ1, page1);
                                Console.WriteLine("New " + type1 + " information: \n" + Unew.ToString());
                                bookcase.Add(Unew);
    
                                break;

                            case 2:
                                Console.WriteLine("Name: ");
                                string name2 = Console.ReadLine();

                                trimmed = name2.Trim();
                                index = bookcase.FindIndex(name => name.name == trimmed);


                                do
                                {
                                    if (index >= 0)
                                    {
                                        Console.WriteLine("There already exists a print with name: " + name2);
                                        Console.WriteLine("Try a new name: ");
                                        name1 = Console.ReadLine();
                                        index = bookcase.FindIndex(name => name.name == trimmed);

                                    }
                                } while (index >= 0);






                                Console.WriteLine("What type of disk? (CD, DVD, Blueray...): ");
                                string type2 = Console.ReadLine();

                                Console.WriteLine("Disk memory size (GB): ");
                                int mem = int.Parse(Console.ReadLine());
                                
                                Disk UnewDisk = new Disk(name2, type2, mem);
                                Console.WriteLine("New " + type2 + " information: \n" + UnewDisk.ToString());
                                bookcase.Add(UnewDisk);
                                break;

                            case 3:
                                Console.WriteLine("Name: ");
                                string name3 = Console.ReadLine();

                                trimmed = name3.Trim();
                                index = bookcase.FindIndex(name => name.name == trimmed);


                                do
                                {
                                    if (index >= 0)
                                    {
                                        Console.WriteLine("There already exists a print with name: " + name3);
                                        Console.WriteLine("Try a new name: ");
                                        name1 = Console.ReadLine();
                                        index = bookcase.FindIndex(name => name.name == trimmed);

                                    }
                                } while (index >= 0);

                                Console.WriteLine("What type of Computer? (Laptop, Desktop, Tablet...): ");
                                string type3 = Console.ReadLine();

                                Console.WriteLine("Computer harddrive memory size (GB): ");
                                int mem2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Computer's proceccor: ");
                                string proc = Console.ReadLine();

                                Console.WriteLine("Computer's producer: ");
                                string prod = Console.ReadLine();

                                Computer UnewComp = new Computer(name3, type3, mem2, proc, prod);
                                Console.WriteLine("New " + type3 + " information: \n" + UnewComp.ToString());
                                bookcase.Add(UnewComp);
                                break;

                            case 4:
                                Console.WriteLine("Canceling...");
                                break;
                        }

                        break;
                    case 3:
                        Console.WriteLine("Ending program...");
                        cont = false;
                        break;
                }

            } while (cont != false);


           
            Console.ReadLine();
        }
    }
}
