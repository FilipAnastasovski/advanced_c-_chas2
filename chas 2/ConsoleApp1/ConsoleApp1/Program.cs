using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class PrintData
    {
        public void Print(System.Int16 i)
        {
            Console.WriteLine("Type int: {0}", i);
        }

        public void Print(decimal i)
        {
            Console.WriteLine("Type decimal: {0}", i);
        }

        public void Print(System.Double i)
        {
            Console.WriteLine("Type decimal: {0}", i);
        }

        public void Print(List<string> args)
        {
            foreach (var item in args)
                Console.WriteLine("\t List: {0}", item);
        }

        public void Print(Dictionary<int, string> args)
        {
            foreach (var item in args)
                Console.WriteLine("\t Dictionary: {0}", item.Value);
        }
        // za sekoj tip na dictionary, generic
        public void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine("\t : {0}", item);
            }
        }
    }

    class Program
    {

        class Caller
        {
            public void CallerArea(Shape s)
            {
                Console.WriteLine("Area {0}", s.Area());
            }
        }




        static void Main(string[] args)
        {
            #region print raboti
            /*
            #region
            PrintData pd = new PrintData();
            pd.Print(100);
            pd.Print(100.5M);
            pd.Print(100.5F);

            List<string> strings = new List<string>()
            {
                "igor","dejan","marko"
            };

            pd.Print(strings);


            Dictionary<int, string> people = new Dictionary<int, string>();
            
            people.Add(1, "Bob");
            people.Add(2, "Midge");
            people.Add(3, "Red");

            pd.Print(people);
            #endregion
            */
            #endregion
            #region koli
            /*
                        Car car1 = new Car();
                        Car car2 = new Car("234234234234");

                        Console.WriteLine(car1.MotorNumber);
                        car1.Refuel();
                        Console.WriteLine("-----------");
                        Console.WriteLine(car2.MotorNumber);
                        car2.Refuel();
                        Console.WriteLine("---------");

                        ElectricCar eCar1 = new ElectricCar();
                        ElectricCar eCar2 = new ElectricCar("23424dfgdfdf",120,400);

                        Console.WriteLine(eCar1.MotorNumber);
                        eCar1.Refuel();
                        Console.WriteLine("-----------");
                        Console.WriteLine(eCar2.MotorNumber + " " + eCar2.BatteryDuration + " " + eCar2.BatteryLifeMonths );
                        eCar2.Refuel();
                        Console.WriteLine("---------");
                        eCar2.PrintInfo();


                        ElectricCar hCar1 = new ElectricCar();
                        ElectricCar hCar2 = new ElectricCar("23424dfgdfdf", 200, 100);

                        Console.WriteLine(hCar1.MotorNumber);
                        hCar1.Refuel();
                        Console.WriteLine("-----------");
                        Console.WriteLine(hCar2.MotorNumber + " " + hCar2.BatteryDuration + " " + hCar2.BatteryLifeMonths);
                        hCar2.Refuel();
                        Console.WriteLine("---------");
                        Console.WriteLine(hCar2.PrintInfo());

                        ICar[] cars =
                        {
                            new Car("sdfsdf4234234"),
                            new ElectricCar("sdfsfsdf",120,400),
                            new HybridCar("sdfsdf353df")
                        };
                        */
            #endregion

            #region animals
            /*
            Dog dog = new Dog();
            Console.WriteLine(dog.Describe());

            Labrador gold = new Labrador();
            Console.WriteLine(gold.Describe());

            Bird polly = new Bird();
            Console.WriteLine(polly.Describe());
            */
            #endregion


            #region shapes


            Caller c = new Caller();

            Shape s1 = new Shape();
            Shape s2 = new Shape(4,5);
            Console.WriteLine(s1.Area());
            Console.WriteLine(s2.Area());

            c.CallerArea(s2);
            

            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(5,6);
            Console.WriteLine( r1.Area());
            Console.WriteLine( r2.Area());

            Rectangle t1 = new Rectangle();
            Rectangle t2 = new Rectangle(2, 3);
            Console.WriteLine(t1.Area());
            Console.WriteLine(t2.Area());

            Circle c1 = new Circle(5);
            Console.WriteLine(c1.Area());



            #endregion

            Console.ReadLine();
        }
    }
}