using System;
using System.Collections.Generic;
using System.Text;

namespace Autoluokka
{
    class Car
    {
        public string brand;
        public int speed;


        public Car(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;

        }

        public void AskData()
        {
            Console.WriteLine("Auton malli");
            brand = Console.ReadLine();

            Console.WriteLine("Auton nopeus");
            string speedValue = Console.ReadLine();

            int.TryParse(speedValue, out speed);

            
        }

        public string Print()
        {
            return $"Auton malli: {brand}, nopeus {speed}.";
        }

        public void IncreaseSpeed(int value)
        {
            this.speed = this.speed + value;
        }

        public void PrintSpeed()
        {
            Console.WriteLine(this.brand, this.speed);
        }
        
        public string Accelerate()
        {
            Console.WriteLine("Kuinka paljon nopeutta kasvatetaan?");
            string accelerationValue = Console.ReadLine();

            int.TryParse(accelerationValue, out int acceleration);
            int newSpeed = speed + acceleration;

            if (newSpeed < speed)
            {
                return "Negatiivinen muutos ei ole sallittu.";
            }

            else
            {
                this.speed = newSpeed;
                return $"Uusi nopeus on {newSpeed}";
            }

            
            
        }

        public string Brake()
        {
            Console.WriteLine("Jarrutetaanko? K/E");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "K")
            {
                return $"Uusi nopeus on { speed - speed * 0.1}.";
            }

            else if (answer == "E")
            {
                return $"Nopeus on edelleen {speed}.";
            }

            else
            {
                return "Väärä syöte!";
            }
        }
        


    }
}
