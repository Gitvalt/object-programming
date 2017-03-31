using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Dictionary<string, CD> listofcd = new Dictionary<string, CD>();

            //creating list of random songs
            List<string> songs = new List<string>();

            string song_name_1 = "Song_";
            string song_name;
            for (int i = 0; i < 10; i++)
            {
                song_name = "\t" + song_name_1 + i;
                songs.Add(song_name);
            }


            string word = "";
            string cd_name = "CD_";

            Dictionary<int, string> selection = new Dictionary<int, string>();



            for (int i = 0; i <= 10; i++)
            {

                //Creating random artist name
                for (int j = 0; j < 5; j++)
                {
                    word += (char)rand.Next('A', 'Z');
                }


                CD new_cd = new CD(cd_name + i, word);
                listofcd.Add(new_cd.Name, new_cd);
                selection.Add(i,new_cd.Name);
                //cd_list.Add(new CD(cd_name + i, word));

                word = "";
            }

         

            foreach(CD try1 in listofcd.Values)
            {
                
            foreach (String subj in songs)
            {
   
                    listofcd[try1.Name].Songs += subj + ",\n";
            }

               // Console.WriteLine(try1.Name + "\n" + try1.Artist + "\n" + try1.Songs + "\n");
                
            }

            //Console.WriteLine(listofcd["CD_5"].ToString());
            //success!

            bool Cont = true;
            int input2 = 0;
            bool Cont2 = true;
            bool arewedone = true;

            var new_name = "";
            string new_artist;
            var new_song_input = "";
            var new_songs = "";
            var new_songs_small = "";


            do
            {

                Console.WriteLine("1. Print all CD's and their data\n2. Print all CD names\n"
                    + "3. Search for CD\n4. Remove a CD from dictionary\n"
                    + "5. Add CD\n"
                    + "6. End program");
                try {
                    int input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            //Print all data
                            foreach (CD content in listofcd.Values)
                            {
                                Console.WriteLine(content.ToString());
                            }
                            break;
                        case 2:
                            //Print only names of CD's
                            foreach (CD content in listofcd.Values)
                            {
                                Console.WriteLine(content.Name);
                            }
                            break;
                        case 3:
                            //Search for CD
                            do
                            {
                                Console.WriteLine("Select CD with the number");
                                //index,name => user input can be used to find cd with correct name
                                Console.WriteLine("Index ; Name");
                                for (int k = 0; k <= 10; k++)
                                {
                                    Console.WriteLine("(" + k + ") " + "; " + selection[k]);
                                }


                                //keeps asking for number until number given within correct range
                                //if error found we will ask for a number again.
                                try
                                {
                                    input2 = int.Parse(Console.ReadLine());
                                    
                                    
                                }
                                catch (KeyNotFoundException)
                                {
                                    Console.WriteLine("Index out of range");
                                    arewedone = false;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("You have to select a number");
                                    arewedone = false;
                                }
                                
                                if(arewedone == true)
                                {
                                    Cont2 = false;
                                }
                                arewedone = true;

                            } while (Cont2 == true);

                            
                            Console.WriteLine(listofcd[selection[input2]]);

                            break;
                        case 4:
                            //Remove CD
                            do
                            {
                                Console.WriteLine("Select CD with the number");
                                Console.WriteLine("Index ; Name");
                                for (int k = 0; k <= 10; k++)
                                {
                                    Console.WriteLine("(" + k + ") " + "; " + selection[k]);
                                }

                                try
                                {
                                    input2 = int.Parse(Console.ReadLine());


                                }
                                catch (KeyNotFoundException)
                                {
                                    Console.WriteLine("Index out of range");
                                    arewedone = false;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("You have to select a number");
                                    arewedone = false;
                                }

                                if (arewedone == true)
                                {
                                    Cont2 = false;
                                }
                                arewedone = true;

                            } while (Cont2 == true);


                            listofcd.Remove(selection[input2]);
                            Console.WriteLine("Removed: " + selection[input2]);
                            selection.Remove(input2);
                            break;

                        case 5:
                            //Add new CD

                            Console.WriteLine("CD name: ");
                            new_name = Console.ReadLine();

                            Console.WriteLine("CD artist: ");
                            new_artist = Console.ReadLine();

                            Console.WriteLine("Song information (input 'Finish' to save new CD)");
                            do
                            {
                                new_song_input = Console.ReadLine();
                                new_songs_small = new_song_input.ToLower();

                                if (new_songs_small != "finish")
                                {
                                    new_songs += "\t" + new_song_input + ",\n" ;
                                }
                                 

                            } while (new_songs_small != "finish");

                            CD new_cd_console = new CD(new_name, new_artist);
                            new_cd_console.Songs = new_songs;

                            listofcd.Add(new_cd_console.Name, new_cd_console);
                            selection.Add(selection.Count() + 1, new_cd_console.Name);

                            Console.WriteLine("New cd successfully created.\nCD data:\n" + new_cd_console.ToString());

                            break;
                        
                        case 6:
                            //End program
                            Console.WriteLine("Ending program...");
                            Cont = false;
                            break;

                        default:
                            Console.WriteLine("Number out of range");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You have to select a number");
                }

            } while (Cont != false);


            Console.ReadLine();
        }
    }
}
