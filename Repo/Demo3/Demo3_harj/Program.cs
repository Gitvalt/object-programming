using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_harj
{
    class Car
    {

        //Readonly kuuluu esim. sarjanumeroille
        public Car(string model, int cc)
        {
            this.model = model;
            this.cc = cc;
        }
        public int EngineSize
        {
            get { return cc; }
        }

        public string ModelProperty
        {
            get { return model; }
            set {
                if(value =="corolla" || value == "avensis")
                {
                    model = value;
                }
                else
                {
                    model = "unknown";
                }
                     }
        }
        private string model;
        private readonly int cc;
        private const int maxSpeed = 10; //laittamalla arvon näin, arvoa ei voida muuttaa (readonly)
        //kun laitetaan const niin se on ikuisesti samanlainen kaikilla olioilla (kaikkien autojen max nopeus 10)
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car[] toyotas = new Car[1000];

            for(int i=0; i < 1000; i++)//luodaan tuhat avensis autoa
            {
                toyotas[i] = new Car("avensis", 1895);
            }

            Car toyota = new Car("avensis", 1895);
            Car toyota2 = new Car("corolla", 1599);
            Car toyota3 = new Car("gt86", 1999);

            toyota.ModelProperty = "corolla";

            Console.WriteLine("This toyota model is: " + toyota.ModelProperty);
            //Console.WriteLine("This toyota engine size is: " + toyota.cc);
            Console.ReadLine();
        }
    }
}
