using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string Rate1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hours worked per week?");
            string Hours1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string Rate2 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hours worked per week?");
            string Hours2 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Annual salary of Person 1:");
            int sal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Annual salary of Person 2:");
            int sal2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine();


            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool issal = sal1 > sal2;
            Console.WriteLine(issal);
            Console.ReadLine();
        }
    }
}
