using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonAug26
{
    internal class Class1
    {
        public struct Employee
        {

            // Declare three variables
            // id, name and age
            public int Id;
            public string Name;
            public int Age;

            // Set the employee details
            public void SetEmployee(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }

            // Display employee details
            public void DisplayEmployee()
            {
                Console.WriteLine("Employee:");
                Console.WriteLine("\tId    : " + Id);
                Console.WriteLine("\tName   : " + Name);
                Console.WriteLine("\tAge   : " + Age);
                Console.WriteLine("\n");
            }

        }
    }
}