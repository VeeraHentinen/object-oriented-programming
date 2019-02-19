using System;
using System.Globalization;

namespace Lipunhinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Lipun hinnan laskenta");
            Console.WriteLine("---------------------------");

            Ticket firstTicket = new Ticket(16);

            double ticketPrice1 = firstTicket.AgeDiscount();
            Console.WriteLine("---------------------------");
            double ticketPrice2 = firstTicket.MtkDiscount();
            Console.WriteLine("---------------------------");
            double ticketPrice3 = firstTicket.DrafteeDiscount();
            Console.WriteLine("---------------------------");

            if (ticketPrice1 < ticketPrice2 && ticketPrice1 < ticketPrice3)
            {
                Console.WriteLine($"{ticketPrice1}");
            }

            else if (ticketPrice2 < ticketPrice1 && ticketPrice2 < ticketPrice3)
            {
                Console.WriteLine($"{ticketPrice2}");
            }

            else if (ticketPrice3 < ticketPrice1 && ticketPrice3 < ticketPrice2)
            {
                Console.WriteLine($"{ticketPrice3}");
            }



        }
    }
}
