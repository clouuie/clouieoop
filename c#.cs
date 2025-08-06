using System;
using ououoop;

namespace ououoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Program2 name1 = new Program2();
            //Program2 name2 = new Program2();
            //name1.me("Kate");
            //name2.me("Clouie");

            Vehicle kotse1 = new Vehicle();
            Car kotse2 = new Car();
            kotse1.StartEngine();
            kotse2.UmaandarSa();
            kotse2.StartEngine();
        }
    }

    public class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Broom broom!");
        }
    }

    public class Car : Vehicle
    {
        public void UmaandarSa()
        {
            Console.WriteLine("Umaandar sa lupa");
        }
    }
}