using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjaluokka
{
    class Book
    {
        public string title;
        public string author;
        public string id;
        public double price;

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
        }

        public void Print()
        {
            Console.WriteLine($"{this.title}");
            Console.WriteLine($"{this.author}");
            Console.WriteLine($"{this.id}");
            Console.WriteLine($"{this.price}");
        }

        public string ComparePrice(string secondTitle, double secondPrice)
        {
            if (this.price > secondPrice)
                return $"{this.title} on kalliimpi kuin {secondTitle}.";
            else
                return $"{secondTitle} on kalliimpi kuin {this.title}.";

        }

    }
}
