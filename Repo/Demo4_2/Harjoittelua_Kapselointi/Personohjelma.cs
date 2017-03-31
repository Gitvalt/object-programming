using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoittelua_Kapselointi
{
    class Personohjelma
    {
        static void Main(string[] args)
        {
            Person somebody = new Person();
            somebody.FirstName = "Joe";
            somebody.LastName = "Dirt";
            somebody.Address = "Unknown";
            somebody.Age = 29;
            somebody.PhoneNumber = "040-12313213";
            
            Console.WriteLine(somebody.ToString());

            Teacher teacher = new Teacher();
            teacher.FirstName = "Testi";
            teacher.LastName = "Immonen";
            teacher.Address = "asdsad";
            teacher.Age = 30;
            teacher.PhoneNumber = "040-1231231";
            teacher.Room = "D330";
            Console.WriteLine(teacher.ToString());

            Student valt = new Student();
            valt.FirstName = "Valtteri";
            valt.LastName = "Seuranen";
            valt.StudentID = "J123132";
            valt.Address = "asdsad";
            valt.Age = 30;
            valt.PhoneNumber = "040-1231231343";
            Console.WriteLine(valt.ToString());

            somebody.PersonMethod();
            teacher.PersonMethod();
            valt.PersonMethod();

            teacher.TeacherMethod();
            valt.StudentMethod();

            Console.ReadLine();
        }
    }
}
