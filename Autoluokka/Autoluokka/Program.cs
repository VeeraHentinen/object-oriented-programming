using System;

namespace Autoluokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auto-ohjelma");
            Console.WriteLine("---------------------------");

            Car firstCar = new Car ("", 0);
            Car secondCar = new Car("", 0);

            firstCar.AskData();
            Console.WriteLine("---------------------------");
            Console.WriteLine(firstCar.Print());
            Console.WriteLine("---------------------------");
            Console.WriteLine(firstCar.Accelerate());
            Console.WriteLine("---------------------------");
            Console.WriteLine(firstCar.Brake());

            Console.WriteLine("---------------------------");

            secondCar.AskData();
            Console.WriteLine("---------------------------");
            Console.WriteLine(secondCar.Print());
            Console.WriteLine("---------------------------");
            Console.WriteLine(secondCar.Accelerate());
            Console.WriteLine("---------------------------");
            Console.WriteLine(secondCar.Brake());


        }
    }
}
