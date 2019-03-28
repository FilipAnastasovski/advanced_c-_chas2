using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICar
    {
        string MotorNumber { get; set; }
        void Refuel();
    }

    class Car : ICar
    {
        public string MotorNumber { get; set; }
        public void Refuel()
        {
            Console.WriteLine("This car drives on petrol");
        }

        public Car() { MotorNumber = "blabla" + "-N"; }
        public Car(string endgineNumber)
        {
            MotorNumber = endgineNumber + "-N"; // normal  car
        }
    }

    public class ElectricCar : ICar
    {

        public int BatteryLifeMonths { get; set; }
        public int BatteryDuration { get; set; }
        public string MotorNumber { get; set; }
        public virtual void  Refuel()
        {
            Console.WriteLine("This car has batteries");
        }

        public ElectricCar() { MotorNumber = "0000000000" + "-E"; }
        public ElectricCar(string endgineNumber)
        {
            MotorNumber = endgineNumber + "-E"; // electric  car
        }

        public ElectricCar(string endgineNumber, int blf, int bd)
        {
            MotorNumber = endgineNumber + "-E"; // electric  car
            BatteryDuration = bd;
            BatteryLifeMonths = blf;
        }
        
        public string PrintInfo()
        {
            return MotorNumber + " " + BatteryLifeMonths + " " + BatteryLifeMonths;
        }

    }

    public class HybridCar : ElectricCar
    {
        public int BatteryLifeMonths { get; set; }
        public int BatteryDuration { get; set; }
        public string MotorNumber { get; set; }
        public override void Refuel()
        {
            Console.WriteLine("This car has batteries and petrol");
        }

        public HybridCar() { MotorNumber = "0000000000" + "-H"; }
        public HybridCar(string endgineNumber)
        {
            MotorNumber = endgineNumber + "-E"; // hubrid  car
        }

        public HybridCar(string endgineNumber, int blf, int bd)
        {
            MotorNumber = endgineNumber + "-E"; // hubrid  car
            BatteryDuration = bd;
            BatteryLifeMonths = blf;
        }
    }
}
