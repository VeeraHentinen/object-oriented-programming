using System;

namespace Työntekijäluokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Työntekijäohjelma");
            Console.WriteLine("------------------------------");

            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Matti", "123", "Siivooja", 14.25);
            employees[1] = new Employee("Seppo", "987", "Myyjä", 15.04);
            employees[2] = new Employee("Liisa", "666", "Myymäläpäällikkö", 16.98);
            
            foreach (Employee person in employees)
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine("------------------------------");

            Console.WriteLine(Employee.CompareSalary(employees[0], employees[1]));

        }
    }
}
