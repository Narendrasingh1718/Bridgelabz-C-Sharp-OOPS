using System;
using System.Collections.Generic;
using System.Text;

namespace oops_program
{
    internal class Employee
    {
        String name;
        int id;
        double salary;
        public Employee(String name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Salary: " + salary);
        }

    }
}
