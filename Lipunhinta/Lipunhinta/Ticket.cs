using System;
using System.Collections.Generic;
using System.Text;

namespace Lipunhinta
{
    class Ticket
    {
        public int price;

        public Ticket(int price)
        {
            this.price = price;
        }

        public double MtkDiscount()
        {
            Console.WriteLine("Oletko MTK-jäsen? K/E");
            string answer1 = Console.ReadLine().ToUpper();

            if (answer1 == "K")
            {
                Console.WriteLine("Oletko opiskelija? K/E");
                string answer2 = Console.ReadLine().ToUpper();
                if (answer2 == "K")
                    return price * 0.40;
                else if (answer2 == "E")
                    return price * 0.85;
                else
                    return price;
            }

            else if (answer1 == "E")
            {
                Console.WriteLine("Oletko opiskelija? K/E");
                string answer2 = Console.ReadLine().ToUpper();
                if (answer2 == "K")
                    return price * 0.55;
                else if (answer2 =="E")
                    return price;
                else
                    return price;
            }

            else
            {
                return price;
            }
        }

        public double DrafteeDiscount()
        {
            Console.WriteLine("Oletko varusmies? K/E");
            string answer3 = Console.ReadLine().ToUpper();

            if (answer3 == "K")
            {
                    return price * 0.50;
            }

            else if (answer3 == "E")
            {
                    return price;
            }

            else
            {
                return price;
            }
        }

        public double AgeDiscount()
        {
            Console.WriteLine("Kuinka vanha olet?");
            Console.WriteLine("1. Alle 7");
            Console.WriteLine("2. 7-15");
            Console.WriteLine("3. 15-64");
            Console.WriteLine("4. Yli 65");

            string answer4 = Console.ReadLine();

            if (answer4 == "1")
            {
                return price * 0;
            }

            else if (answer4 == "2")
            {
                return price * 0.5;
            }

            else if (answer4 == "3")
            {
                return price;
            }

            else if (answer4 == "4")
            {
                return price * 0.5;
            }

            else
            {
                return price;
            }
        }





    }
}
