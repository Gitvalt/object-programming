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
            List<Person> persons = new List<Person>();
            Random rnd = new Random();

            int SSN_1 = rnd.Next(1000000, 9999999);
            int SSN_2 = rnd.Next(1 , 999);
            //Find out decimal printing

            string SSN_complete = SSN_1 + "-" + SSN_2;
            
            persons.Add(new Person(SSN_complete, "Pekka", "Testi", rnd.Next(18,90), rnd.Next(60, 80), rnd.Next(160, 180)));
            persons.Add(new Person(SSN_complete, "Toinen", "Testi", rnd.Next(18, 90), rnd.Next(60, 80), rnd.Next(160, 180)));
            persons.Add(new Person(SSN_complete, "Kolmas", "Testi", rnd.Next(18, 90), rnd.Next(60, 80), rnd.Next(160, 180)));
            persons.Add(new Person(SSN_complete, "Neljas", "Testi", rnd.Next(18, 90), rnd.Next(60, 80), rnd.Next(160, 180)));
            persons.Add(new Person(SSN_complete, "Viides", "Testi", rnd.Next(18, 90), rnd.Next(60, 80), rnd.Next(160, 180)));

            persons.Add(new Person("123123", "Jari", "Testi", 20, 64, 180));
            persons.Add(new Person("123123132-123", "Ihminen", "Testi", 70, 64, 155));
            persons.Add(new Person("12123123-3", "Intia", "Testi1", 15, 80, 160));
            persons.Add(new Person("123451326-123", "Stop", "Tes2ti", 50, 65, 185));
            
            
            /*          
            foreach(Person somebody in persons)
            {
                Console.WriteLine(somebody.ToString());
                
            }
            */



            //Try find person




            //string SSN = "123123132-123";
            /*
            foreach (Person somebody in persons)
            {
                if(somebody.SSN == SSN)
                {
                    Console.WriteLine("SSN found");
                    break;//jump out of foreach
                }
                
            }
            */





            Person found = persons.Find(x => x.Age == 70);
            if (found != null)
            {
                Console.WriteLine("Found him/her");
                persons.Remove(found);
            }
            else

            {
                Console.WriteLine("Person not found");
            }


            for(int i = 0; i<persons.Count; i++)
            {
                if(persons[i].Age == 88)
                {
                    persons.RemoveAt(i);//Warning it removes in loops i changes
                    break;
                   
                }
            }

            persons.Sort((x,y) => x.Age.CompareTo(y.Age));
            foreach (Person somebody in persons)
            {
                Console.WriteLine(somebody.ToString());

            }

            
            
            Console.ReadLine();



        }
    }
}
