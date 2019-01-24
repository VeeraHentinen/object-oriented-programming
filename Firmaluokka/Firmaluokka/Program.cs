using System;

namespace Firmaluokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firmaohjelma");
            Console.WriteLine("------------------------------");

            Company firstCompany = new Company("Nalle", "Metsä", "777", 33000, 18000);
            firstCompany.Print();
            Console.WriteLine(firstCompany.Profitability());
    
            Console.WriteLine("------------------------------");

            Company secondCompany = new Company("Ahven", "Järvi", "666", 45000, 5500);
            secondCompany.Print();
            Console.WriteLine(secondCompany.Profitability());

            Console.WriteLine("------------------------------");

            Company thirdCompany = new Company("Koira", "Koppi", "999", 22000, 11000);
            thirdCompany.Print();
            Console.WriteLine(thirdCompany.Profitability());

            Console.WriteLine("------------------------------");

            Company fourthCompany = new Company(thirdCompany);
            fourthCompany.Print();
            Console.WriteLine(fourthCompany.Profitability());

            Console.WriteLine("------------------------------");


        }
    }
}
