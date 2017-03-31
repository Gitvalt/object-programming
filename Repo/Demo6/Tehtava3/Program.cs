using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3
{
    class Program
    {


        static void Main(string[] args)
        {
            List<string> Deckofcards = new List<string>();
            List<string> Hertta = new List<string>();
            List<string> Ruutu = new List<string>();
            List<string> Risti = new List<string>();
            List<string> Pata = new List<string>();

            List<string> graph_cards = new List<string>();
            string J = "Jatka";
            string Q = "Kuningatar";
            string K = "Kuningas";
            string A = "Assa";

            graph_cards.Add(J);
            graph_cards.Add(Q);
            graph_cards.Add(K);
            graph_cards.Add(A);


            string Ci;
            for (int i = 2; i < 11; i++)
            {
                Ci = Convert.ToString(i);
                Hertta.Add(Ci);
                Ruutu.Add(Ci);
                Risti.Add(Ci);
                Pata.Add(Ci);

            }

            foreach (string gcard in graph_cards)
            {
                Hertta.Add(gcard);
                Ruutu.Add(gcard);
                Risti.Add(gcard);
                Pata.Add(gcard);

            }


            //Dont be lazy. Create loop that creates the deck in one loop
            //Cant create directory. key has to be uniqe.
         

            foreach (string content in Hertta)
            {
                    Deckofcards.Add("Hertta;" + Convert.ToString(content));
            }

            foreach (string content in Pata)
            {
                Deckofcards.Add("Pata;" + Convert.ToString(content));
            }

            foreach (string content in Risti)
            {
                Deckofcards.Add("Risti;" + Convert.ToString(content));
            }

            foreach (string content in Ruutu)
            {
                Deckofcards.Add("Ruutu;" + Convert.ToString(content));
            }
            int numberofcards = Deckofcards.Count();
            Random rnd = new Random();

            var rand_lista = Deckofcards.OrderBy(item => rnd.Next());
            bool cont = true;

            do
            {
                int input;
                Console.WriteLine("1. Print content of pack of cards\n2. Print randomly sorted pack of cards\n3. Close the program...\n4. Clear console");
                try {
                     input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Printing content of Deck");
                            foreach (string card in Deckofcards)
                            {
                                Console.WriteLine(card);
                            }
                            break;

                        case 2:
                            //Creating randomly sorted pack of cards
                            Console.WriteLine("Printing randomly sorted deck");

                            foreach (string card in rand_lista)
                            {
                                Console.WriteLine(card);
                            }

                            break;

                        case 3:
                            Console.WriteLine("Closing program...");
                            cont = false;
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("Console Cleared");
                            break;

                        default:
                            Console.WriteLine("Number out of range");
                            break;
                    }

                }
                catch(FormatException)
                {
                    Console.WriteLine("Your selection has to be a number");  
                }
                
                
                    
            } while (cont == true);





            Console.ReadLine();




        }
    }
}
