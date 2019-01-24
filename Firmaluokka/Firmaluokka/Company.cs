using System;
using System.Collections.Generic;
using System.Text;

namespace Firmaluokka
{
    class Company
    {
        public string title;
        public string address;
        public string phone;
        public double outcome;
        public double expense;

        public Company (string title, string address, string phone, double outcome, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }

        public void Print()
        {
            Console.WriteLine($"{this.title}");
            Console.WriteLine($"{this.address}");
            Console.WriteLine($"{this.phone}");
            Console.WriteLine($"{this.outcome}");
            Console.WriteLine($"{this.expense}");
        }

        public string Profitability()
        {
            double profit = (outcome - expense) / expense * 100;

            if (profit < 100)
                return "Firmalla menee kehnosti.";

            else if (profit < 200)
                return "Firmalla menee välttävästi.";

            else if (profit < 300)
                return "Firmalla menee tyydyttävästi.";

            else
                return "Firmalla menee hyvin.";
        }

        public Company (Company previousCompany)
        {
            title = previousCompany.title;
            address = previousCompany.address;
            phone = previousCompany.phone;
            outcome = previousCompany.outcome;
            expense = previousCompany.expense;
        }
    }
}
