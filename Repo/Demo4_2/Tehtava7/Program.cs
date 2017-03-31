using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Vehicle test0 = new Vehicle("Ajoneuvo", "Toyota GTX 123", "Toyota", 20000.05f);
            Car test1 = new Car("Audi", "123456", "Audi", 2546.0f, "V7", "45R/34", "Disel");
            Bicycle test2 = new Bicycle("Name", "Bi28R", "sdad", 249.95f, "12R/45", 7);
            Boat test3 = new Boat("Boat", "SuperSpeed 200TXR", "Finnish boats", 15000f, "2xV7", "Gasoline");
            Motorcycle test4 = new Motorcycle("Motor2", "2004X", "Publ_X", 4500.00F, "MotorC_2C", "15R/45", "Gasoline");

            List<Vehicle> garage = new List<Vehicle>();
            garage.Add(test0);
            garage.Add(test1);
            garage.Add(test2);
            garage.Add(test3);
            garage.Add(test4);
            
            
            bool cont = true;

            do
            {
                Console.WriteLine("1. Print all existing vehicle's\n2. Add new vehicles\n3. End program");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        foreach (Vehicle vehicl in garage)
                        {
                            Console.WriteLine(vehicl.ToString());
                        }
                        break;

                    case 2:
                        

                        bool cont2 = true;
                        string name1;
                        string model1;
                        string producer1;
                        float price1;
                        string motor;
                        string tire_type;
                        string fuel;


                        do
                        {
                            Console.WriteLine("Create a new:\n1. Car\n2. Boat\n3. Motorcycle\n4. Bicycle\n5. Cancel");
                            Console.WriteLine("\n");

                            int j;
                            int q;

                            string input2 = Console.ReadLine();
                            if (!int.TryParse(input2, out j))
                            {
                                q = 0;
                            }
                            else
                            {
                                q = Convert.ToInt16(input2);
                            }



                            if (q >= 1 && q <= 4)
                            {
                                Console.WriteLine("Name:");
                                name1 = Console.ReadLine();

                                Console.WriteLine("Model:");
                                model1 = Console.ReadLine();

                                Console.WriteLine("Producer:");
                                producer1 = Console.ReadLine();

                                Console.WriteLine("Price (\u20AC):");
                                price1 = int.Parse(Console.ReadLine());

                                switch (q)
                                {
                                    case 1:

                                        Console.WriteLine("Motor:");
                                        motor = Console.ReadLine();

                                        Console.WriteLine("Tire type:");
                                        tire_type = Console.ReadLine();

                                        Console.WriteLine("Fuel:");
                                        fuel = Console.ReadLine();

                                        Car input_car = new Car(name1, model1, producer1, price1, motor, tire_type, fuel);
                                        garage.Add(input_car);
                                        Console.WriteLine(input_car.ToString());
                                        cont2 = false;
                                        break;

                                    case 2:

                                        Console.WriteLine("Motor:");
                                        motor = Console.ReadLine();

                                        Console.WriteLine("Fuel:");
                                        fuel = Console.ReadLine();

                                        Boat Bt = new Boat(name1, model1, producer1, price1, motor, fuel);
                                        Console.WriteLine(Bt.ToString());
                                        garage.Add(Bt);
                                        cont2 = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Motor:");
                                        motor = Console.ReadLine();
                                        Console.WriteLine("Tire type:");
                                        tire_type = Console.ReadLine();
                                        Console.WriteLine("Fuel:");
                                        fuel = Console.ReadLine();

                                        Motorcycle Mt = new Motorcycle(name1, model1, producer1, price1, motor, tire_type, fuel);
                                        garage.Add(Mt);
                                        Console.WriteLine(Mt.ToString());
                                        cont2 = false;
                                        break;

                                    case 4:
                                        Console.WriteLine("Tire type:");
                                        tire_type = Console.ReadLine();

                                        Console.WriteLine("Numbber of gears");
                                        int gearing = int.Parse(Console.ReadLine());

                                        Bicycle Bi = new Bicycle(name1, model1, producer1, price1, tire_type, gearing);
                                        garage.Add(Bi);
                                        Console.WriteLine(Bi.ToString());
                                        cont2 = false;
                                        break;

                                }
                            }
                            else
                            {
                                switch (q) {
                                    case 5:
                                        Console.WriteLine("Canceling...");
                                        cont2 = false;
                                        break;
                                    case 0:
                                        Console.WriteLine("Input: (" + input2 + ") not regonized. Try again");
                                        break;
                            }
                                
                            

                            }
                        } while (cont2 == true);

                        break;


                    case 3:
                        Console.WriteLine("Ending program...");
                        cont = false;
                        break;
                }

            

            } while (cont == true);


            Console.ReadLine();
        }
    }
}
