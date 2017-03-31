using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class A
    {
        public virtual void Test() { Console.WriteLine("A-Test()"); }
    }

    class B : A
    {
        // this method HIDES A.TEST()-method, only called through B type reference
        public override void Test() { Console.WriteLine("B-Test()"); }
    }

    class C : A
    {
        // this method OVERRIDES A.TEST()-method
        public override void Test() { Console.WriteLine("C-Test()"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Test(); // output "A-Test()"
            b.Test(); // output "B-Test()"
            c.Test(); // output "C-Test()"  

            a = new B();
            a.Test(); // output --> "A-Test()" // BASE class method used! (new)

            a = new C();
            a.Test(); // output --> "C-Test()" // DERIVED class method used! (override)

            Console.ReadLine();
        
    }   
    }
}
