using System;
using System.Collections.Generic;
using System.Text;

namespace Työntekijäluokka
{
    class Employee
    {
        public string name;
        public string id;
        public string position;
        public double salary;

        public Employee (string name, string id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public void Print()
        {
            Console.WriteLine($"{this.name}");
            Console.WriteLine($"{this.id}");
            Console.WriteLine($"{this.position}");
            Console.WriteLine($"{this.salary}");
        }

        public override string ToString()
        {
            return $"{name}, {id}, {position}, {salary}";
        }

        public static string CompareSalary(Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.salary > secondEmployee.salary)
                return $"{firstEmployee.name} tienaa enemmän kuin {secondEmployee.name}.";
            else
                return $"{secondEmployee.name} tienaa enemmän kuin {firstEmployee.name}.";

        }

    }
}
