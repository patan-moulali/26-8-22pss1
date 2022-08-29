using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsonAug26;
using static HandsonAug26.Class1;

namespace HandsonAug26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create array of structure
            Class1.Employee[] emp = { new Employee(),
                       new Employee(),
                       new Employee() };

            // Pass the array indexes with values as structures
            emp[0].SetEmployee(1, "moulali", 23);
            emp[1].SetEmployee(2, "apsar", 27);
            emp[2].SetEmployee(3, "kousar", 30);

            // Call the display method
            emp[0].DisplayEmployee();
            emp[1].DisplayEmployee();
            emp[2].DisplayEmployee();
            Console.ReadKey();  
        }
    }
}