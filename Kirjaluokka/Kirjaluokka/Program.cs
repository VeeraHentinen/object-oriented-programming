using System;

namespace Kirjaluokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjat:");
            Console.WriteLine("---------------------");

            Book firstBook = new Book("Kukkuu", "Kekkonen", "50678", 22.50);
            firstBook.Print();

            Console.WriteLine("---------------------");

            Book secondBook = new Book("Miau", "Kissa", "88905", 16.40);
            secondBook.Print();


             Console.WriteLine("---------------------");

            Console.WriteLine(firstBook.ComparePrice(secondBook.title, secondBook.price));
        }
    }
}
